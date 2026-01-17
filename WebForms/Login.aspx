<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Login.aspx.cs"
    Inherits="WebForms.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Login</h2>

    <asp:Label Text="Username:" runat="server" />
    <asp:TextBox ID="txtUsername" runat="server" />
    <br /><br />

    <asp:Label Text="Password:" runat="server" />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
    <br /><br />

    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    <br /><br />

    <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />

</asp:Content>

