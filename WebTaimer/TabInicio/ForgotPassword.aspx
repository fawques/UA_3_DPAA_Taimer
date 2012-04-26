<%@ Page Title="Recuperar cuenta" Language="C#" MasterPageFile="~/NoLogin.master" AutoEventWireup="true"
    CodeBehind="ForgotPassword.aspx.cs" Inherits="WebTaimer.TabInicio.ForgotPassword" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Recuperar cuenta
    </h2>

    <p>
        Escribe tu nombre de usuario o tu e-mail y te enviaremos la contraseña a tu correo electrónico.
    </p>

    <p>
        Nombre de usuario o e-mail:<br />
        <asp:TextBox ID="UserName" runat="server" Width="320px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" CssClass="failureNotification"
            ControlToValidate="UserName" 
            ErrorMessage="El nombre de usuario es obligatorio." 
            ToolTip="El nombre de usuario es obligatorio." 
            ValidationGroup="PasswordRecovery">*
        </asp:RequiredFieldValidator>
    </p>

    <p>
    <asp:Button ID="SubmitButton" runat="server" CommandName="Submit" Text="Enviar" ValidationGroup="PasswordRecovery" />
    </p>
</asp:Content>
