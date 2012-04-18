<%@ Page Title="Ver perfil" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="VerPerfil.aspx.cs" Inherits="WebTaimer.TabPerfil.VerPerfil" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Ver perfil
    </h2>

    <p>
        &nbsp;<asp:Panel ID="panelInfo" runat="server" 
        
        
        
        style="z-index: 1; left: 170px; top: 0px; position: relative; height: 136px; width: 746px">
        <asp:Label ID="labelNombreUsuario" runat="server" Text="[ Nombre Usuario ]" 
            Font-Bold="True" Font-Size="Large"></asp:Label>
        <br />
        <br />
        <asp:Label ID="labelTitulacion" runat="server" Font-Size="Medium" 
            Text="[ Titulación ]"></asp:Label>
        <br />
        <br />
        <asp:Label ID="labelCurso" runat="server" Text="[ Curso ]"></asp:Label>
        <br />
        <br />
        <asp:Label ID="labelFrasePersonal" runat="server" Font-Italic="True" 
            Text="[ ¿Frase personal? ]"></asp:Label>
    </asp:Panel>
    </p>
            <p>
        <asp:Image ID="imagenAvatar" runat="server" Height="100px" Width="100px" 
            style="z-index: 1; left: 50px; top: -146px; position: relative" 
            ImageUrl="~/Images/avatar.png"/>
                <br />
                <asp:Button ID="botEditarPerfil" runat="server" Text="Editar perfil" 
                    style="z-index: 1; left: 50px; top: -140px; height: 27px; width: 100px; position: relative" 
                    onclick="botEditarPerfil_Click" />
    </p>


</asp:Content>