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
        <asp:Label ID="lbBienvenida" runat="server" Text="Label"></asp:Label>
    </h2>

    <!-- CAPA INFORMACIÓN -------------------------------------------------------------------------------------->
    <style>
        #divPanel{
            width:250px;
            background-color:transparent;
        }
    </style>

    <div id="divPanel" style="float: left; margin-left: 0px; margin-top:-31px">
        <fieldset class="info" style="width: 200px; height:300px">
            <legend>Información</legend>

            <div id="divCajaAvatarNombre" style="width:200px; height:48px">

            <div style="width:48px; float: left">
                <asp:Image ID="imagenAvatar" runat="server" ImageUrl="~/Images/default.jpg" />
            </div>

            <div id="divNombre" style="float: left; width: 152px; height: 48px">
                    <asp:Label ID="nombrePrincipalUser" runat="server" style="margin-left: 5px" 
                    Text="[ Nom User ]" Font-Size="Large"></asp:Label>
            </div>

            </div>

            <hr style="width: 200px; height: -12px;" />

            <div style="width:200px">
            </div>

            <div style="width:200px">
                <asp:Image ID="imagenMensaje" runat="server" ImageUrl="~/Images/mensaje.gif" />
     
                <asp:Label ID="labelMensajesSinLeer" runat="server" 
                    Text="Tienes 0 mensaje(s) sin leer."></asp:Label>
            </div>

            <div style="width:200px">
            
                <asp:Image ID="imagenCalendario" runat="server" 
                    ImageUrl="~/Images/calendario.png" />
            
                Tienes 2 actividades hoy:<br />
                <asp:BulletedList ID="listaActPer" runat="server" 
                    style="width:200px; position:relative; left:-25px; top: 0px;">
                    <asp:ListItem>Ir al médico</asp:ListItem>
                    <asp:ListItem>Revisión del coche</asp:ListItem>
                </asp:BulletedList>
             </div>

                <br />
     
                </fieldset>
    </div>



    <!-- PANEL DERECHO (CONTENIDO) -------------------------------------------------------------->

    <style>
        #divContenido{
            width:670px;
            background-color:transparent;
        }
    </style>

        <div id="divContenido" style="margin-left: 230px">
    
        <asp:Button ID="botonHorariosPropios" runat="server" Font-Size="XX-Large" 
    Height="100px" Text="Horarios propios" Width="320px" 
        onclick="botonHorariosPropios_Click" />

    <asp:Button ID="botonMatricula" runat="server" Font-Size="XX-Large"
    Height="100px" Text="Asignaturas" Width="320px" onclick="botonMatricula_Click" style="margin-left: 5px"/>

    <asp:Button ID="botonHorariosPublicos" runat="server" Font-Size="XX-Large"
    Height="100px" Text="Horarios públicos" Width="320px" 
        onclick="botonHorariosPublicos_Click" style="margin-top: 5px"/>

    <asp:Button ID="botonMensajes" runat="server" Font-Size="XX-Large"
    Height="100px" Text="Mensajes" Width="320px" onclick="botonMensajes_Click" style="margin-left: 5px; margin-top: 5px"/>

    
    <asp:Button ID="botonActividadesPersonales" runat="server" Font-Size="XX-Large" Height="100px" Text="Actividades" Width="320px" style="margin-top: 5px"/>

    <asp:Button ID="botonPerfil" runat="server" Font-Size="XX-Large"
    Height="100px" Text="Mi perfil" Width="320px" 
                style="margin-left: 5px; margin-top: 5px"/>

    

    </div>


                

    <p style="margin-top: 75px;"><a href="SinLogin.aspx" title="Ver inicio sin Login">(Clic aquí para ver la página de inicio sin login)</a></p>
    </asp:Content>
    
