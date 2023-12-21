using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Recipes
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetRecipeList(string dish)
        {
            string html = string.Empty;
            // Construct the URL for the spoonacular API with dish as query parameter
            string getPlaceInformationURL = @""
            + dish.ToString();

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


            var dishReport = new Recipes();
            dishReport.results = new List<Result>();

            string response_data = "";
            List<string> recipies = new List<string>();
            try
            {
                // Attempt to deserialize the HTML content into a Recipes object
                dishReport = JsonConvert.DeserializeObject<Recipes>(html);
                if (dishReport!= null ) {
                    foreach (Result item in dishReport.results)
                    {
                        recipies.Add(item.title.ToString());
                    }
                    response_data = string.Join(", ", recipies);
                }
                else {
                    response_data = "Please provide valid dish.";
                }
                
            }
            catch (Exception ex)
            {
                response_data = "Please provide valid dish.";
            }
            if (response_data == "")
            {
                response_data = "Please provide valid dish.";
            }
            // Return the adjusted response_data
            return response_data;
        }
    }

}
