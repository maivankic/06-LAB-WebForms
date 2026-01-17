<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Register.aspx.cs"
    Inherits="WebForms.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Register</h2>

    <asp:Label Text="Username:" runat="server" />
    <asp:TextBox ID="txtUsername" runat="server" />
    <br /><br />

    <asp:Label Text="Full name:" runat="server" />
    <asp:TextBox ID="txtFullName" runat="server" />
    <br /><br />

    <asp:Label Text="Password:" runat="server" />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
    <br /><br />

    <asp:Label Text="Repeat password:" runat="server" />
    <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" />
    <br /><br />

    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
    <br /><br />

    <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />

</asp:Content>

