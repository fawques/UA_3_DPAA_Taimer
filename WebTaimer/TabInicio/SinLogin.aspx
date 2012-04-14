<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="SinLogin.aspx.cs" Inherits="WebTaimer._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Bienvenido.</h2>
    <p>
        Inicia sesión para acceder a tus horarios, peticiones, etc.<asp:Image 
            ID="taimerLogo" runat="server" ImageAlign="Right" 
            ImageUrl="~/Images/taimerLogo.png" />
        <br />
        <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:Login>
    </p>
    <p>
        ¿No tienes una cuenta? <a href="../Account/Register.aspx" title="Registrarse">Regístrate</a>.
    </p>
    <p>
        ¿Olvidaste la contraseña? <a href="ForgotPassword.aspx"
            title="Recuperar cuenta">Haz clic aquí</a> para recuperar tu cuenta.
    </p>
    <p>
        Si aún no has descargado la aplicación Taimer para Windows, puedes hacerlo <a href=""
            title="Descargar Taimer para Windows">haciendo clic aquí</a>.
    </p>
</asp:Content>
