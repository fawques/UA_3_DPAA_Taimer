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

        <div id="divPanelIzquierdo" style="width:200px; float: left">
            <fieldset class="filtro" style="width: 160px; height:80px" runat="server" id="filtro">
                <legend>Filtro</legend>
                        <asp:TextBox ID="textboxFilter" runat="server" Width="160px"></asp:TextBox>
                        &nbsp;<asp:Button ID="botFiltrar" runat="server" Text="Filtrar" onclick="botFiltrar_Click"/>
            </fieldset>
            
            <fieldset class="asig" style="width: 160px; height: 440px" runat="server" id="asig">
                <legend>Actividades</legend>
                        <asp:ListBox ID="ListAct" runat="server" 
                        Height="412px" Width="160px" Autopostback="true"  OnSelectedIndexChanged="seleccionar">
                        </asp:ListBox>
           </fieldset>
        </div>

        <div id="divPanelContenido" style="width:686px; float: left; margin-left:5px">
            <fieldset class="infoAsig" style="width: 686px; height:275px" runat="server">
                <legend>Información de la actividad personal</legend>

                    <div style="float:left; width:330px; height: 226px;">
                        <asp:Label ID="labelNombreActividad" runat="server" Font-Bold="True" Font-Size="X-Large"
                            Text="[ Nombre de la actividad ]"></asp:Label>
                        <br />                        
                        <asp:Label ID="labelDescripcionActividad" runat="server" Font-Size="Medium" 
                            Text="[ Descripción de la actividad ]"></asp:Label>
                        <div id="optionButtons" runat="server" style="margin-top: 50px">
                            <asp:Button ID="botonBorrarActividad" runat="server" Text="Borrar actividad" 
                                style="width:120px" onclick="botonBorrarActividad_Click" />
                            <asp:Button ID="botonEditarActividad" runat="server" Text="Editar actividad" 
                                style="width:120px; margin-left:5px" onclick="botonEditarActividad_Click"/>
                            <asp:Button ID="botonConfirmar" runat="server" Text="Confirmar" visible=false
                                style="width:120px" onclick="botonConfirmar_Click" />                            
                            <asp:Button ID="botonCancelar" runat="server" Text="Cancelar" visible=false
                                style="width:120px; margin-left:5px" onclick="botonCancelar_Click"/>
                        </div>
                    </div>

                    <div style="float:right; width: 340px" id="divTurnos" runat="server">                                    

                        <asp:Label ID="labelTurnos" runat="server" Font-Bold="True" Text="Turnos" align="center" style="float: right"></asp:Label>                        
                        <br />
                        <asp:ListBox ID="listaTurnos" runat="server" Height="210px" Width="190px" style="float: right">                            
                        </asp:ListBox>
                    </div>
            </fieldset>
          </div>
</asp:Content>
