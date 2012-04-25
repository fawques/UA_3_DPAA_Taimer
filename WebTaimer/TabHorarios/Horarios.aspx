<%@ Page Title="Mis horarios" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Horarios.aspx.cs" Inherits="WebTaimer.TabHorarios.Horarios" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Mis horarios
    </h2>

    <!-- PANEL IZQUIERDO (seleccionar horario) ---------------->

    <style>
        #divPanelIzquierdo
        {
            width:150px;
            height:600px;
            background-color:Lime;
        }
    </style>

    <div id="divPanelIzquierdo" style="float: left; margin-left: 0px">
    
    <fieldset class="fieldHorarios" style="width: 122px; height: 523px">
            <legend>Horarios</legend>

            <asp:ListBox ID="listaHorarios" runat="server" Height="493px" style="width:120px"></asp:ListBox>

        </fieldset><br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Hacer público" />

    </div>



    <!-- ZONA DE HORARIO -------------------------------------->

   <style>
        #divZonaHorario
        {
            width:610px;
            background-color:Aqua;
        }
    </style>

    <div id="divZonaHorario" style="float: left; margin-left: 5px">

        <asp:Panel ID="panelHorario" runat="server" Height="600px" 
            ScrollBars="Vertical">

            <div style="float: left; margin-left:0px; width:45px; height:1440px; background-color:Orange;">
            </div>

            <div style="float: left; margin-left:2px; width:76px; height:1440px; background-color:Orange;">
            </div>

            <div style="float: left; margin-left:2px; width:76px; height:1440px; background-color:Orange;">
            </div>

            <div style="float: left; margin-left:2px; width:76px; height:1440px; background-color:Orange;">
            </div>

            <div style="float: left; margin-left:2px; width:76px; height:1440px; background-color:Orange;">
            </div>

            <div style="float: left; margin-left:2px; width:76px; height:1440px; background-color:Orange;">
            </div>

            <div style="float: left; margin-left:2px; width:76px; height:1440px; background-color:Orange;">
            </div>

            <div style="float: left; margin-left:2px; width:76px; height:1440px; background-color:Orange;">
            </div>

        </asp:Panel>
    </div>



    <!-- PANEL DERECHO (información de asignatura) ------------>

    <style>
        #divPanelDerecho
        {
            width:150px;
            background-color:Red;
        }
    </style>

    <div id="divPanelDerecho" style="float: left; margin-left: 5px">
        <fieldset class="fieldInfoAsignatura" style="width: 122px; height: 543px">
            <legend>Información</legend>
    </div>



    </asp:Content>