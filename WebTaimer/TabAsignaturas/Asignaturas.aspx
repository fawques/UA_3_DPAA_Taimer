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
        .style4
        {
            width: 175px;
        }
        .style5
        {
            width: 10px;
        }
        .style6
        {
            width: 487px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Asignaturas</h2>

        <table style="width: 100%; z-index: 1; left: 0px; top: 0px; position: relative; height: 600px;">
            <tr>
                <td class="style4" bgcolor="Yellow">
                    <asp:Panel ID="panelFiltro" runat="server" GroupingText="Filtro">
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
                    </asp:Panel>
                    <asp:Panel ID="panelSeleccion" runat="server" GroupingText="Selección">
                        <asp:ListBox ID="ListBox1" runat="server" Height="412px" Width="160px">
                        </asp:ListBox>
                    </asp:Panel>
                    </td>
                    <td class="style5"></td>
                <td class="ParteContenido">
                    <asp:Panel ID="panelInfoAsignatura" runat="server" 
                        GroupingText="Información de la asignatura">
                        <table style="width:100%;">
                            <tr>
                                <td class="style6">
                                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                                        Text="[ Nombre de la asignatura ]"></asp:Label>
                                    <br />
                                    <br />
                                    <asp:Label ID="Label2" runat="server" Font-Size="Medium" 
                                        Text="[ Descripción de la asignatura ]"></asp:Label>
                                    <br />
                                    <br />
                                    Coordinador:
                                    <asp:Label ID="Label3" runat="server" Text="[ Nombre del coordinador ]"></asp:Label>
                                    <br />
                                    <br />
                                    Puntuación:
                                    <asp:Label ID="labelPuntuacion" runat="server" Text="★★★★★"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Turnos" align="center"></asp:Label>
                                    <br />
                                    <asp:ListBox ID="listaTurnos" runat="server" Height="118px" Width="190px">
                                        <asp:ListItem Selected="True">Miércoles, de 09:00 a 11:00</asp:ListItem>
                                    </asp:ListBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="panelComentarios" runat="server" GroupingText="Comentarios" 
                        Height="400px">
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
                        <br />
                        <br />
                        <asp:TextBox ID="textboxComentario" runat="server" Width="508px">Nuevo comentario</asp:TextBox>
                        <asp:Button ID="botonEnviarComentario" runat="server" Text="Enviar" style="z-index: 1; left: 10px; top: 0px; position: relative"/>
                        <asp:CheckBox ID="checkboxAnonimo" runat="server" Text="Anónimo" style="z-index: 1; left: 20px; top: 0px; position: relative"/>
                        <br />
                    </asp:Panel>
                </td>
            </tr>
        </table>

</asp:Content>