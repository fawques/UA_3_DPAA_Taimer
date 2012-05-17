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
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <h2>
        Asignaturas</h2>

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

        <div id="divPanelIzquierdo" style="width:200px; float: left">
         <fieldset class="filtro" style="width: 160px; height:80px">
            <legend>Filtro</legend>
                        <asp:TextBox ID="textboxTitulacion" runat="server" Width="160px" placeholder="Titulación"></asp:TextBox>
                        &nbsp;<asp:Button ID="botFiltrar" runat="server" Text="Filtrar" />
                    </fieldset>
                     <fieldset class="asig" style="width: 160px; height: 440px">
            <legend>Asignaturas</legend>
                        <asp:ListBox ID="ListAct" runat="server" Height="412px" Width="160px" >
                            <asp:ListItem >Asignatura 1</asp:ListItem>
                            <asp:ListItem>Asignatura 2</asp:ListItem>
                            <asp:ListItem>Asignatura 3</asp:ListItem>
                            <asp:ListItem>Asignatura 4</asp:ListItem>
                            <asp:ListItem>Asignatura 5</asp:ListItem>
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
                                    Coordinador:
                                    <asp:Label ID="labelCoordinadorAsignatura" runat="server" Text="[ Nombre del coordinador ]"></asp:Label>
                                    <br />
                                    <br />
                                    Puntuación:
                                   <br />
                                    <br />
                                    <asp:Rating ID="r1" runat="server" CurrentRating="2" MaxRating="10" StarCssClass="ratingStar" WaitingStarCssClass="savedRatingStar" 
                                    FilledStarCssClass="filledRatingStar" EmptyStarCssClass="emptyRatingStar" >
                                    </asp:Rating>
                                    &nbsp;<input id="Submit1" type="submit" value="Vota"  onclick="Submit1_onclick()" />
                                </div>
                                <div style="float:left">
                                    <asp:Label ID="labelTurnos" runat="server" Font-Bold="True" Text="Turnos" align="center"></asp:Label>
                                    <br />
                                    <asp:ListBox ID="listaTurnos" runat="server" Height="118px" Width="190px">
                                        <asp:ListItem Selected="True">Miércoles, de 09:00 a 11:00</asp:ListItem>
                                        <asp:ListItem>Jueves, de 10:30 a 12:30</asp:ListItem>
                                        <asp:ListItem>Jueves, de 16:30 a 16:30</asp:ListItem>
                                    </asp:ListBox>
                                </div>
                    </fieldset>
                    <fieldset class="filtro" style="width: 687px; height:320px">
                        <legend>Comentarios</legend>
                        <div style="height: 240px; overflow: auto; border: 1px solid Gray;">
                            <div class="comentario">
                                <img alt="Imagen del usuario que ha comentado" src="../Images/default.jpg" 
                                    style="height: 40px; width: 40px" class="comentario"/>
                                <span class="comentario">
                                    <label class="comentario">
                                        <p class="comentario">Comentario enviado por: Usuario 1 (DD/MM/AAAA HH:MM)</p>
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blablablabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla

                                    </label>
                                </span>
                            </div>
                             <div class="comentario">
                                <img alt="Imagen del usuario que ha comentado" src="../Images/default.jpg" 
                                    style="height: 40px; width: 40px" class="comentario"/>
                                <span class="comentario">
                                    <label class="comentario">
                                        <p class="comentario">Comentario enviado por: Usuario 2 (DD/MM/AAAA HH:MM)</p>
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blablablabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla

                                    </label>
                                </span>
                            </div>
                             <div class="comentario">
                                <img alt="Imagen del usuario que ha comentado" src="../Images/default.jpg" 
                                    style="height: 40px; width: 40px" class="comentario"/>
                                <span class="comentario">
                                    <label class="comentario">
                                        <p class="comentario">Comentario enviado por: Usuario 3 (DD/MM/AAAA HH:MM)</p>
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blablablabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla

                                    </label>
                                </span>
                            </div>
                             <div class="comentario">
                                <img alt="Imagen del usuario que ha comentado" src="../Images/default.jpg" 
                                    style="height: 40px; width: 40px" class="comentario"/>
                                <span class="comentario">
                                    <label class="comentario">
                                        <p class="comentario">Comentario enviado por: Usuario 4 (DD/MM/AAAA HH:MM)</p>
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla
                                        blabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blablablabla  blabla blabla  blabla blabla  blabla blabla  blabla blabla  blabla

                                    </label>
                                </span>
                            </div>
                        </div>
                        
                        <div style="height: 60px; width: 658px;">
                            &nbsp;&nbsp;<textarea 
                                id="TextArea1" name="S1" 
                                style="resize: none; position:relative; left:0px; top:0px; margin-top:10px"></textarea>
                                <input id="Button1" type="button" value="Enviar" 
                                style="margin-top:0px" />
                                <asp:CheckBox ID="checkAnonimo" runat="server" Text="Anónimo" />
                        </div>
       </div>
</asp:Content>