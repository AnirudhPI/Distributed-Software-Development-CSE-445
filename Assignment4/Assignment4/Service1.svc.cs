using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GetPlaceInformation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetPlaceInformation(double zipcode)
        {
            string html = string.Empty;
            // Construct the URL for the zippopotam API with zipcode as query parameter
            string getPlaceInformationURL = @"http://api.zippopotam.us/us/"
            + zipcode.ToString();

            // Create an HTTP request object and set up decompression for gzip-encoded responses
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getPlaceInformationURL);
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


            var placeReport = new PlaceInformation();

            string response_data = "";
            try
            {
                // Attempt to deserialize the HTML content into a PlaceInformation object
                placeReport = JsonConvert.DeserializeObject<PlaceInformation>(html);
                response_data += "latitude: " + placeReport?.places?[0]?.latitude + " longitude: " +
                placeReport?.places?[0]?.longitude;
            }
            catch (Exception ex)
            {
                response_data = "Please provide valid zipcode.";
            }
            if (placeReport?.places == null)
            {
                response_data = "Please provide valid zipcode.";
            }
            // Return the adjusted response_data
            return response_data;
        }
    }
}
