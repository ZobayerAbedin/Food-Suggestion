<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="addFood.aspx.cs" Inherits="Food_Suggestion.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="design/addFood.css" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
        <form id="Form1" runat = "server">
        <div class="container">
           
            <asp:TextBox ID="txtFood" runat="server" CssClass="addItemTextBox" MaxLength="50" Placeholder="Enter food name"></asp:TextBox>
            <asp:Button class = "btm" ID = "addItem" runat="server" Text="Add item" OnClick="addItemButtonClick" />
        </div>
    </form>
</asp:Content>
