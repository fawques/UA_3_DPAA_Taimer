<%@ Page Title="Actividades personales" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Actividades.aspx.cs" Inherits="WebTaimer.TabActividades.Actividades" %>

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

        <div id="divPanelCentral" 
        style="width:200px; float: left; margin-left:15px; height: 339px;">
            <fieldset class="act" style="width: 160px; height: 294px">
            <legend>Actividades</legend>
                        <asp:TextBox ID="TextBox1" runat="server">Filtrar...</asp:TextBox>
                <br />
                <br />
                        <asp:ListBox ID="ListBox1" runat="server" Height="223px" Width="160px">
                            <asp:ListItem>Actividad 1</asp:ListItem>
                            <asp:ListItem>Actividad 2</asp:ListItem>
                            <asp:ListItem>Actividad 3</asp:ListItem>
                        </asp:ListBox>
                    </fieldset>
        </div>

        <div id="divPanelContenido" 
        style="width:686px; float: left; margin-left:5px">
        <fieldset class="infoAsig" style="width: 686px; height:275px">
            <legend>Información de la actividad personal</legend>


                            <div style="float:left; width:467px; height: 226px;">
                                    <asp:Label ID="labelNombreActividad" runat="server" Font-Bold="True" Font-Size="X-Large" 
                                        Text="[ Nombre de la actividad ]"></asp:Label>
                                    <br />
                                    <br />
                                    <asp:Label ID="labelDescripcionActividad" runat="server" Font-Size="Medium" 
                                        Text="[ Descripción de la actividad ]"></asp:Label>
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <asp:Button ID="botonBorrarActividad" runat="server" Text="Borrar actividad" style="width:120px" />
                                    <asp:Button ID="botonEditarActividad" runat="server" Text="Editar actividad" style="width:120px; margin-left:5px"/>
                                </div>
                                <div style="float:left">
                                    <asp:Label ID="labelTurnos" runat="server" Font-Bold="True" Text="Turnos" align="center"></asp:Label>
                                    <br />
                                    <asp:ListBox ID="listaTurnos" runat="server" Height="210px" Width="190px">
                                        <asp:ListItem Selected="True">Miércoles, de 09:00 a 11:00</asp:ListItem>
                                        <asp:ListItem>Jueves, de 10:30 a 12:30</asp:ListItem>
                                        <asp:ListItem>Jueves, de 16:30 a 16:30</asp:ListItem>
                                    </asp:ListBox>
                                </div>
                    </fieldset>
</asp:Content>
