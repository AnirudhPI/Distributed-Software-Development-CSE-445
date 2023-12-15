using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // This button click function is used to call the Temperature service by passing the value and
        // then updating the answer.
        // Exceptions are handled for invalid input
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating the object
                TemperatureConventionReference1.TemperatureConvention1Client tempService =
                new TemperatureConventionReference1.TemperatureConvention1Client();

                String celcius = TextBox1.Text;
                // Input taken as string is tried to parse as float and passed as parameter to service and obtain the output.
                try
                {
                    float celcius_float = float.Parse(celcius);
                    float answer = tempService.c2f(celcius_float);
                    Label1.Text = answer.ToString("0.00");
                }
                // Exception caught based on Format exception due to invalid input value like strings instead of numbers
                catch (FormatException ex)
                {
                    Label1.Text = "Input must be a float";
                }
                // Service reference has failed to load. Need to rerun the services again in order to bind
                catch (Exception ex)
                {
                    Label1.Text = "Not able to connect to service. Try starting services again.";
                }
            }
            // Service was not discovered. Need to identify the services using add service reference and discover.
            catch (Exception serviceException)
            {
                Label1.Text = "Services are not discovered.  Add service references from discovery.";
            }
            
        }


        // This button click function is used to call the Temperature service by passing the value and
        // then updating the answer.
        // Exceptions are handled for invalid input
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating the object
                TemperatureConventionReference1.TemperatureConvention1Client tempService =
                new TemperatureConventionReference1.TemperatureConvention1Client();

                String fahrenheit = TextBox2.Text;
                // Input taken as string is tried to parse as float and passed as parameter to service and obtain the output.
                try
                {
                    float fahrenheit_float = float.Parse(fahrenheit);
                    float answer = tempService.f2c(fahrenheit_float);
                    Label2.Text = answer.ToString("0.00");
                }
                // Exception caught based on Format exception due to invalid input value like strings instead of numbers
                catch (FormatException ex)
                {
                    Label2.Text = "Input must be a float";
                }
                // Service reference has failed to load. Need to rerun the services again in order to bind
                catch (Exception ex)
                {
                    Label2.Text = "Not able to connect to service. Try starting services again.";
                }
            }
            // Service was not discovered. Need to identify the services using add service reference and discover.
            catch (Exception serviceException)
            {
                Label2.Text = "Services are not discovered. Add service references from discovery.";
            }
        }

        // This button click function is used to call the Sorting service by passing the value and
        // then updating the answer.
        // Exceptions are handled for invalid input
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating the object
                SortingServiceReference1.SortingService1Client sortService =
                new SortingServiceReference1.SortingService1Client();

                String unsorted = TextBox3.Text;
                try
                {
                    // Fetch output from service and update answer in label
                    string answer = sortService.Sort(unsorted);
                    Label3.Text = answer;
                }
                // Exception caught based on Fault exception passed by the service due to invalid input value like strings instead of numbers
                catch (FaultException ex) 
                {
                    Label3.Text = "Numbers are in invalid format. Try different input.";
                }
                // Service reference has failed to load. Need to rerun the services again in order to bind
                catch (Exception ex)
                {
                    Label3.Text = "Not able to connect to service. Try starting services again.";
                }
            }
            // Service was not discovered. Need to identify the services using add service reference and discover.
            catch (Exception serviceException)
            {
                Label3.Text = "Not able to connect to service. Add service references from discovery.";
            }
        }
    }
}