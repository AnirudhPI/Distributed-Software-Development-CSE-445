using System;
using System.Collections.Generic;
using System.Linq;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating the object
                SolarEnergyReference.Service1Client solarService = new SolarEnergyReference.Service1Client();

                String latitude = TextBox1.Text;
                String longitude = TextBox2.Text;
                // Input taken as string is tried to parse as double and passed as parameter to service and obtain the output.
                try
                {
                    double latitude_double = double.Parse(latitude);
                    double longitude_double = double.Parse(longitude);
                    string answer = solarService.GetSolarReport(latitude_double, longitude_double);
                    Label1.Text = answer;
                }
                // Exception caught based on Format exception due to invalid input value like strings instead of numbers
                catch (FormatException ex)
                {
                    Label1.Text = "Input must be a double";
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
                Label1.Text = "Services are not discovered. Add service references from discovery.";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating the object
                WindEnergyReference.Service1Client windService = new WindEnergyReference.Service1Client();

                String latitude = TextBox3.Text;
                String longitude = TextBox4.Text;
                // Input taken as string is tried to parse as double and passed as parameter to service and obtain the output.
                try
                {
                    double latitude_double = double.Parse(latitude);
                    double longitude_double = double.Parse(longitude);
                    string answer = windService.GetWindReport(latitude_double, longitude_double);
                    Label2.Text = answer;
                }
                // Exception caught based on Format exception due to invalid input value like strings instead of numbers
                catch (FormatException ex)
                {
                    Label2.Text = "Input must be a double";
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
    }
}