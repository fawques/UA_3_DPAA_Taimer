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
        Selecciona una asignatura:
        <asp:DropDownList ID="listaAsignaturas" runat="server" 
            
            style="z-index: 1; left: 5px; top: 0px; position: relative; height: 20px; width: 280px">
        </asp:DropDownList>
    </p>
    <p>
    <asp:Label ID="labelDescripcion" runat="server" 
            style="z-index: 1; left: 0px; top: 0px; position: relative"
            Text="Descripción" Font-Size="Medium"></asp:Label>
        <asp:Label ID="labelTurnos" runat="server" 
            style="z-index: 1; left: 578px; top: 0px; position: relative"
            Text="Turnos" Font-Size="Medium"></asp:Label>
        <asp:Button ID="Button1" runat="server" 
            
            style="z-index: 1; left: 525px; top: 152px; position: relative; width: 255px;" 
            Text="Solicitar turno seleccionado" />
        <br />
        <textarea id="TextArea1" name="S1" style="resize: none; z-index: 1; left: 0px; top: 0px; position: relative" 
            readonly="readonly"></textarea>
            <asp:ListBox ID="ListBox1" runat="server" 
            
            
            
            
            
            style="z-index: 1; left: 17px; top: -40px; position: relative; height: 118px; width: 255px;">
        </asp:ListBox>
    </p>
    <p>
    
    <asp:Label ID="labelComentarios" runat="server" 
            style="z-index: 1; left: 0px; top: 0px; position: relative"
            Text="Comentarios" Font-Size="Medium"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox2" runat="server" 
            
            
            style="z-index: 1; left: 0px; top: 0px; position: relative; height: 280px; width: 920px;">
        </asp:ListBox>
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