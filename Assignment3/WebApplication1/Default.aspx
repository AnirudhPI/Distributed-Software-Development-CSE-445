<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h1 id="assignmentName">Assignment 3</h1>
        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="solar">Solar Energy</h2>
                <p>
                    avg_dni	- Average Direct Normal Irradiance: This data provides monthly average and annual average
                    daily total solar resource averaged over surface cells of 0.1 degrees in both latitude and longitude,
                    or about 10 km in size. The values returned are kWh/m2/day.
                </p>
                <p>
                    avg_ghi - Average Global Horizontal Irradiance: This data provides monthly average and annual average
                    daily total solar resource averaged over surface cells of 0.1 degrees in both latitude and longitude,
                    or about 10 km in size. The values returned are kWh/m2/day.
                </p>
                <p>
                    avg_lat_tilt - Average Tilt at Latitude: This data provides monthly average and annual average daily
                    total solar resource averaged over surface cells of 0.1 degrees in both latitude and longitude, or 
                    about 10 km in size. The values returned are kWh/m2/day.
                </p>
                <p>
                    Use Exact city coordinates for data to be available.
                    Eg: Tempe - lat = 33.427204 lon = -111.939896
                </p>
                <div>
                    <p> Latitude: </p><asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                    <br>
                    <p> Longitude: </p><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br>
                    <asp:Button ID="Button1" runat="server" Text="Get Results" OnClick="Button1_Click" />
                    <br>
                    <asp:Label ID="Label1" runat="server" Text="Your answer is displayed here"></asp:Label>
                    </br>
                </div>
        
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="wind">Wind Energy</h2>
                <p>
                    WR10M: Wind Rose at 10 meters. WR50M: Wind Rose at 50 meters,
                    WD_PCT: Wind Direction Percent, WD_AVG: Wind Direction Average Wind Speed
                </p>

                <p>
                    Wait for some time for API to load. 
                    Displays speeds in South Direction. Use Exact city coordinates for data to be available.
                    Eg: Tempe - lat = 33.427204 lon = -111.939896  
                </p>
                <p> Latitude: </p><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br>
                <p> Longitude: </p><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br>
                <asp:Button ID="Button2" runat="server" Text="Get Results" OnClick="Button2_Click" />
                <br>
                <asp:Label ID="Label2" runat="server" Text="Your answer is displayed here"></asp:Label>
                <br>
            </section>
        </div>
    </main>

</asp:Content>
