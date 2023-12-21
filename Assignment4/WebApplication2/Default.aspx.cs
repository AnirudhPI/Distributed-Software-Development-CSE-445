using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
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
                // Send a request to localhost API
                RestClient client = new RestClient("http://localhost:62545/Service1.svc/GetPlaceInformation?zipcode=" + TextBox1.Text);
                //RestRequest for the required endpoint
                RestRequest request = new RestRequest("", Method.Get);
                request.AddHeader("accept", "application/json");
                RestResponse response = client.Execute(request);
                String responseString = response.Content;
                if (response.IsSuccessful)// Handle success response
                {
                    if (responseString.Length == 0)
                    {
                        Label1.Text = "Invalid Inputs!";
                    }
                    else
                    {
                        Label1.Text = responseString;
                    }
                }
                else
                {
                    Label1.Text = "Error occured in Service!";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Exception" + ex;

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating the object
                RecipeReference.Service1Client recipeService = new RecipeReference.Service1Client();

                String dish = TextBox2.Text;
                // Input taken as string and passed as parameter to service and obtain the output.
                try
                {
                    string answer = recipeService.GetRecipeList(dish);
                    Label2.Text = answer;
                }
                // Exception caught based on Format exception due to invalid input value
                catch (FormatException ex)
                {
                    Label2.Text = "Input must be a string";
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