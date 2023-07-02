<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Food_Suggestion.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="design/login.css" rel="stylesheet" />
    <meta charset="UTF-8">
    <title>Log-In Page</title>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
     <form id="Form1" runat = "server">
        <div class="container">
            <h2>Log In</h2>

            <label for="txtName"><b>Username</b></label>
            <asp:TextBox ID="txtName" runat="server" CssClass="signUpTextBox" MaxLength="50" Placeholder="Enter your name"></asp:TextBox>
            <%--<asp:RequiredFieldValidator ID = "reqName" runat = "server" ControlToValidate="txtName" ErrorMessage="Enter Name!"></asp:RequiredFieldValidator>--%>

            <label for="password"><b>Password</b></label>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="signUpTextBox" MaxLength="50" Placeholder="Enter password"></asp:TextBox>
            <%--<asp:RequiredFieldValidator ID = "RequiredFieldValidator2" runat = "server" ControlToValidate="txtName" ErrorMessage="lkj"></asp:RequiredFieldValidator>--%>

            <asp:Button class = "btm" ID = "logInButton" runat="server" Text="Log In" OnClick="logInButtonClick" />
            <asp:Button class = "btm1" ID = "cancelButton" runat="server" Text="Cancel" OnClick="cancelButtonClick" />
            <span class="psw"> <a href="#">Forgot password?</a></span>
        </div>
       
    </form>
</asp:Content>
