<%@ Page Title="Actividades personales" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="EditarActividad.aspx.cs" Inherits="WebTaimer.TabActividades.EditarActividad" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Actividades personales
    </h2>
    <style>
        #divPanelIzquierdo{
            background-color:transparent;
        }
          #ConfirmaBorrar
            {
                
                background-color: #fff1bb;
                position:absolute;
                left:25%;
                top:25%;
                height:100px;
                width:600px;
                padding:10px;
                padding-left:20px;
                padding-top:30px;
            }  
    </style>

        <style>
            #divPanelContenido{
                background-color:transparent;
            }
            #Button1
            {
                width: 57px;
            }
            .comentario
            {
                width: 633px;
            }
                    
            
        </style>

        <div id="divPanelContenido" style="width:780px; float: left; margin-left:15px">
            <fieldset id="Fieldset1" class="infoAsig" style="width: 325px; height:300px; float: left" runat="server">
                <legend>Información de la actividad personal</legend>

                    <div style="float:left; width:330px; height: 226px;">
                        <asp:Label ID="labelNombreActividad" runat="server" Text="Nombre:"></asp:Label>
                        <br />
                        <asp:TextBox ID="tbNombreActividad" runat="server" style="margin-bottom: 15px"></asp:TextBox>                                                
                        <br />
                        <asp:Label ID="labelDescripcionActividad" runat="server" Font-Size="Medium" Text="Descripción: ">
                        </asp:Label>
                         <br />
                        <asp:TextBox ID="tbDescActividad" runat="server" TextMode="MultiLine" Width="300px"></asp:TextBox>
                        
                        <div id="optionButtons" runat="server" style="margin-top: 50px">                                                        
                            <asp:Button ID="botonModificar" runat="server" Text="Modificar"
                                style="width:120px" onclick="botonModificar_Click" />                            
                        </div>
                    </div>
          </fieldset>

          <fieldset id="Fieldset2" class="infoAsig" style="width: 325px; height:300px; float: right; margin-left: 10px" runat="server">
                <legend>Gestión de turnos de la actividad</legend>

                    <div style="float:right; width: 360px" id="divTurnos" runat="server">
                         <asp:ListBox ID="listaTurnos" runat="server" Autopostback="true" Height="210px" Width="190px" OnSelectedIndexChanged="CambiarTurno" style="float: right">                            
                        </asp:ListBox>

                        <div id="divCambiaTurno" runat="server" style="float: left" Visible="false">
                            <asp:Label ID="labelCambiaTurno" runat="server" Text="Modificar turno: "></asp:Label>
                            <br />
                             <asp:DropDownList ID="cambiaDia" runat="server" style="width: 142px">
                                <asp:ListItem Value="1">Lunes</asp:ListItem>
                                <asp:ListItem Value="2">Martes</asp:ListItem>
                                <asp:ListItem Value="3">Miércoles</asp:ListItem>
                                <asp:ListItem Value="4">Jueves</asp:ListItem>
                                <asp:ListItem Value="5">Viernes</asp:ListItem>
                                <asp:ListItem Value="5">Sábado</asp:ListItem>
                                <asp:ListItem Value="5">Domingo</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <asp:TextBox ID="tbCambiaHoraI" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="cambiaHoraIValidate" runat="server" ValidationExpression="^[0-2][0-9]\:[0-5][0-9]$" ControlToValidate="tbCambiaHoraI" 
                                CssClass="failureNotification" ErrorMessage="Hora no válida" ToolTip="Hora no válida">*</asp:RegularExpressionValidator>
                            <br />

                            <asp:TextBox ID="tbCambiaHoraF" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="cambiarHoraFValidate" runat="server" ValidationExpression="^[0-2][0-9]\:[0-5][0-9]$" ControlToValidate="tbCambiaHoraF" 
                                CssClass="failureNotification" ErrorMessage="Hora no válida" ToolTip="Hora no válida">*</asp:RegularExpressionValidator>
                            <br />

                            <asp:TextBox ID="tbCambiaUbic" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="cambiaUbicRequiered" runat="server" ControlToValidate="tbCambiaUbic" 
                                CssClass="failureNotification" ErrorMessage="Campo obligatorio." ToolTip="Campo obligatorio.">*</asp:RequiredFieldValidator>
                            <br />

                            <asp:Button ID="btConfirmaTurno" runat="server" Text="Cambiar"
                                style="width:120px; margin-left:5px" onclick="btConfirmaTurno_Click"/>
                            <br />

                            <asp:Button ID="btCancelaTurno" runat="server" Text="Cancelar" 
                                style="width:120px; margin-left:5px" onclick="btCancelaTurno_Click"/>                                                
                        </div>                            

                        <asp:Button ID="btCambiaTurno" runat="server" Text="Cambiar turno"
                            style="width:120px; float: left" onclick="btCambiaTurno_Click"/>
                        <br />
                        <asp:Button ID="btBorraTurno" runat="server" Text="Borrar turno"
                            style="width:120px; float: left" onclick="btBorraTurno_Click"/>
                        <br />
                        <asp:Button ID="btNuevoTurno" runat="server" Text="Añadir turno"
                            style="width:120px; float: left" onclick="btNuevoTurno_Click"/>
                        <br />
                        
                        <asp:Panel ID="ConfirmaBorrar" class="confirmaBorrado"  runat="server" BorderColor="Black" 
                            BorderStyle="None" Visible="False" 
                            Width="300px" style="padding-left: 5px; font-size: medium; font-weight: normal" >
                             <p style="margin-left: 15px">
                                ¿Deseas borrar el turno del 
                             </p>
                             <p id="infoTurno" runat="server" style="margin-left: 15px">
                             </p>
                             <p>                               
                                
                                 <asp:Button ID="btConfirmaBorrar" runat="server" Text="Confirmar" Visible="false"
                                   style="width:120px; float: left" onclick="btConfirmaBorrar_Click"/>                                
                                <asp:Button ID="btCancelaBorrar" runat="server" Text="Cancelar" Visible="false"
                                    style="float: left; width:120px" onclick="btCancelaBorrar_Click"/>                            
                              </p>
                         </asp:Panel>                      
                        
                        <div id="divNuevoTurno" runat="server" style="float: left" Visible="false">
                            <asp:Label ID="lbNuevoTurno" runat="server" Text="Nuevo turno: "></asp:Label>
                            <br />

                            <asp:DropDownList ID="NuevoDia" runat="server" style="width: 142px">
                                <asp:ListItem Value="1">Lunes</asp:ListItem>
                                <asp:ListItem Value="2">Martes</asp:ListItem>
                                <asp:ListItem Value="3">Miércoles</asp:ListItem>
                                <asp:ListItem Value="4">Jueves</asp:ListItem>
                                <asp:ListItem Value="5">Viernes</asp:ListItem>
                                <asp:ListItem Value="5">Sábado</asp:ListItem>
                                <asp:ListItem Value="5">Domingo</asp:ListItem>
                            </asp:DropDownList>
                            <br />

                            <asp:TextBox ID="tbNuevaHoraI" runat="server" Text="00:00"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="nuevaHoraIValidate" runat="server" ValidationExpression="^[0-2][0-9]\:[0-5][0-9]$" ControlToValidate="tbNuevaHoraI" 
                                CssClass="failureNotification" ErrorMessage="Hora no válida" ToolTip="Hora no válida">*</asp:RegularExpressionValidator>
                            <br />

                            <asp:TextBox ID="tbNuevaHoraF" runat="server" Text="00:00"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="nuevaHoraFValidate" runat="server" ValidationExpression="^[0-2][0-9]\:[0-5][0-9]$" ControlToValidate="tbNuevaHoraF" 
                                CssClass="failureNotification" ErrorMessage="Hora no válida" ToolTip="Hora no válida">*</asp:RegularExpressionValidator>
                            <br />

                            <asp:TextBox ID="tbNuevaUbic" runat="server" Text="Ubicación"></asp:TextBox>
                            <br />

                            <asp:Button ID="btConfirmaNuevo" runat="server" Text="Añadir"
                                style="width:120px; margin-left:5px; margin-top: 10px" onclick="btConfirmaNuevo_Click"/>
                            <br />
                            <asp:Button ID="btCancelaNuevo" runat="server" Text="Cancelar"
                                style="width:120px; margin-left:5px" onclick="btCancelaNuevo_Click"/>
                        </div>                                                                    
                                               
                    </div>
             </fieldset>
             <asp:Button ID="botonCancelar" runat="server" Text="Volver a Actividades"
                   style="margin-left: 600px" onclick="botonCancelar_Click"/>
          </div>
</asp:Content>
