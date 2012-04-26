﻿<%@ Page Title="Mis horarios" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
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

            <div style="float: left; margin-left:0px; width:31px; height:1440px; border: 1px solid black; text-align: center;"
                ; background-color:Orange>
                00:00</div>

            <div style="float: left; margin-left:0px; width:78px; height:1440px; border: 1px solid black"; background-color:Orange">
            </div>

            <div style="float: left; margin-left:0px; width:78px; height:1440px; border: 1px solid black"; background-color:Orange">
            </div>

            <div style="float: left; margin-left:0px; width:78px; height:1440px; border: 1px solid black"; background-color:Orange">
            </div>

            <div style="float: left; margin-left:0px; width:78px; height:1440px; border: 1px solid black"; background-color:Orange">
            </div>

            <div style="float: left; margin-left:0px; width:78px; height:1440px; border: 1px solid black"; background-color:Orange">
            </div>

            <div style="float: left; margin-left:0px; width:78px; height:1440px; border: 1px solid black"; background-color:Orange">
            </div>

            <div style="float: left; margin-left:0px; width:78px; height:1440px; border: 1px solid black"; background-color:Orange">
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
            <asp:Label ID="labelNombreAsignatura" runat="server" Font-Bold="True" 
                Font-Size="Medium" style="text-align: center" Text="[ Nom. Asignatura ]"></asp:Label>
            <br />
            <br />
            Ubicación:<br />
            <asp:Label ID="labelUbicacion" runat="server" style="text-align: right" 
                Text="[ Ubicación ]" Font-Bold="True"></asp:Label>
            <br />
            <br />
            Hora de inicio:<br />
            <asp:Label ID="labelHoraInicio" runat="server" Text="[ Hora Ini. ]" 
                Font-Bold="True"></asp:Label>
            <br />
            <br />
            Hora de fin:<br />
            <asp:Label ID="labelHoraFin" runat="server" Text="[ Hora Fin ]" 
                Font-Bold="True"></asp:Label>
            <br />
            <br />
            Coordinador:<br />
            <asp:Label ID="labelCoordinador" runat="server" Text="[ Nom. Coord ]" 
                Font-Bold="True"></asp:Label>
            <br />
            <br />
            <asp:Button ID="botonMasInformacion" runat="server" align="center" Text="Mas información" Width="120px" />
    </div>

    </asp:Content>