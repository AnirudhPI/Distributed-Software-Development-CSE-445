using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace Assignment_5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string ValidateXmlAgainstXsd(string xmlUrl, string xsdUrl)
        {
            try
            {
                // Create settings for XML validation against the XSD schema
                XmlReaderSettings validationSettings = new XmlReaderSettings();

                // Add the provided XSD schema for validation
                validationSettings.Schemas.Add(null, xsdUrl);

                // Set the validation type to schema
                validationSettings.ValidationType = ValidationType.Schema;

                // Create an XML reader to read and validate the XML
                using (XmlReader reader = XmlReader.Create(xmlUrl, validationSettings))
                {
                    while (reader.Read())
                    {
                        // Iterate through the XML to trigger validation
                    }
                }

                // If no validation errors occur, return a success message
                return "XML Validation Successful: No Errors Found";
            }
            catch (XmlSchemaValidationException validationException)
            {
                // If a validation error occurs, return the error message
                return "XML Validation Error: " + validationException.Message;
            }
            catch (Exception ex)
            {
                // Handle other exceptions and return their error messages
                return "Error: " + ex.Message;
            }
        }

        public List<string> SearchXmlByKeyword(string xmlSearchUrl, string keyword)
        {
            try
            {
                // Create an XmlDocument to load and manipulate the XML
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlSearchUrl);

                // Create a list to store the search results
                List<string> searchResults = new List<string>();

                // Use XPath to select all elements containing the specified keyword in their text content
                XmlNodeList matchingNodes = xmlDoc.SelectNodes("//*[contains(text(), '" + keyword + "')]");

                // Check if any matches were found
                if (matchingNodes.Count == 0)
                {
                    searchResults.Add("No matches found.");
                    return searchResults;
                }

                // Iterate through the matching nodes and add their outer XML to the results list
                foreach (XmlNode node in matchingNodes)
                {
                    searchResults.Add(node.OuterXml);
                }

                // Return the search results
                return searchResults;
            }
            catch (Exception ex)
            {
                // If an exception occurs, create a list for the error message
                List<string> errorResult = new List<string>();
                errorResult.Add("Error: " + ex.Message);
                return errorResult;
            }
        }
    }
}