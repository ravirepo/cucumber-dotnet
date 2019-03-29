<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <strong>Discount Calculator<br />
        </strong>
        <asp:Label ID="Label1" runat="server" Text="Your Profession"></asp:Label>
        <asp:TextBox ID="txtProfession" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Your State"></asp:Label>
        <asp:DropDownList ID="ddlState" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>NJ</asp:ListItem>
            <asp:ListItem>PA</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:CheckBox ID="isSeniorCitizen" runat="server" Text="Are you a senior citizen?" TextAlign="Left" />
        <br />
        Your Discount is (%): <asp:Label ID="lblDiscount" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" />
    </div>

    <div class="row">
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
