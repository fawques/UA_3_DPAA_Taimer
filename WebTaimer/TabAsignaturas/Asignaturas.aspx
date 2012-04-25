<%@ Page Title="Asignaturas" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Asignaturas.aspx.cs" Inherits="WebTaimer.TabAsignaturas.Asignaturas" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        #TextArea1
        {
            z-index: 1;
            left: 231px;
            top: 251px;
            position: absolute;
            height: 153px;
            width: 638px;
        }
        .style6
        {
            width: 724px;
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
            .style7
            {
                width: 242px;
            }
    </style>

        <div id="divPanelIzquierdo" style="width:200px; float: left">
         <fieldset class="filtro" style="width: 160px; height:80px">
            <legend>Filtro</legend>
                        <asp:TextBox ID="textboxTitulacion" runat="server" Width="160px">Titulación</asp:TextBox>
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
                                    </asp:ListBox>
                                </div>
                    </fieldset>
                    <fieldset class="filtro" style="width: 687px; height:320px">
                        <legend>Comentarios</legend>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:TextBox ID="textbox1" runat="server" Width="508px">Nuevo comentario</asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="Enviar" style="z-index: 1; left: 10px; top: 0px; position: relative"/>
                        <asp:CheckBox ID="checkbox1" runat="server" Text="Anónimo" style="z-index: 1; left: 20px; top: 0px; position: relative"/>
                        <br />
                    </asp:Panel>
        </div>
</asp:Content>