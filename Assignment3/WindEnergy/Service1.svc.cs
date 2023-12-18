using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WindEnergy
{
    public class Service1 : IService1
    {

        public string GetWindReport(double lati, double longi)
        {
            string report = "";
            
            // Retrieve wind energy data based on the provided latitude and longitude
            WindEnergyData data = GetWindEnergyData(lati, longi);

            // Check if the data type is not "Feature"
            if (data.type != "Feature")
            {
                // If the data type is not "Feature," it likely contains an error message, so add it to the report
                report += data.type;
            }
            else
            {
                // If the data type is "Feature," extract wind data and add it to the report
                report += "WD_PCT at 10M: " + data.properties.parameter.WR10M._1800.WD_PCT.ToString() + " m/s,"
                    + " WD_AVG at 10M: " + data.properties.parameter.WR10M._1800.WD_AVG.ToString() + " m/s,"
                    + " WD_PCT at 50M: " + data.properties.parameter.WR50M._1800.WD_PCT.ToString() + " m/s,"
                    + " WD_AVG at 50M: " + data.properties.parameter.WR50M._1800.WD_AVG.ToString() + " m/s";
            }
            // Return the generated wind energy report
            return report;
        }

        // Source https://power.larc.nasa.gov/docs/services/api/application/windrose/
        // https://power.larc.nasa.gov/api/pages/?urls.primaryName=Windrose

        public WindEnergyData GetWindEnergyData(double lati, double longi)
        {
            // Initialize an empty HTML string to store the response content
            string html = string.Empty;
            // Construct the URL for retrieving wind energy data based on the provided latitude and longitude
            string getWindEnergyURL = @"https://power.larc.nasa.gov/api/application/windrose/point" 
                + "?Longitude=" + longi.ToString() + "&latitude=" + lati.ToString() 
                + "&start=20130930&end=20230930&format=JSON";
            //-111.939896
            //33.427204

            // Create an HTTP request to the specified UR
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getWindEnergyURL);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            HttpWebResponse response;
            try
            {
                // Send the HTTP request and get the response
                response = (HttpWebResponse)request.GetResponse();

                if (response != null)
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // Read the response stream and store it in the 'html' variable
                        using (Stream stream = response.GetResponseStream())
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            html = reader.ReadToEnd();
                        }
                    }
                }
                // Handle the case where the response is null
                else if (response == null) { html = string.Empty; }
                // Handle other response status codes (not OK)
                else { html = ""; }
            }
            catch (WebException ex)
            {
                // Handle WebException, which may occur for various reasons
                if (ex.Response is HttpWebResponse errorResponse)
                {
                    using (Stream errorStream = errorResponse.GetResponseStream())
                    using (StreamReader reader = new StreamReader(errorStream))
                    {
                        string errorResponseContent = reader.ReadToEnd();
                        Console.WriteLine("Error Response Body: " + errorResponseContent);
                        html = errorResponseContent;
                    }
                }
            }

            try
            {
                // Attempt to deserialize the HTML response into a WindEnergyData object
                var tempReport = JsonConvert.DeserializeObject<WindEnergyData>(html);
                return tempReport;
            }
            catch(Exception ex) {
                // Handle exceptions that occur during deserialization
                Console.WriteLine("Error Response Body: ");
                JObject jsonObject = JObject.Parse(html);
                var tempReport = new WindEnergyData();
                // Update the error in messages
                tempReport.type = jsonObject["messages"][0].ToString();
                return tempReport;
            }
        }
    }
}
