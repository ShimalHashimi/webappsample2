<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="FirstWebApplication.loginpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--======================  Login-section  ======================-->
    <div class="login-section">
        <div class="login-img"><img src="Images/profile-img.png" alt=""></div>
        <div class="login-box"> 
            <h2>Login</h2>
            <form id="login-form">
                <div class="input-group">
                    <label for="username">Username</label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                <div class="input-group">
                    <label for="password">Password</label>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="submitLogin" runat="server" Text="LogIn" Class="btn btn-outline-dark btn-lg button" OnClick="submitLogin_Click" />
                <p>If you don't have account, <a href="registerpage.aspx">Register here</a></p>
            </form>
        </div>
    </div>
</asp:Content>
