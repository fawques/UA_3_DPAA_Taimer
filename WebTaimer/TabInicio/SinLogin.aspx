<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/NoLogin.master" AutoEventWireup="true"
    CodeBehind="SinLogin.aspx.cs" Inherits="WebTaimer._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Bienvenido a Taimer.</h2>
    <p>
        Taimer te permite crear y publicar tus horarios fácilmente y sin esfuerzo.<br />
        <br />
        (Pequeña explicación...)<br />
        <br />
        <br />
        <br />
        <br />
    </p>
    <p>
        Si aún no tienes una cuenta, no esperes más. <a href="../Account/Register.aspx" title="Registrarse">Regístrate</a>.
    </p>
    <p>
        ¿Olvidaste la contraseña? <a href="ForgotPassword.aspx"
            title="Recuperar cuenta">Haz clic aquí</a> para recuperar tu cuenta.
    </p>
    <p>
        Si aún no has descargado la aplicación Taimer para Windows, puedes hacerlo <a href=""
            title="Descargar Taimer para Windows">haciendo clic aquí</a>.
    </p>
        <p>
        <br />
        <br />
    <a href="ConLogin.aspx"
            title="Ver inicio con Login">(Clic aquí para ver la página de inicio con login)</a>
    </p>
</asp:Content>
