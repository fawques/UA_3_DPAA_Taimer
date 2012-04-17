<%@ Page Title="Mis horarios" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Horarios.aspx.cs" Inherits="WebTaimer.TabHorarios.Horarios" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Mis horarios
    </h2>
    <p>
        Selecciona el horario que deseas ver:<br />
<asp:DropDownList ID="listaAsignaturas" runat="server" 
            
            style="z-index: 1; width: 320px">
        </asp:DropDownList>
        <asp:CheckBox ID="checkHacerPublico" runat="server" 
            Text="Hacer público este horario" />
    </p>
    <p>
    </p>
    <asp:Panel ID="panelHorario" runat="server" Height="700px" Width="920px" 
        BorderColor="#666666">
    </asp:Panel>
    
    <p>
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
    </p>
</asp:Content>