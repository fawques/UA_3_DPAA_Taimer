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
    <p>
        Si deseas cambiar tu dirección de correo electrónico,  <a href="../Account/ChangeEmail.aspx"
            title="Cambiar contraseña">haz clic aquí</a>.
    </p>

    <div class="accountInfo" style="float: left; margin-left: 51px; width:384px">
                        <fieldset class="register" style="width: 340px; height:190px">
                            <legend>Datos principales</legend>
                            <p style="width:333px">
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nombre de usuario:</asp:Label>
                                <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                                     CssClass="failureNotification" ErrorMessage="El nombre de usuario es obligatorio." ToolTip="El nombre de usuario es obligatorio." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p style="width: 333px">
                                <asp:Label ID="TitulacionLabel" runat="server" AssociatedControlID="Titulacion">Titulación:</asp:Label>
                                <asp:TextBox ID="Titulacion" runat="server" CssClass="textEntry"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="TitulacionRequired" runat="server" ControlToValidate="Titulacion" 
                                     CssClass="failureNotification" ErrorMessage="La titulación es obligatoria." ToolTip="La titulación es obligatoria." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p style="width: 333px">
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
                    </div>

                        <div class="datosAdicionales" style="float: left; margin-left: 51px; width:384px">
                        <fieldset class="fieldDatosAdicionales" style="width: 340px; height:190px">
                            <legend>Datos adicionales</legend>

                            <div style="width:150px; margin-left:8px; float:left">
                                <asp:Label ID="labelAvatar" runat="server">Imagen de perfil:</asp:Label>
                                <br />
                                <asp:Button ID="botonCargarDeArchivo" runat="server" Text="Cargar desde archivo" 
                                    Width="150px" style="margin-top:15px" />
                                <br />
                                <asp:Button ID="botonCargarDeURL" runat="server" Text="Cargar desde URL" 
                                    Width="150px" style="margin-top:15px" />
                                <br />
                            </div>

                            <div style="width:163px; height:110px; margin-left:10px; float:left">
                            <asp:Image ID="imagenAvatar" runat="server" ImageUrl="~/Images/avatar.png" />
                            </div>

                             <p style="width: 333px">
                                 <br />
                                <asp:Label ID="labelFrasePersonal" runat="server">Frase personal:</asp:Label>
                                <asp:TextBox ID="textboxFrasePersonal" runat="server" CssClass="textEntry"></asp:TextBox>
                            </p>
                        </fieldset>
                                            </div>
                        <p class="submitButton">
                            <asp:Button ID="botonModificarDatos" runat="server" CommandName="MoveNext" Text="Modificar datos" style="width:130px; height:30px" />
                            <asp:Button ID="botonRechazarCambios" runat="server" Text="Rechazar cambios" style="margin-left:5px; width:130px; height:30px" />
                        </p>

</asp:Content>