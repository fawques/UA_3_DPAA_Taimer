<%@ Page Title="Ver perfil" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="VerPerfil.aspx.cs" Inherits="WebTaimer.TabPerfil.VerPerfil" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Ver perfil
    </h2>

    <p></p>

    <!-- CAPA DEL AVATAR ----------------------------------------------------------------------------------------->

    <style>
        #divAvatar{
            width:100px;
            height:135px;
        }
    </style>

    <div id="divAvatar" style="float: left; margin-left: 50px">
        <asp:Image ID="imagenAvatar" runat="server" Height="100px" Width="100px" 
                ImageUrl="~/Images/avatar.png"/>
                <br />
        <asp:Button ID="botEditarPerfil" runat="server" Text="Editar perfil"
                style="margin-top: 10px; width:100px; height:25px;"
                    onclick="botEditarPerfil_Click" />
    </div>

    <!-- HUECO ENTRE AVATAR Y DATOS ------------------------------------------------------------------------------->
    
    <style>
    #divDatos
    {
        width:700px;
        height:300px;
    }
    </style>

    <div id="divDatos" style="float: left; margin-left: 20px">
        <asp:Label ID="labelNombreUsuario" runat="server" Text="[ Nombre Usuario ]" 
            Font-Bold="True" Font-Size="Large"></asp:Label>
        <br />
        <br />
        <asp:Label ID="labelTitulacion" runat="server" Font-Size="Medium" 
            Text="[ Titulación ]"></asp:Label>
        <br />
        <br />
        Curso:
        <asp:Label ID="labelCurso" runat="server" Text="[ Curso ]"></asp:Label>
        <br />
        <br />
        DNI:
        <asp:Label ID="labelDNI" runat="server" Text="[ DNI ]"></asp:Label>
        <br />
        <br />
        E-mail:
        <asp:Label ID="labelEmail" runat="server" Text="[ Correo electrónico ]"></asp:Label>
        <br />
        <br />
        <asp:Label ID="labelFrasePersonal" runat="server" Font-Italic="True" 
            Text="[ ¿Frase personal? ]"></asp:Label>
    </div>
    
            <p>
        
                <br />
                
    </p>


</asp:Content>