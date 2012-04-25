<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="ConLogin.aspx.cs" Inherits="WebTaimer.TabInicio.ConLogin" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            z-index: 1;
            left: 100px;
            top: 0px;
            position: relative;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2 style="margin-bottom: 40px;">
        BIENVENIDO, [NOMBRE USUARIO]
    </h2>

    <asp:Button ID="botonHorariosPropios" runat="server" Font-Size="XX-Large" 
    Height="100px" Text="Horarios propios" Width="310px" 
        onclick="botonHorariosPropios_Click" CssClass="style1" />

    <asp:Button ID="botonMatricula" runat="server" Font-Size="XX-Large"
    style="z-index: 1; left: 200px; top: 0px; position: relative" 
    Height="100px" Text="Asignaturas" Width="310px" onclick="botonMatricula_Click" />

    <asp:Button ID="botonHorariosPublicos" runat="server" Font-Size="XX-Large"
    style="z-index: 1; left: 100px; top: 30px; position: relative" 
    Height="100px" Text="Horarios públicos" Width="310px" 
        onclick="botonHorariosPublicos_Click" />

    <asp:Button ID="botonMensajes" runat="server" Font-Size="XX-Large"
    style="z-index: 1; left: 200px; top: 30px; position: relative" 
    Height="100px" Text="Mensajes" Width="310px" onclick="botonMensajes_Click" />

    <p style="margin-top: 75px;"><a href="SinLogin.aspx" title="Ver inicio sin Login">(Clic aquí para ver la página de inicio sin login)</a></p>
    </asp:Content>
    
