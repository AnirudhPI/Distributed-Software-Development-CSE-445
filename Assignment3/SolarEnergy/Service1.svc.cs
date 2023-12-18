using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI.WebControls;

namespace SolarEnergy
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string GetSolarReport(double lati, double longi)
        {
            // Initialize an empty report string
            string report = "";

            // Call the GetSolarEnergyData method to retrieve solar energy data for the given latitude and longitude
            SolarEnergyData data = GetSolarEnergyData(lati, longi);

            // Check if there are any errors in the retrieved data
            if (data.errors.Count != 0)
            {
                report += data.errors[0].ToString();
            }
            // Check if there are any warnings in the retrieved data
            else if (data.warnings.Count != 0)
            {
                report += data.warnings[0].ToString();
            }
            else
            {
                // If there are no errors or warnings, construct a report string with solar energy _data
                report += "avg_dni: " + data.outputs.avg_dni.annual.ToString() + " avg_ghi: " +
                    data.outputs.avg_ghi.annual.ToString() + " avg_lat_tilt: " +
                    data.outputs.avg_lat_tilt.annual.ToString();
            }
            return report;
        }

        //Source: https://developer.nrel.gov/docs/solar/solar-resource-v1/

        public SolarEnergyData GetSolarEnergyData(double lati, double longi)
        {
            string html = string.Empty;
            // Construct the URL for the NREL API with latitude, longitude, and API key as query parameters
            string getSolarEnergyURL = @"https://developer.nrel.gov/api/solar/solar_resource/v1.json?" 
            + "api_key=" + "&lat=" + lati.ToString() + "&lon=" 
            + longi.ToString();
            //lat=33.427204&lon=-111.939896

            // Create an HTTP request object and set up decompression for gzip-encoded responses
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getSolarEnergyURL);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            HttpWebResponse response;

            try
            {
                // Attempt to make an HTTP GET request to the constructed URL
                response = (HttpWebResponse)request.GetResponse();

                if (response != null)
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // Read the response content into a string variable
                        using (Stream stream = response.GetResponseStream())
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            html = reader.ReadToEnd();
                        }
                    }
                }
                // Handle the case where the response is null
                else if (response == null) { html = string.Empty; }
                // Handle the case where the response status code is not OK
                else { html = ""; }
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse errorResponse)
                {
                    // Handle WebException and read the error response content
                    using (Stream errorStream = errorResponse.GetResponseStream())
                    using (StreamReader reader = new StreamReader(errorStream))
                    {
                        string errorResponseContent = reader.ReadToEnd();
                        Console.WriteLine("Error Response Body: " + errorResponseContent);
                        html = errorResponseContent;
                    }
                }
            }


            var tempReport = new SolarEnergyData();
            try
            {
                // Attempt to deserialize the HTML content into a SolarEnergyData object
                tempReport = JsonConvert.DeserializeObject<SolarEnergyData>(html);
            }
            catch (Exception ex)
            {
                // Handle exceptions by manually extracting data from the JSON response using JObject
                JObject jsonObject = JObject.Parse(html);

                // Extract version, sources, latitude, and longitude
                tempReport.version = jsonObject["version"].ToString();

                JArray sourcesArray = (JArray)jsonObject["metadata"]["sources"];

                // Convert the JArray to a list of strings
                List<string> sourcesList = sourcesArray.ToObject<List<string>>();

                tempReport.metadata.sources = sourcesList;

                tempReport.inputs.lon = jsonObject["inputs"]["lon"].ToString();
                tempReport.inputs.lat = jsonObject["inputs"]["lat"].ToString();

                // Add a warning message indicating no data found
                tempReport.warnings.Add("No data found");
            }
            // Return the populated tempReport object, which contains either data or warning messages
            return tempReport;
            
        }
    }
}
