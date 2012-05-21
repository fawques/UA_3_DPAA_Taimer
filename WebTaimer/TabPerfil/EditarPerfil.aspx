<%@ Page Title="Editar perfil" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="EditarPerfil.aspx.cs" Inherits="WebTaimer.TabPerfil.EditarPerfil" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Editar perfil
    </h2>

    <div class="datosAdicionales" style="float: right; margin-left: 0px; margin-right: 50px; margin-top:-20px; width:384px">
        <fieldset class="fieldDatosAdicionales" style="width: 360px; height:245px">
            <legend>Datos adicionales</legend>
           
            <div style="width:260px; height:110px; margin-left:10px; float:left">
                <asp:Image ID="imagenAvatar" runat="server" Height="100px" Width="100px"/>

                <div style="width:100px; margin-right:40px; float: right">
                    <asp:Label ID="labelAvatar" runat="server">Imagen de perfil:</asp:Label>                    
                    <asp:FileUpload ID="cargarArchivo" runat="server" Text="Cargar desde archivo" 
                        Width="150px" style="margin-top:15px" />
                    <br />                  
                    
                </div>
            </div>          

             <div style="margin-left:10px; width: 333px; clear: both">                    
                <asp:Label ID="labelFrasePersonal" runat="server">Frase personal:</asp:Label>
                <asp:TextBox ID="FrasePersonal" runat="server" TextMode="MultiLine" Width="335px" Height="75px" CssClass="textEntry" style="resize:none"></asp:TextBox>
            </div>
        </fieldset>
        </div>

    <div class="accountInfo" style="margin-left: 25px; margin-top:-20px; width:384px">
        <style>
            .dataBox { width: 350px; }
        </style>
        <fieldset class="register" style="width: 350px; height:245px">
            <legend>Datos principales</legend>
            <p class="dataBox">
                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nombre:</asp:Label>
                <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                        CssClass="failureNotification" ErrorMessage="El nombre de usuario es obligatorio." ToolTip="El nombre de usuario es obligatorio." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <br />
            
            <p class="dataBox">
                <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="UserName">Correo electrónico:</asp:Label>
                <asp:TextBox ID="Email" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" 
                        CssClass="failureNotification" ErrorMessage="El e-mail es obligatorio." ToolTip="El e-mail es obligatorio." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="EmailValidation" ControlToValidate="Email" ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$" 
                        ValidationGroup="RegisterUserValidationGroup" runat="server" ErrorMessage="e-Mail no valido" CssClass="failureNotification"
                        ToolTip="e-Mail no valido">*</asp:RegularExpressionValidator>
            </p>
            <br />

            <p class="dataBox">
                <asp:Label ID="TitulacionLabel" runat="server" AssociatedControlID="Titulacion">Titulación:</asp:Label>
                <asp:TextBox ID="Titulacion" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="TitulacionRequired" runat="server" ControlToValidate="Titulacion" 
                        CssClass="failureNotification" ErrorMessage="La titulación es obligatoria." ToolTip="La titulación es obligatoria." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <br />

            <p class="dataBox">
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

    <div class="cambioPassword" style="margin-left: 25px; margin-top:-20px; width:384px">
        <fieldset class="register" style="width: 340px; height:200px">
            <legend>Contraseña</legend>
            <p style="width:333px">
                <asp:Label ID="labelPasswordAnterior" runat="server" AssociatedControlID="PasswordAnterior">Contraseña anterior:</asp:Label>
                <asp:TextBox ID="PasswordAnterior" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="PasswordAnterior" 
                    CssClass="failureNotification" ErrorMessage="La contraseña no es correcta." ToolTip="La contraseña no es correcta." 
                    ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>                                
            </p>
            <br />
            <p class="dataBox">
                <asp:Label ID="labelNuevoPassword" runat="server" AssociatedControlID="NuevoPassword">Nueva contraseña:</asp:Label>
                <asp:TextBox ID="NuevoPassword" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="NuevoPassRequiered" runat="server" ControlToValidate="NuevoPassword" 
                    CssClass="failureNotification" ErrorMessage="La contraseña es obligatoria." ToolTip="Introduzca nueva contraseña" 
                    ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator CssClass="failureNotification" ControlToValidate="NuevoPassword" ID="NuevoPassValidator" runat="server" 
                    ValidationExpression="^[a-zA-Z0-9]{6,15}$" ErrorMessage="Error la contraseña tiene que tener entre 6 y 15 carácteres." ToolTip="Error la contraseña tiene que tener entre 6 y 15 carácteres." ValidationGroup="RegisterUserValidationGroup">*</asp:RegularExpressionValidator>
            </p>
            <br />
                <p class="dataBox">
                <asp:Label ID="labelConfirmarNuevoPassword" runat="server" AssociatedControlID="UserName">Confirmar nueva contraseña:</asp:Label>
                <asp:TextBox ID="ConfirmarNuevoPassword" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ConfirmarNuevoPassRequiered" runat="server" ControlToValidate="ConfirmarNuevoPassword" 
                    CssClass="failureNotification" ErrorMessage="Las contraseñas no coinciden." ToolTip="Las contraseñas no coinciden." 
                    ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>                                
            </p>
        </fieldset>
    </div>

    <p class="submitButton" style="clear: both">
        <asp:Button ID="botonModificarDatos" runat="server" CommandName="MoveNext" 
            Text="Modificar datos" style="width:130px; height:30px" 
            onclick="botonModificarDatos_Click" />
        <asp:Button ID="botonCancelar" runat="server" Text="Cancelar" 
            style="margin-left:5px; width:130px; height:30px" 
            onclick="botonCancelar_Click" />
    </p>

</asp:Content>