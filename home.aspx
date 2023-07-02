<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Food_Suggestion.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="design/index.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
	<div id="main">
		<h2>Welcome to our website</h2>
		<p>Already have an account? <a href="login.aspx">Sign in</a></p>
		<p>New user? <a href="signUp.aspx">Sign up</a></p>
	</div>
</asp:Content>
