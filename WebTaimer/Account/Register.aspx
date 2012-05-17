<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/NoLogin.master" AutoEventWireup="true"
    CodeBehind="Register.aspx.cs" Inherits="WebTaimer.Account.Register" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style>
        p.campo {
            width: 360px;
        }
    
        #RegisterForm 
        {
            width: 350px;
            margin: 0 auto;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

<h2> CREAR UNA NUEVA CUENTA</h2>
    <p> Use el formulario siguiente para crear una nueva cuenta.</p>
    <div ID:"contenido_completo" style="margin-left: 228px">
        <br />
<asp:ValidationSummary ID="ValSumReg" CssClass="failureNotification" HeaderText="Se han producido los siguientes errores:" runat="server" ValidationGroup="RegisterUserValidationGroup"/>

        
<div class="RegisterForm">
    <p class="campo">
        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nombre de usuario:</asp:Label>
        <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                CssClass="failureNotification" ErrorMessage="El nombre de usuario es obligatorio." ToolTip="El nombre de usuario es obligatorio." 
                ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
    </p>
    <p class="campo">
        <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">Correo electrónico:</asp:Label>
        <asp:TextBox ID="Email" runat="server" CssClass="textEntry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" 
                CssClass="failureNotification" ErrorMessage="El correo electrónico es obligatorio." ToolTip="El correo electrónico es obligatorio." 
                ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="emailValidation" ControlToValidate="Email" ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$" 
                ValidationGroup="RegisterUserValidationGroup" runat="server" ErrorMessage="e-Mail no valido" CssClass="failureNotification"
                ToolTip="e-Mail no valido">*</asp:RegularExpressionValidator>
        <asp:CustomValidator ID="EmailRepe" runat="server" ValidationGroup="RegisterUserValidationGroup" ControlToValidate="Email" 
                ErrorMessage="El e-Mail está repetido" CssClass="failureNotification" ToolTip="El e-Mail está repetido">*</asp:CustomValidator>
    </p>
    <p class="campo">
        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
        <br />
        <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                CssClass="failureNotification" ErrorMessage="La contraseña es obligatoria." ToolTip="La contraseña es obligatoria." 
        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator CssClass="failureNotification" ControlToValidate="Password" ID="PassValidation" runat="server" 
        ValidationExpression="^[a-zA-Z0-9]{6,15}$" ErrorMessage="Error la contraseña tiene que tener entre 6 y 15 carácteres" ValidationGroup="RegisterUserValidationGroup">*</asp:RegularExpressionValidator>
    </p>
    <p class="campo">
        <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirmar contraseña:</asp:Label>
        <asp:TextBox ID="ConfirmPassword" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ControlToValidate="ConfirmPassword" CssClass="failureNotification" Display="Dynamic" 
                ErrorMessage="Confirmar contraseña es obligatorio." ID="ConfirmPasswordRequired" runat="server" 
                ToolTip="Confirmar contraseña es obligatorio." ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" 
                CssClass="failureNotification" Display="Dynamic" ErrorMessage="Contraseña y Confirmar contraseña deben coincidir."
                ValidationGroup="RegisterUserValidationGroup">*</asp:CompareValidator>
    </p>
    <p class="campo">
        <asp:Label ID="DniLabel" runat="server" AssociatedControlID="DNI">DNI:</asp:Label>
        <br />
        <asp:TextBox ID="DNI" runat="server" CssClass="textEntry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="DniRequired" runat="server" ControlToValidate="DNI" 
                CssClass="failureNotification" ErrorMessage="El DNI es obligatorio." ToolTip="El DNI es obligatorio." 
                ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="DNIValidation" ControlToValidate="DNI" ValidationExpression="\d{8}([A-Z]|[a-z])" 
                ValidationGroup="RegisterUserValidationGroup" runat="server" ErrorMessage="DNI no valido" CssClass="failureNotification"
                ToolTip="DNI no valido">*</asp:RegularExpressionValidator>
        <asp:CustomValidator ID="DNIRepe" runat="server" ControlToValidate="DNI" ValidationGroup="RegisterUserValidationGroup" CssClass="failureNotification" 
                ToolTip="El DNI está repetido" ErrorMessage="El DNI está repetido">*</asp:CustomValidator>
    </p>
    <p class="campo">
        <asp:Label ID="TitulacionLabel" runat="server" AssociatedControlID="Titulacion">Titulación:</asp:Label>
        <br />
        <asp:TextBox ID="Titulacion" runat="server" CssClass="textEntry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="TitulacionRequired" runat="server" ControlToValidate="Titulacion" 
                CssClass="failureNotification" ErrorMessage="La titulación es obligatoria." ToolTip="La titulación es obligatoria." 
                ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
    </p>
    <p class="campo">
        <asp:Label ID="CursoLabel" runat="server" AssociatedControlID="Curso">Curso:</asp:Label>
        <br />
        <asp:DropDownList ID="Curso" runat="server" CssClass="textEntry" style="width: 320px">
            <asp:ListItem Value="1">Primero</asp:ListItem>
            <asp:ListItem Value="2">Segundo</asp:ListItem>
            <asp:ListItem Value="3">Tercero</asp:ListItem>
            <asp:ListItem Value="4">Cuarto</asp:ListItem>
            <asp:ListItem Value="5">Quinto</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="CursoRequired" runat="server" ControlToValidate="Curso" 
                CssClass="failureNotification" ErrorMessage="El curso es obligatorio." ToolTip="El curso es obligatorio." 
                ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
    </p>

    <asp:Button ID="btReg" runat="server" onclick="crearUsuario_Click" 
        Text="Registrate" ValidationGroup="RegisterUserValidationGroup"/>

    <br />
    <br />

</div>
</div>
</asp:Content>
