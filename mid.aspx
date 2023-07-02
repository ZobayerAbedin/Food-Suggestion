<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="mid.aspx.cs" Inherits="Food_Suggestion.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="design/mid.css" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
     <form id="Form1" runat = "server">
        <div class="container">
            <asp:Button class = "btm" ID = "addFood" runat="server" Text="Add food" OnClick="addFoodButtonClick" />
            <asp:Button class = "btm" ID = "getSuggestion" runat="server" Text="Get Suggestion" OnClick="getSuggestionButtonClick" />
        </div>
    </form>
</asp:Content>
