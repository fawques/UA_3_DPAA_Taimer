<%@ Page Title="Mis horarios" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Horarios.aspx.cs" Inherits="WebTaimer.TabHorarios.Horarios" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Mis horarios
        (Viendo: 
        <asp:Label ID="labelViendoHorario" runat="server" Text="[ HORARIO ]"></asp:Label>
        )</h2>

    <!-- PANEL IZQUIERDO (seleccionar horario) ---------------->

    <style>
        #divPanelIzquierdo
        {
            width:150px;
            height:632px;
        }
    </style>

    <div id="divPanelIzquierdo" style="float: left; margin-left: 0px">
    
    <fieldset class="fieldHorarios" style="width: 122px; height: 213px; margin-top:0px">
            <legend>Horarios</legend>

            <div style="margin-top:-15px">
            <asp:ListBox ID="listaHorarios" runat="server" Height="200px" 
                style="width:120px" 
                onselectedindexchanged="listaHorarios_SelectedIndexChanged" Font-Size="X-Small">
            </asp:ListBox>
            </div>

        </fieldset><br />
        <fieldset class="fieldPropiedades" style="width: 122px; height: 90px; margin-top:-30px">
            <legend>Propiedades</legend>
            <div style="margin-top:-15px">
                <asp:CheckBox ID="checkPublico" runat="server" Text="Hacer público"/>

            <br />
            <asp:Button ID="botCambiarNombre" runat="server" Text="Cambiar nombre" 
                style="margin-top:5px; width:120px" onclick="botCambiarNombre_Click" />
            <br />
            <asp:Button ID="botBorrarHorario" runat="server" Text="Borrar horario" 
                style="margin-top:5px; width:120px" onclick="botBorrarHorario_Click" />
            </div>
        </fieldset>



        <fieldset class="fieldDetalles" style="width: 122px; height: 265px; margin-top:0px">
            <legend>Detalles</legend>

            <div style="margin-top: -15px; margin-left: -40px;">
                <ul style="width: 122px; margin-top:-20px">
                    <li>
                        <label class="detalles">Nombre</br></label>
                    </li>
                    <li>
                        Asignatura 1
                    </li>
                    <br />
                    <br />
                    <li>
                        <label class="detalles">Descripción<br /></label>
                    </li>
                    <li>
                        Aquí una descripción de la asignatura.
                    </li>
                    <br />
                    <br />
                    <li>
                        <label class="detalles">Ubicación<br /></label>
                    </li>
                    <li>
                        Aula D25 (Aulario 2)
                    </li>
                    <br />
                    <br />
                    <li>
                        <label class="detalles">Turno<br /></label>
                    </li>
                    <li>
                        13:00 - 15:00
                    </li>
                    <br />
                    <br />
                    <li>
                    <asp:Button ID="botonMasInformacion" runat="server"
                        Text="Más información" Width="122px" />
                    </li>
                </ul>
            </div>
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

    <div id="divZonaHorario" 
        style="border-right: 1px solid Gray; border-top: 1px solid Gray; border-bottom: 1px solid Gray; float: right; height: 648px; overflow: auto; width: 768px; margin-top: 29px; border-left-style: none; border-left-color: inherit; border-left-width: medium; margin-left: 0px; margin-right: 0px; margin-bottom: 0px;">
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
            font-size: 11px;
        }
        p.detalles 
        {
            width:600px;
            margin: 0px;
            display: inline;
        }
        
    </style>

    </asp:Content>