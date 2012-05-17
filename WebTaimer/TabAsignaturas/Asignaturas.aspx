<%@ Page Title="Asignaturas" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Asignaturas.aspx.cs" Inherits="WebTaimer.TabAsignaturas.Asignaturas" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        #TextArea1
        {
            z-index: 1;
            left: 512px;
            top: 666px;
            position: absolute;
            height: 59px;
            width: 473px;
        }
        </style>
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
            .filledRatingStar
            {
                display:block;
                float:left;
                background-image:url('Images/gSelected.gif');
         
            }

            .savedRatingStar
            {
                display:block;
                float:left;
                background-image:url('Images/bSelected.gif');
                
            }

            .emptyRatingStar
            {
                display:block;
                float:left;
                background-image:url('Images/blank.gif');
                
            }
            .ratingStar
            {
               font-size: 0pt;
              
                width: 16px;
                height: 14px;
                margin: 0px;
                padding: 0px;
                cursor: pointer;
                display: block;
                background-repeat: no-repeat;
            }
            </style>
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <h2>
        Asignaturas</h2>
        <div id="divPanelIzquierdo" style="width:200px; float: left">
         <fieldset class="filtro" style="width: 160px; height:80px">
            <legend>Filtro</legend>
                        <asp:TextBox ID="textboxFilter" runat="server" Width="160px" placeholder="palabra clave"></asp:TextBox>
                        &nbsp;<asp:Button ID="botFiltrar" runat="server" Text="Filtrar" onclick="botFiltrar_Click" />
                    </fieldset>
                     <fieldset class="asig" style="width: 160px; height: 440px">
            <legend>Asignaturas</legend>
                        <asp:ListBox ID="ListAct" runat="server" Height="412px" Width="160px" Autopostback="true"  OnSelectedIndexChanged="seleccionar">
                        </asp:ListBox>
                    </fieldset>
        </div>

        <div id="divPanelContenido" style="width:715px; float: left; margin-left:5px">
        <fieldset class="infoAsig" style="width: 687px; height:200px">
            <legend>Información de la asignatura</legend>


                            <div style="float:left; width:469px">
                                    <asp:Label ID="labelNombreAsignatura" runat="server" Font-Bold="True" Font-Size="X-Large" 
                                        Text="[ Nombre de la asignatura ]"></asp:Label>
                                    <br />
                                    <br />
                                    <asp:Label ID="labelDescripcionAsignatura" runat="server" Font-Size="Medium" 
                                        Text="[ Descripción de la asignatura ]"></asp:Label>
                                    <br />
                                    <br />
                                    <asp:Label ID="tituloCoor" runat="server">Coordinador:</asp:Label>
                                    <asp:Label ID="labelCoordinadorAsignatura" runat="server" Text="[ Nombre del coordinador ]"></asp:Label>
                                    <br />
                                    <br />
                                    <asp:Label ID="tituPun" runat="server">Puntuación:</asp:Label>
                                   <br />
                                    <br />
                                    <asp:Rating ID="r1" runat="server" CurrentRating="0" MaxRating="10" StarCssClass="ratingStar" WaitingStarCssClass="savedRatingStar" 
                                    FilledStarCssClass="filledRatingStar" EmptyStarCssClass="emptyRatingStar" >
                                    </asp:Rating>
                                    &nbsp;<input id="Submit1" type="submit" value="Vota"  onclick="Submit1_onclick()" />
                                </div>
                                <div style="float:left">
                                    <asp:Label ID="labelTurnos" runat="server" Font-Bold="True" Text="Turnos" align="center"></asp:Label>
                                    <br />
                                    <asp:ListBox ID="listaTurnos" runat="server" Height="118px" Width="190px">
                                    </asp:ListBox>
                                </div>
                    </fieldset>
                    <fieldset class="filtro"  id="coment" runat="server" style="width: 687px; height:380px">
                        <legend>Comentarios</legend>
                        <div style="height: 240px; overflow: auto; border: 1px solid Gray;">
                             <% = comentarios %>
                        </div>
                     
                        <div style="height: 60px; width: 658px;">
                            &nbsp;&nbsp;<asp:TextBox ID="textoComent" TextMode="MultiLine" runat="server" 
                                Height="80px" Width="550px" style=" position:relative; left:0px; top:0px; margin-top:10px"></asp:TextBox>
                                <asp:Button ID="botonEnviar" runat="server"  Text="Comentar" 
                                style="margin-top:0px; width:70px;" onclick="botNuevoComentario_Click"/>
                               <br />
                                <asp:CheckBox ID="checkAnonimo" runat="server" Text="Enviar de forma anónima" />
                        </div>
                    </fieldset>
       </div>
</asp:Content>