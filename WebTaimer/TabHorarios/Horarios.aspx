﻿<%@ Page Title="Mis horarios" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Horarios.aspx.cs" Inherits="WebTaimer.TabHorarios.Horarios" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Mis horarios
        (Viendo: Horario 1)</h2>

    <!-- PANEL IZQUIERDO (seleccionar horario) ---------------->

    <style>
        #divPanelIzquierdo
        {
            width:150px;
            height:632px;
        }
    </style>

    <div id="divPanelIzquierdo" style="float: left; margin-left: 0px">
    
    <fieldset class="fieldHorarios" style="width: 122px; height: 452px; margin-top:0px">
            <legend>Horarios</legend>

            <asp:ListBox ID="listaHorarios" runat="server" Height="420px" style="width:120px">
                <asp:ListItem>Horario 1</asp:ListItem>
                <asp:ListItem>Horario 2</asp:ListItem>
                <asp:ListItem>Horario 3</asp:ListItem>
            </asp:ListBox>

        </fieldset><br />
        <fieldset class="fieldPropiedades" style="width: 122px; height: 105px; margin-top:-30px">
            <legend>Propiedades</legend>

                <asp:CheckBox ID="checkPublico" runat="server" Text="Hacer público"/>

            <br />
            <asp:Button ID="botCambiarNombre" runat="server" Text="Cambiar nombre" 
                style="margin-top:5px; width:120px" onclick="botCambiarNombre_Click" />
            <br />
            <asp:Button ID="botBorrarHorario" runat="server" Text="Borrar horario" 
                style="margin-top:5px; width:120px" onclick="botBorrarHorario_Click" />

        </fieldset>

    </div>



    <!-- ZONA DE HORARIO -------------------------------------->

   <style>
        #divZonaHorario
        {
            width:764px;
            background-color:Maroon;
        }
        
        div.columnas 
        {
           color: #78532a;
           margin: 5px;
           background-color: White;
           width: 89px;
           float: left;
           height: 500px;
       }
       
       .diasSem 
       {
           color: White; 
           font-weight: bold; 
           width: 89px;
           text-align: center;
           display: inline;
       }
       
       p.horas 
       {
           color: White;
           width: 70px;
           text-align: center;
           margin: 0px;
           margin-bottom:20px;
       }
    </style>

    <div id="divZonaHorario" style="float: right; height: 460px; overflow: auto; width: 768px; margin: 0px; margin-top: 29px; border: 1px solid Gray; border-left: none; ">
        <div style="height: 460px; color: Maroon; width: 760px; margin-left: -10px; margin-right:-10px;">

                <div style="background-color: Maroon; height: 23px; padding-left: 89px;">
                    <p class="diasSem" style="margin-left: 0px">Lunes</p>
                    <p class="diasSem" style="margin-left: 60px">Martes</p>
                    <p class="diasSem" style="margin-left: 50px">Miércoles</p>
                    <p class="diasSem" style="margin-left: 50px">Jueves</p>
                    <p class="diasSem" style="margin-left: 55px">Viernes</p>
                    <p class="diasSem" style="margin-left: 50px">Sábado</p>
                    <p class="diasSem" style="margin-left: 50px">Domingo</p>

                   


                </div>
                <div style="width: 55px; height: 437px; background-color: Maroon; float: left; clear:both; margin-right: 5px;">
                    <p class="horas"> 9:00</p>
                    <p class="horas"> 10:00</p>
                    <p class="horas"> 11:00</p>
                    <p class="horas"> 12:00</p>
                    <p class="horas"> 13:00</p>
                    <p class="horas"> 14:00</p>
                    <p class="horas"> 15:00</p>
                    <p class="horas"> 16:00</p>
                    <p class="horas"> 17:00</p>
                    <p class="horas"> 18:00</p>
                    <p class="horas"> 19:00</p>
                    <p class="horas"> 20:00</p>
                    <p class="horas"> 21:00</p>
                </div>
                
                <div class="columnas">
                </div>
                <div class="columnas">
                    <div style="height: 40px; background-color: #f1be87; text-align: center;">
                        <br />
                        <label>Asignatura</label>
                    </div>
                </div>
                <div class="columnas">
                    <div style="height: 40px;  background-color: #f1be87; text-align: center; margin-top: 167px;">
                        <br />
                        <label>Asignatura</label>
                    </div>
                </div>
                <div class="columnas">
                    <div style="height: 40px;  background-color: #f1be87; text-align: center; margin-top: 85px;">
                        <br />
                        <label>Asignatura</label>
                    </div>
                </div>
                <div class="columnas">
                </div>
                <div class="columnas">
                </div>
                <div class="columnas">
                </div>

                
        </div>
    </div>



    <!-- PANEL ABAJO (información de asignatura) ------------>

    <style>
        li 
        {
            list-style-type:none;
            display: inline;

        }
        label.detalles 
        {
            font-weight: bold;
            font-size: 13px;
        }
        p.detalles 
        {
            width:600px;
            margin: 0px;
            display: inline;
        }
        
    </style>

    <fieldset class="fieldHorarios" 
        style=" height: 110px; float:right; width: 535px;">
            <legend>Detalles</legend>
        <div style="width: 742px; height: 100px; display: block; margin-top: -15px;">
            <ul style="width: 730px; float: left; margin-top: 20px; margin-left: -30px; margin-right: 0px; margin-bottom: 0px;">
                <li>
                    <label class="detalles">Nombre:</label>
                    <p class="detalles">  Asignatura 1&nbsp;&nbsp;&nbsp;&nbsp; </p>
                </li>
                <li>
                    <label class="detalles">Descripción:</label>
                    <p class="detalles">  bla bla bla blab bla bla&nbsp; &nbsp;&nbsp; </p>
                </li>
                <li>
                    <label class="detalles">Ubicación:</label>
                    <p class="detalles">  universidad de alicante&nbsp;&nbsp;&nbsp; </p>
                </li>
                <li>
                    <label class="detalles">Turno</label>
                    <p class="detalles">  HH:MM - HH:MM </p>
                </li>
                <li style="float: right;">
                    
                    
                    
                    
                    <asp:Button ID="botonMasInformacion" runat="server" style= "margin-right: 50px; margin-top: 20px; position:static;"
                        Text="Más información" />
                    
                    
                    
                    
                </li>
                
            </ul>
        </div>
    </fieldset>

    </asp:Content>