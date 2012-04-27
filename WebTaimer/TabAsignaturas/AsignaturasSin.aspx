<%@ Page Title="Asignaturas" Language="C#" MasterPageFile="~/NoLogin.master" AutoEventWireup="true"
    CodeBehind="Asignaturas.aspx.cs" Inherits="WebTaimer.TabAsignaturas.Asignaturas" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        #TextArea1
        {
            z-index: 1;
            left: 513px;
            top: 767px;
            position: absolute;
            height: 39px;
            width: 495px;
        }
        </style>
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
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
            </style>

        <div id="divPanelIzquierdo" style="width:200px; float: left">
         <fieldset class="filtro" style="width: 160px; height:80px">
            <legend>Filtro</legend>
                        <asp:TextBox ID="textboxTitulacion" runat="server" Width="160px" placeholder="Titulación"></asp:TextBox>
                        Curso: 
                        <asp:DropDownList ID="dropdownCurso" runat="server" Width="58px">
                            <asp:ListItem Selected="True">1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;<asp:Button ID="botFiltrar" runat="server" Text="Filtrar" />
                    </fieldset>
                     <fieldset class="asig" style="width: 160px; height: 440px">
            <legend>Asignaturas</legend>
                        <asp:ListBox ID="ListBox1" runat="server" Height="412px" Width="160px">
                            <asp:ListItem>Asignatura 1</asp:ListItem>
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
                                    <asp:Label ID="labelPuntuacionAsignatura" runat="server" Text="★★★★★"></asp:Label>
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
                            &nbsp;<p style="float:right; width: 82px; margin: 0px; margin-left:10px; margin-top:22px;">Anónimo <input id="Checkbox1" type="checkbox" disabled="disabled" /></p>
                            &nbsp;<input id="Button1" type="button" value="Enviar" 
                                style="float: right; margin-top:22px;" disabled="disabled" /><textarea 
                                id="TextArea1" name="S1" rows="2" style="float:left; resize: none;" disabled="disabled"></textarea></div>
       </div>
</asp:Content>
