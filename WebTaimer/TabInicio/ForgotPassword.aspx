<%@ Page Title="Recuperar cuenta" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="ForgotPassword.aspx.cs" Inherits="WebTaimer.Account.ForgotPassword" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Recuperar cuenta
    </h2>
    <p>
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" 
            
            style="z-index: 1; left: 0px; top: 0px; position: relative; height: 105px; width: 344px" 
            BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" 
            Font-Names="Verdana" Font-Size="10pt">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:PasswordRecovery>
    </p>
</asp:Content>
