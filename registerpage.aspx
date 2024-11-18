<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registerpage.aspx.cs" Inherits="FirstWebApplication.registerpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--======================  register-section  ======================-->
    <div class="login-section">
        <div class="login-img"><img src="Images/profile-img.png" alt=""></div>
        <div class="login-box">
            <h2>Register</h2>
            <form id="register-form">
                <div id="signUpMessage" class="messageDiv" style="display: none;"></div>
                <div class="input-group">
                    <label for="email">Email</label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                <div class="input-group">
                    <label for="username">Username</label>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </div>
                <div class="input-group">
                    <label for="password">Password</label>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="submitSignUp" runat="server" Text="Submit" Class="btn btn-outline-dark btn-lg button" OnClick="submitSignUp_Click" />
                <p>Already have an account? <a href="loginpage.aspx">Login here</a></p>
            </form>
        </div>
    </div>
</asp:Content>
