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

    <!-- CAPA INFORMACIÓN -------------------------------------------------------------------------------------->
        <style>
        #divPanel{
            width:250px;
            height:200px;
            background-color:transparent;
        }
    </style>

    <div id="divPanel" style="float: left; margin-left: 0px">
        <fieldset class="register" style="width: 200px">
            <legend>Información</legend>
            <p style="width:200px">
                <asp:Image ID="imagenAvatar" runat="server" ImageUrl="~/Images/default.jpg" />
                <asp:Label ID="nombrePrincipalUser" runat="server" style="margin-left: 5px" 
                    Text="[ 1er nom User ]" Font-Size="Large"></asp:Label>
            </p>

            <p style="width:200px">
                <asp:Image ID="imagenMensaje" runat="server" ImageUrl="~/Images/mensaje.gif" />
     
                <asp:Label ID="labelMensajesSinLeer" runat="server" 
                    Text="Tienes 0 mensaje(s) sin leer."></asp:Label>
            </p>

            <p style="width:200px">
            
                <asp:Image ID="imagenCalendario" runat="server" 
                    ImageUrl="~/Images/calendario.png" />
            
                Tienes 2 actividades hoy:<br />
                <asp:BulletedList ID="listaActPer" runat="server" style="width:200px" align="left">
                    <asp:ListItem>Meter un huevo al microondas</asp:ListItem>
                    <asp:ListItem>Hackear la web de la UA</asp:ListItem>
                </asp:BulletedList>
                </p>

                
     
                &nbsp;</fieldset>
    </div>

    <!-- LOS BOTONES

    <asp:Button ID="botonHorariosPropios" runat="server" Font-Size="XX-Large" 
    Height="100px" Text="Horarios propios" Width="310px" 
        onclick="botonHorariosPropios_Click" />

    <asp:Button ID="botonMatricula" runat="server" Font-Size="XX-Large"
    Height="100px" Text="Asignaturas" Width="310px" onclick="botonMatricula_Click" />

    <asp:Button ID="botonHorariosPublicos" runat="server" Font-Size="XX-Large"
    Height="100px" Text="Horarios públicos" Width="310px" 
        onclick="botonHorariosPublicos_Click" />

    <asp:Button ID="botonMensajes" runat="server" Font-Size="XX-Large"
    Height="100px" Text="Mensajes" Width="310px" onclick="botonMensajes_Click" />

    -->

                

    <p style="margin-top: 75px;"><a href="SinLogin.aspx" title="Ver inicio sin Login">(Clic aquí para ver la página de inicio sin login)</a></p>
    </asp:Content>
    
