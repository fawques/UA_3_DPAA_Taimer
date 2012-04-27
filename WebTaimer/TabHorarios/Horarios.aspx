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

            <asp:ListBox ID="listaHorarios" runat="server" Height="493px" style="width:120px">
                <asp:ListItem>Horario 1</asp:ListItem>
                <asp:ListItem>Horario 2</asp:ListItem>
                <asp:ListItem>Horario 3</asp:ListItem>
            </asp:ListBox>

        </fieldset><br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Hacer público" />

    </div>



    <!-- ZONA DE HORARIO -------------------------------------->

   <style>
        #divZonaHorario
        {
            width:758px;
            background-color:Maroon;
        }
        
        div.columnas 
        {
           color: White;
           margin: 5px;
           background-color: White;
           width: 89px;
           float: left;
           height: 416px;
       }
       
       .diasSem 
       {
           color: White; 
           font-weight: bold; 
           width: 89px;
           text-align: center;
           display: inline;
       }
    </style>

    <div id="divZonaHorario" style="float: left; margin-left: 5px; height: 461px;">
        <div style="height: 460px; color: Maroon;">

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
                </div>
                
                <div class="columnas">
                </div>
                <div class="columnas">
                </div>
                <div class="columnas">
                </div>
                <div class="columnas">
                </div>
                <div class="columnas">
                </div>
                <div class="columnas">
                </div>
                <div class="columnas">
                </div>

                
        </div>
    </div>



    <!-- PANEL DERECHO (información de asignatura) ------------>

    <style>
        #divPanelDerecho
        {
            width:150px;
            background-color:Red;
        }
    </style>

    </asp:Content>