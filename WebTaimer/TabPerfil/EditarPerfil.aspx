<%@ Page Title="Editar perfil" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="EditarPerfil.aspx.cs" Inherits="WebTaimer.TabPerfil.EditarPerfil" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Editar perfil
    </h2>
    <p>
        Cambia la información de tu cuenta usando el siguiente formulario.<p>
        Si deseas cambiar la contraseña,  <a href="../Account/ChangePassword.aspx"
            title="Cambiar contraseña">haz clic aquí</a>.
    </p>
    <div class="accountInfo">
                        <fieldset class="register">
                            <legend>Información de cuenta</legend>
                            <p>
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nombre de usuario:</asp:Label>
                                <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                                     CssClass="failureNotification" ErrorMessage="El nombre de usuario es obligatorio." ToolTip="El nombre de usuario es obligatorio." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">Correo electrónico:</asp:Label>
                                <asp:TextBox ID="Email" runat="server" CssClass="textEntry"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" 
                                     CssClass="failureNotification" ErrorMessage="El correo electrónico es obligatorio." ToolTip="El correo electrónico es obligatorio." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="DniLabel" runat="server" AssociatedControlID="DNI">DNI:</asp:Label>
                                <asp:TextBox ID="DNI" runat="server" CssClass="textEntry"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="DniRequired" runat="server" ControlToValidate="DNI" 
                                     CssClass="failureNotification" ErrorMessage="El DNI es obligatorio." ToolTip="El DNI es obligatorio." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="TitulacionLabel" runat="server" AssociatedControlID="Titulacion">Titulación:</asp:Label>
                                <asp:TextBox ID="Titulacion" runat="server" CssClass="textEntry"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="TitulacionRequired" runat="server" ControlToValidate="Titulacion" 
                                     CssClass="failureNotification" ErrorMessage="La titulación es obligatoria." ToolTip="La titulación es obligatoria." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="CursoLabel" runat="server" AssociatedControlID="Curso">Curso:</asp:Label>
                                <asp:DropDownList ID="Curso" runat="server" CssClass="textEntry" style="width: 320px">
                                    <asp:ListItem>Primero</asp:ListItem>
                                    <asp:ListItem>Segundo</asp:ListItem>
                                    <asp:ListItem>Tercero</asp:ListItem>
                                    <asp:ListItem>Cuarto</asp:ListItem>
                                    <asp:ListItem>Quinto</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="CursoRequired" runat="server" ControlToValidate="Curso" 
                                     CssClass="failureNotification" ErrorMessage="El curso es obligatorio." ToolTip="El curso es obligatorio." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                        </fieldset>
                        <p class="submitButton">
                            <asp:Button ID="CreateUserButton" runat="server" CommandName="MoveNext" Text="Modificar datos" 
                                 ValidationGroup="RegisterUserValidationGroup"/>
                        </p>
                    </div>
</asp:Content>