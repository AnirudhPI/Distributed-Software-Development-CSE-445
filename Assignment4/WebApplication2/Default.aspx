<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h1 id="assignmentName">Assignment 4</h1>
        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="celciusToFahrenheit">Get Place Information</h2>
                <p>
                    Put in Zipcode to obtain the latitude and longitude of the location. Eg - 85281(Tempe)
                </p>
                <div>
                    <p> Zipcode: </p><asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                    <br>
                    <asp:Button ID="Button1" runat="server" Text="Get Results" OnClick="Button1_Click" />
                    <br>
                    <asp:Label ID="Label1" runat="server" Text="Your answer is displayed here"></asp:Label>
                    </br>
                </div>

            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="fahrenheitToCelcius">Get Recipies</h2>
                <p>
                    Input any dish to get suggestions on what kind of recipies are available. Eg - Pasta, Chicken, etc..
                </p>

                <p> Dish: </p><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br>
                <asp:Button ID="Button2" runat="server" Text="Get Results" OnClick="Button2_Click" />
                <br>
                <asp:Label ID="Label2" runat="server" Text="Your answer is displayed here"></asp:Label>
                <br>
            </section>
        </div>
        
    </main>

</asp:Content>
