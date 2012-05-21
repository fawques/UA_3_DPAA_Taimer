<%@ Page Title="" Language="C#" MasterPageFile="~/NoLogin.Master" AutoEventWireup="true" CodeBehind="HorariosPublicosSin.aspx.cs" Inherits="WebTaimer.TabHorariosPublicos.HorariosPublicosSin" %>
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

        p.detalles 
        {
            color: Black;
            width:  114px;
            font-weight: bold;
            font-size: 11px;
            margin: 0px;
            margin-left: -40px;
            display; block;
        }
        
        #nombre, #descripcion, #ubicacion, #turno 
        {
            width:  114px;
            font-size: 11px;
            margin: 0px;
            margin-bottom: 5px;
            margin-left: -40px;
            display: block;
            
        }
        
    </style>

    <script language="javascript">
        var sesion;
        var actividadPropia;
        var turno = new Array();
        function setDetalles(id) {
            document.getElementById("Det").style.display = "inherit";
            var detalles = turno[id];
            document.getElementById("nombre").innerHTML = detalles[0];
            document.getElementById("descripcion").innerHTML = detalles[1];
            document.getElementById("ubicacion").innerHTML = detalles[2];
            document.getElementById("turno").innerHTML = detalles[3];

            var url;
            document.getElementById("botonComent").innerHTML = "";
            if (detalles[4] > 0) {
                if (sesion == true) {
                    url = "../TabAsignaturas/Asignaturas.aspx?idActividad=" + detalles[4];
                }
                else {
                    url = "../TabAsignaturas/AsignaturasSin.aspx?idActividad=" + detalles[4];
                }
                document.getElementById("botonComent").innerHTML = "<a href='" + url + "'><label style='text-decoration: none; font-weight: bold;'>Más información</lable></a>";
            }
            else if (detalles[5] == 1) {
                url = "../TabActividades/Actividades.aspx?idActividad=" + detalles[4];
                document.getElementById("botonComent").innerHTML = "<a href='" + url + "'><label style='text-decoration: none; font-weight: bold;'>Más información</lable></a>";
            }


        }

        function selected(id) {
            document.getElementById(id).style.backgroundColor = "#bfcbd6";
            document.getElementById(id).style.cursor = "pointer";
            document.getElementById(id).style.color = "#5995cd";
        }

        function unselected(id) {
            document.getElementById(id).style.backgroundColor = "#f1be87";
            document.getElementById(id).style.cursor = "default";
            document.getElementById(id).style.color = "#78532a";
        }

        function gotoComentarios(id) {
            alert("redirecciona");
            window.location = "../TabAsignaturas/Comentar.aspx";
        }
    </script>


</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<asp:ScriptManager ID="ScriptManager1" runat="server" />
<legend>Horarios</legend>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

    <h2><asp:HyperLink style="color: Maroon; text-decoration:none;" ID="horarioDe" runat="server" NavigateUrl=""/>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </h2>
    

    <!-- PANEL IZQUIERDO (seleccionar horario) ---------------->
    
   

    <div id="divPanelIzquierdo" style="float: left; margin-left: 0px">
    
    <fieldset class="fieldHorarios" 
            style="width: 110px; height: 291px; margin-top: -5px;">
        <legend>Horarios</legend>
            
                <label style="font-size: 10px"> <asp:RadioButton ID="RBHorarios" runat="server" 
                    GroupName="filtro" Checked="true" oncheckedchanged="RBHorarios_CheckedChanged" AutoPostBack="true"/> Horarios </label>
                <label style="font-size: 10px"> <asp:RadioButton ID="RBUsuarios" runat="server" 
                    GroupName="filtro" AutoPostBack="true" 
                    oncheckedchanged="RBUsuarios_CheckedChanged"/>  Usuarios </label>
                <asp:TextBox ID="textboxFiltro" runat="server" Width="114px"
                    placeholder="Filtrar..."></asp:TextBox>
                <asp:Button style="margin: 5px; float: right; " ID="Buscar" runat="server" 
                    Text="Buscar" onclick="Buscar_Click" />
                <asp:ListBox ID="listaHorarios" runat="server" Height="200px" Font-Size="X-Small"
                    style="width:120px" onselectedindexchanged="listaHorarios_SelectedIndexChanged" >
                </asp:ListBox>
                <asp:ListBox ID="listaUsuarios" runat="server" Height="200px" Font-Size="X-Small"
                    style="width:120px; display: none;" onselectedindexchanged="listaUsuarios_SelectedIndexChanged">
                </asp:ListBox>
                <asp:ListBox ID="listaHorariosUsuario" runat="server" Height="200px" Font-Size="X-Small"
                    style="width:120px; display: none;" onselectedindexchanged="listaHorariosUsuarios_SelectedIndexChanged">
                </asp:ListBox>
            
    </fieldset>

    <fieldset id="Det" class="fieldHorarios" style="width: 120px; height: auto; margin-top: -10px; display: none;">
        <legend>Detalles</legend>

        <ul style="margin: 0px; width: 80px;">
            <li>
                <p class="detalles">Nombre:</p>
                <label id="nombre"></label>
            </li>
            <li>
                <p class="detalles">Descripción:</p>
                <label id="descripcion"></label>
            </li>
            <li>
                <p class="detalles">Ubicacion:</p>
                <label id="ubicacion"></label>
            </li>
            <li>
                <p class="detalles">Turno:</p>
                <label id="turno"></label>
            </li>
            <li id="botonComent" style ="margin-left: -10px;">
                
            </li>
        </ul>

    </fieldset>
    </div>

    <div style="text-align: center; width: 768px; float: right; background-color: Maroon; border: 1px solid Gray; border-bottom: none; margin-bottom: 0px; border-left: none;">
        <label style="font-variant: small-caps; font-size: 16px; font-weight: bold; color: White;" id="nomHorario" runat="server"></label>
    </div>
    <!-- ZONA DE HORARIO -------------------------------------->

    <div id="divZonaHorario" style="float: right; width: 768px; margin: 0px; margin-top: 0px; border: 1px solid Gray; border-top: none; border-left: none;">
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
                 <% =_horas %>
                </div>
                 <% =_columnas %>
                 <% =_script %>
        </div>
    </div>

     </ContentTemplate>
            </asp:UpdatePanel>
    </asp:Content>
