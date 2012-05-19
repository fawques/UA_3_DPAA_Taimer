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

        <div id="divPanelContenido" style="width:686px; float: left; margin-left:5px">
            <fieldset id="Fieldset1" class="infoAsig" style="width: 750px; height:300px" runat="server">
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
                            <asp:Button ID="botonCancelar" runat="server" Text="Cancelar"
                                style="width:120px; margin-left:5px" onclick="botonCancelar_Click"/>
                        </div>
                    </div>

                    <div style="float:right; width: 360px" id="divTurnos" runat="server">
                         <asp:ListBox ID="listaTurnos" runat="server" Height="210px" Width="190px" OnSelectedIndexChanged="CambiarTurno" style="float: right">                            
                        </asp:ListBox>

                        <div id="divCambiaTurno" runat="server" style="float: left" Visible="false">
                            <asp:Label ID="labelCambiaTurno" runat="server" Text="Modificar turno: "></asp:Label>
                            <br />
                            <asp:TextBox ID="tbCambiaDia" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="cambiaDiaValidate" ErrorMessage="Día no válido" ValidationExpression="^(Lunes|Martes|Miercoles|Miércoles|Jueves|Viernes)$" ToolTip="Día no válido" runat="server" 
                                CssClass="failureNotification" ControlToValidate="tbCambiaDia">*</asp:RegularExpressionValidator>
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

                        <asp:Button ID="btConfirmaBorrar" runat="server" Text="Confirmar" Visible="false"
                            style="width:120px; float: left" onclick="btConfirmaBorrar_Click"/>
                        <br />
                        <asp:Button ID="btCancelaBorrar" runat="server" Text="Cancelar" Visible="false"
                            style="float: left; width:120px" onclick="btCancelaBorrar_Click"/>

                        <div id="divNuevoTurno" runat="server" style="float: left" Visible="false">
                            <asp:Label ID="lbNuevoTurno" runat="server" Text="Nuevo turno: "></asp:Label>
                            <br />

                            <asp:TextBox ID="tbNuevoDia" runat="server" Text="Día"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="nuevoDiaValidate" ControlToValidate="tbNuevoDia" ToolTip="Día no válido" ErrorMessage="Día no válido" 
                                ValidationExpression="^(Lunes|Martes|Miercoles|Miércoles|Jueves|Viernes)$" CssClass="failureNotification" runat="server">*</asp:RegularExpressionValidator>
                            <br />

                            <asp:TextBox ID="tbNuevaHoraI" runat="server" Text="hh:mm"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="nuevaHoraIValidate" runat="server" ValidationExpression="^[0-2][0-9]\:[0-5][0-9]$" ControlToValidate="tbNuevaHoraI" 
                                CssClass="failureNotification" ErrorMessage="Hora no válida" ToolTip="Hora no válida">*</asp:RegularExpressionValidator>
                            <br />

                            <asp:TextBox ID="tbNuevaHoraF" runat="server" Text="hh:mm"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="nuevaHoraFValidate" runat="server" ValidationExpression="^[0-2][0-9]\:[0-5][0-9]$" ControlToValidate="tbNuevaHoraF" 
                                CssClass="failureNotification" ErrorMessage="Hora no válida" ToolTip="Hora no válida">*</asp:RegularExpressionValidator>
                            <br />

                            <asp:TextBox ID="tbNuevaUbic" runat="server" Text="Ubicación"></asp:TextBox>
                            <br />

                            <asp:Button ID="btConfirmaNuevo" runat="server" Text="Añadir"
                                style="width:120px; margin-left:5px" onclick="btConfirmaNuevo_Click"/>
                            <br />
                            <asp:Button ID="btCancelaNuevo" runat="server" Text="Cancelar"
                                style="width:120px; margin-left:5px" onclick="btCancelaNuevo_Click"/>
                        </div>                                                                    
                                               
                    </div>
            </fieldset>
          </div>
</asp:Content>
