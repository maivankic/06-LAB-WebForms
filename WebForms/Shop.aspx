<%@ Page Title="Shop" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Shop.aspx.cs"
    Inherits="WebForms.Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Shop</h2>

    <h3>Add product</h3>

    <asp:Label Text="Name:" runat="server" />
    <asp:TextBox ID="txtName" runat="server" />
    <br /><br />

    <asp:Label Text="Description:" runat="server" />
    <asp:TextBox ID="txtDescription" runat="server" />
    <br /><br />

    <asp:Button ID="btnAdd" runat="server" Text="Add product" OnClick="btnAdd_Click" />
    <br /><br />

    <asp:Label ID="lblMsg" runat="server" ForeColor="Green" />
    <hr />

    <h3>All products</h3>

    <asp:GridView ID="gvProducts" runat="server"
        AutoGenerateColumns="true"
        BorderWidth="1"
        CellPadding="6">
    </asp:GridView>

</asp:Content>
