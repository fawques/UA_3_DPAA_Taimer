
<%@ Page Title="Horarios públicos" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="HorariosPublicos.aspx.cs" Inherits="WebTaimer.TabHorariosPublicos.HorariosPublicos" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style>
        #divPanelIzquierdo
        {
            width:150px;
            height:632px;
        }
        
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
           height: 520px;
       }
       
       .diasSem 
       {
           color: White; 
           font-weight: bold; 
           width: 89px;
           text-align: center;
           display: inline;
       }
       
       div.horas 
       {
        width: 55px; 
        height: 437px; 
        background-color: Maroon; 
        float: left; 
        clear:both; 
        margin-right: 5px;   
       }
       
       p.horas 
       {
           color: White;
           width: 70px;
           text-align: center;
           margin: 0px;
           height: 40px;
           
       }
       .Asignatura 
       {
        height: 38px; 
        background-color: #f1be87; 
        text-align: center; 
        border: 1px solid Black;  
        position: relative;
       }
       .asigText 
       {
           width: 89px; 
           position: relative; 
           top: 50%; height: 20px; 
           margin: 0 px; 
           margin-top: -10px;
       }
       
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
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Mis horarios
    </h2>

    <!-- PANEL IZQUIERDO (seleccionar horario) ---------------->

   

    <div id="divPanelIzquierdo" style="float: left; margin-left: 0px">
    
    <fieldset class="fieldHorarios" style="width: 122px; height: 452px">
            <legend>Horarios</legend>

            <asp:ListBox ID="listaHorarios" runat="server" Height="420px" style="width:120px">
            </asp:ListBox>

        </fieldset><br />

        <!--<asp:Label ID="Label1" runat="server" Text="Label"><%; %></asp:Label>-->

    </div>



    <!-- ZONA DE HORARIO -------------------------------------->

    <div id="divZonaHorario" style="float: right; width: 768px; margin: 0px; margin-top: 29px; border: 1px solid Gray; border-left: none;">
        <div style="color: Maroon; width: 760px; ">

                <div style="background-color: Maroon; height: 23px; padding-left: 89px;">
                    <p class="diasSem" style="margin-left: 0px">Lunes</p>
                    <p class="diasSem" style="margin-left: 60px">Martes</p>
                    <p class="diasSem" style="margin-left: 50px">Miércoles</p>
                    <p class="diasSem" style="margin-left: 50px">Jueves</p>
                    <p class="diasSem" style="margin-left: 55px">Viernes</p>
                    <p class="diasSem" style="margin-left: 50px">Sábado</p>
                    <p class="diasSem" style="margin-left: 50px">Domingo</p>

                   

                   
                </div>
                <div class="horas" id="HorasTabla" runat="server">
                 <% horarioPrueba(); Response.Write(setHoras()); %>
                </div>
                 <% Response.Write(setColums()); %>
                <!--<div class="columnas" style="height: 480px;" >
                    <div class='Asignatura' style="top: 40px;">
                    <label>Asignatura</label>
                    </div>
                    <div class='Asignatura' style=" top: 40px;">
                    <label style='height: 20px; top: 50%; margin-top: -10px;'>Asignatura2</label>
                    </div>
                </div>-->
        </div>
    </div>



    <!-- PANEL ABAJO (información de asignatura) ------------>


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
                    
                    
                    
                    
                    <asp:Button ID="ComentarBoton" runat="server" style= "margin-right: 50px; margin-top: 20px; position:static;"
                        Text="Comentar" />
                    
                    
                    
                    
                </li>
                
            </ul>
        </div>
    </fieldset>

    </asp:Content>
