<%@ Page Title="Nueva petición" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="NuevaPeticion.aspx.cs" Inherits="WebTaimer.TabPeticiones.NuevaPeticion" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Nueva petición
    </h2>
    <p>
        Selecciona una asignatura:<br />
<asp:DropDownList ID="listaAsignaturas" runat="server" 
            
            style="z-index: 1; width: 320px">
        </asp:DropDownList>
    </p>
    <p>
        Selecciona el turno que deseas solicitar:<br />
        <asp:ListBox ID="ListBox1" runat="server" Height="180px" Width="320px">
        </asp:ListBox>
    </p>
    <p>
        <asp:Button ID="botCrearPeticion" runat="server" Text="Crear petición" 
            onclick="botCrearPeticion_Click" />
        <asp:Button ID="botCancelar" runat="server" 
            style="z-index: 1; left: 5px; position: relative" Text="Cancelar" 
            onclick="botCancelar_Click" />
    </p>
</asp:Content>