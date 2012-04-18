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
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Asignaturas</h2>
    <p>
        <asp:TextBox ID="textboxTitulacion" runat="server" Width="160px">[ Titulación ]</asp:TextBox>
        <asp:Label ID="labelNombreAsignatura" runat="server" Font-Size="XX-Large"
        style="z-index: 1; left: 10px; top: 0px; position: relative;"
            Text="[ Nombre de la asignatura ]"></asp:Label>
        <br />
        Curso: <asp:DropDownList ID="listaAsignaturas" runat="server" 
            
            
            style="z-index: 1; left: 5px; top: 0px; position: relative; height: 20px; width: 118px">
        </asp:DropDownList>
        <asp:Label ID="labelDescripcion" runat="server" Text="[ Descripción ]"
        style="z-index: 1; left: 17px; top: 0px; position: relative;"></asp:Label>
        <br />
        <asp:Button ID="botonFiltrar" runat="server" Text="Filtrar" style="z-index: 1; left: 107px; top: 0px; position: relative;"/>
        <asp:Label ID="labelCoordinador" runat="server" Text="[ Coordinador ]"
        style="z-index: 1; left: 121px; top: 0px; position: relative;"></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="ListBox3" runat="server" Height="400px" Width="160px">
        </asp:ListBox>
        <asp:Label ID="Label1" runat="server" Text="Puntuación: [ * * * * * ]" style="z-index: 1; left: 10px; top: -380px; position: relative; height: 20px; width: 118px"></asp:Label>
        <br />
        <br />
    </p>
    <asp:Button ID="botNuevoComentario" runat="server" 
        style="z-index: 1; left: 0px; top: 0px; position: relative" 
        Text="Nuevo comentario" onclick="botNuevoComentario_Click" />
    <asp:Button ID="botBorrarComentario" runat="server" 
        style="z-index: 1; left: 5px; top: 0px; position: relative" 
        Text="Borrar comentario" />
    <br />
</asp:Content>