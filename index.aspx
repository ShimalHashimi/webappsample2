<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FirstWebApplication.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!--======================  heading-section  ======================-->
    <div class="heading">
        <h1 class="hidden-h1">Revolutionize Your Business Operations with HSMTechie's Advanced POS System!</h1>
        <div class="heading-section">
            <div class="heading-img"><img src="Images/profile-img.png" alt=""></div>
            <div class="heading-text">
    
                <h1>Revolutionize Your Business Operations with HSMTechie's Advanced POS System!</h1>
                <p>Transform your business with our cutting-edge Point of Sale (POS) system designed to elevate your digital 
                    experience. Streamline your operations, enhance customer satisfaction, and drive growth with our advanced 
                    technology. Join us today and unlock the full potential of your business!
                </p>

                <p><b>Log In to Get Started</b></p>
                <a href="loginpage.aspx" class="btn btn-outline-dark btn-lg" id="showLoginBtn">
                    <i class="fa-solid fa-right-to-bracket"></i> LOGIN
                </a>
            </div>
        </div>
    </div>
</asp:Content>
