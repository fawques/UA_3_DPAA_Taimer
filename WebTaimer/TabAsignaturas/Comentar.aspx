<%@ Page Title="Comentar asignatura" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Comentar.aspx.cs" Inherits="WebTaimer.TabAsignaturas.Comentar" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">

        #TextArea1
        {
            z-index: 1;
            left: 231px;
            top: 251px;
            position: absolute;
            height: 200px;
            width: 920px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Comentar asignatura
    </h2>
    <p>
        Estás escribiendo un comentario sobre la asignatura [ Nombre de la asignatura ].</p>
    <p>
    
    <asp:Label ID="labelComentario" runat="server" 
            style="z-index: 1; left: 0px; top: 0px; position: relative"
            Text="Comentario" Font-Size="Medium"></asp:Label>
        <br />
        <textarea id="textoComentario" name="S1" 
            
            style="resize: none; z-index: 1; left: 0px; top: 0px; position: relative; height: 200px; width: 920px;"></textarea></p>
            <asp:Button ID="botEnviarComentario" runat="server" 
        style="z-index: 1; left: 0px; top: 0px; position: relative" 
        Text="Enviar comentario" onclick="botEnviarComentario_Click" />
    <asp:CheckBox ID="checkComentarioAnonimo" runat="server" 
        style="z-index: 1; left: 10px; top: 0px; position: relative" 
        Text="Enviar de forma anónima" />
            <asp:Button ID="botNoEnviar" runat="server" 
        style="z-index: 1; left: 538px; top: 0px; position: relative" 
        Text="No enviar" onclick="botNoEnviar_Click" />
    <br />

</asp:Content>
