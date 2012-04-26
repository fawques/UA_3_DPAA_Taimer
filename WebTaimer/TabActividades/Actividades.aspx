<%@ Page Title="Actividades personales" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Actividades.aspx.cs" Inherits="WebTaimer.TabActividades.Actividades" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Actividades personales
    </h2>
    <style>
        #divPanelIzquierdo{
            background-color:transparent;
        }
    </style>

        <style>
        #divPanelContenido{
            background-color:transparent;
        }
            #Button1
            {
                width: 57px;
            }
            .comentario
            {
                width: 633px;
            }
            </style>

        <div id="divPanelIzquierdo" style="width:160px; float: left">
         <fieldset class="filtro" style="width: 130px; height:220px">
            <legend>Filtro</legend>
            Mostrar...<br />
             <asp:RadioButtonList ID="radioFiltro" runat="server">
                 <asp:ListItem>Todas</asp:ListItem>
                 <asp:ListItem>Próximos 7 días</asp:ListItem>
                 <asp:ListItem Selected="True">Fecha específica</asp:ListItem>
             </asp:RadioButtonList>
             <br />
             Desde: 
                        <asp:DropDownList ID="listaDesde" runat="server" style="width:85px">
                            <asp:ListItem>28/04/12</asp:ListItem>
             </asp:DropDownList>
                        <br />
             Hasta:&nbsp;
             <asp:DropDownList ID="listaHasta" runat="server" style="width:85px">
                 <asp:ListItem>30/04/12</asp:ListItem>
             </asp:DropDownList>
                        <br />
                        &nbsp;<asp:Button ID="botFiltrar" runat="server" Text="Filtrar" style="margin-left:68px; margin-top:5px"/>
                    </fieldset>
        </div>

        <div id="divPanelCentral" style="width:200px; float: left; margin-left:15px">
            <fieldset class="act" style="width: 160px; height: 220px">
            <legend>Actividades</legend>
                        <asp:ListBox ID="ListBox1" runat="server" Height="180px" Width="160px">
                            <asp:ListItem>Actividad 1</asp:ListItem>
                            <asp:ListItem>Actividad 2</asp:ListItem>
                            <asp:ListItem>Actividad 3</asp:ListItem>
                        </asp:ListBox>
                    </fieldset>
        </div>

        <div id="divPanelContenido" style="width:535px; float: left; margin-left:5px">
        <fieldset class="infoAsig" style="width: 507px; height:220px">
            <legend>Información de la actividad personal</legend>


                            <div style="float:left; width:314px">
                                    <asp:Label ID="labelNombreActividad" runat="server" Font-Bold="True" Font-Size="X-Large" 
                                        Text="[ Nombre de la actividad ]"></asp:Label>
                                    <br />
                                    <br />
                                    <asp:Label ID="labelDescripcionActividad" runat="server" Font-Size="Medium" 
                                        Text="[ Descripción de la actividad ]"></asp:Label>
                                </div>
                                <div style="float:left">
                                    <asp:Label ID="labelTurnos" runat="server" Font-Bold="True" Text="Turnos" align="center"></asp:Label>
                                    <br />
                                    <asp:ListBox ID="listaTurnos" runat="server" Height="167px" Width="190px">
                                        <asp:ListItem Selected="True">Miércoles, de 09:00 a 11:00</asp:ListItem>
                                        <asp:ListItem>Jueves, de 10:30 a 12:30</asp:ListItem>
                                        <asp:ListItem>Jueves, de 16:30 a 16:30</asp:ListItem>
                                    </asp:ListBox>
                                </div>
                    </fieldset>
</asp:Content>
