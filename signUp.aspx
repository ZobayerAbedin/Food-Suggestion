<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="Food_Suggestion.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="design/signUp.css" rel="stylesheet" />
    <meta charset="UTF-8">
    <title>Sign-Up Page</title>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
     <form id="Form1" runat = "server">
        <div class="container">
            <h2>Sign Up</h2>

            <label for="txtName"><b>Username</b></label>
            <asp:TextBox ID="txtName" runat="server" CssClass="signUpTextBox" MaxLength="50" Placeholder="Enter your name"></asp:TextBox>
            <%--<asp:RequiredFieldValidator ID = "reqName" runat = "server" ControlToValidate="txtName" ErrorMessage="Enter Name!"></asp:RequiredFieldValidator>--%>
            
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="signUpTextBox" MaxLength="50" Placeholder="Enter your email"></asp:TextBox>
            <%--<asp:RequiredFieldValidator ID = "RequiredFieldValidator1" runat = "server" ControlToValidate="txtEmail" ErrorMessage="Enter password!"></asp:RequiredFieldValidator>--%>

            <label for="password"><b>Password</b></label>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="signUpTextBox" MaxLength="50" Placeholder="Enter password"></asp:TextBox>
            <%--<asp:RequiredFieldValidator ID = "RequiredFieldValidator2" runat = "server" ControlToValidate="txtName" ErrorMessage="lkj"></asp:RequiredFieldValidator>--%>

            <label for="password"><b>Password</b></label>
            <asp:TextBox ID="txtPassC" TextMode="Password" runat="server" CssClass="signUpTextBox" MaxLength="50" Placeholder="confirm password"></asp:TextBox>
            <%--<asp:RequiredFieldValidator ID = "RequiredFieldValidator3" runat = "server" ControlToValidate="txtName" ErrorMessage="lkj"></asp:RequiredFieldValidator>--%>


           
            <asp:Button class = "btm" ID = "signUpButton" runat="server" Text="Sign Up" OnClick="signUpButtonClick" />
            <asp:Button class = "btm1" ID = "cancelButton" runat="server" Text="Cancel" OnClick="cancelButtonClick" />
        </div>
       
    </form>
</asp:Content>
