<%@ Page Title="Peticiones" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Peticiones.aspx.cs" Inherits="WebTaimer.TabPeticiones.Peticiones" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Peticiones</h2>
    <p>
        &nbsp;<asp:Label ID="labelPetPendientes" runat="server" 
            style="z-index: 1; left: 30px; top: 0px; position: relative"
            Text="Peticiones pendientes" Font-Size="Medium"></asp:Label>
        <asp:Label ID="labelPetAceptadas" runat="server" 
            style="z-index: 1; left: 325px; top: 0px; position: relative" 
            Text="Peticiones aceptadas" Font-Size="Medium"></asp:Label>
        <br />
        <asp:ListBox ID="listaPetPendientes" runat="server" 
            
            style="z-index: 1; left: 35px; top: 10px; position: relative; height: 300px; width: 400px">
        </asp:ListBox>
        <asp:ListBox ID="listaPetAceptadas" runat="server" 
            
            style="z-index: 1; left: 83px; top: 10px; position: relative; height: 300px; width: 400px">
        </asp:ListBox>
    </p>
    <asp:Button ID="botNuevaPeticion" runat="server" 
        style="z-index: 1; left: 35px; top: 5px; position: relative" 
        Text="Nueva petición" />
    <asp:Button ID="botBorrarPeticionSeleccionada" runat="server" 
            style="z-index: 1; left: 46px; top: 5px; position: relative; width: 191px" 
            Text="Borrar petición seleccionada" />
    <asp:Button ID="botLimpiarLista" runat="server" 
        style="z-index: 1; left: 482px; top: 5px; position: relative" 
        Text="Limpiar lista" />
    </asp:Content>

