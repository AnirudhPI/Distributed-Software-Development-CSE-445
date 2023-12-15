<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h1 id="assignmentName">Assignment 1</h1>
        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="celciusToFahrenheit">Temperature Convention</h2>
                <p>
                Use this to convert Celsius temperature to Fahrenheit :                
                </p>
                <div>
                    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                    <br>
                    <asp:Button ID="Button1" runat="server" Text="Convert" OnClick="Button1_Click" />
                    <br>
                    <asp:Label ID="Label1" runat="server" Text="Your answer is displayed here"></asp:Label>
                    </br>
                </div>
                
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="fahrenheitToCelcius">Temperature Convention</h2>
                <p>
                    Use this to convert Fahrenheit temperature to Celcius :  
                </p>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Convert" OnClick="Button2_Click" />
                <br>
                <asp:Label ID="Label2" runat="server" Text="Your answer is displayed here"></asp:Label>
                <br>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="sortingNumbers">Sort Numbers</h2>
                <p>
                    Input has to be a set of numbers seperated by commas
                </p>
                <p>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button3" runat="server" Text="Sort" OnClick="Button3_Click" />
                    <br>
                    <asp:Label ID="Label3" runat="server" Text="Your answer is displayed here"></asp:Label>
                    <br>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
