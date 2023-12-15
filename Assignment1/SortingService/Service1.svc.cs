using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace SortingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class SortingService1 : ISortingService1
    {
        // This method cleans the input string first to remove unnecessary white spaces and trims all blank values
        // Then the values are filled in an array to sort the values and later merged back to a string to display the output.
        // Exception is handled if the value entered in the input is not a number.
        public string Sort(String numbers)
        {
            // The two lines below clean the input string of white spaces and empty objects due to multiple
            // consecutive commas and add the numbers to an array
            string[] stringValues = Regex.Replace(numbers, @"\s+", "").Split(',');
            string[] filteredArray = stringValues.Where(item => !string.IsNullOrEmpty(item)).ToArray();

            // new array created of size filtered array
            double[] doubleValues = new double[filteredArray.Length];

            // Each element in the filtered array is tried to parse as double
            for (int i = 0; i < filteredArray.Length; i++)
            {
                try
                {
                    doubleValues[i] = double.Parse(filteredArray[i]);
                }
                // Any invalid element like string caught will throw a FaultException for application to be caught
                catch {
                    throw;
                }  
            }

            // Array is sorted and converted back to a string and returned
            Array.Sort(doubleValues);
            string sortedString = string.Join(", ", doubleValues);
            return sortedString;

        }

    }
}
