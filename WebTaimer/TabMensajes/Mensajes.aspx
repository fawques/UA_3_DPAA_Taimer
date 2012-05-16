﻿<%@ Page Title="Mensajes" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
CodeBehind="Mensajes.aspx.cs" Inherits="WebTaimer.TabMensajes.Mensajes" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

<style type="text/css">


div.mensaje1 
{
     overflow: visible;
     float: right;
     border: 5px double #8be0a7;
     width: 600px;
     /*height: 160px;*/
     /* margin: 0 auto; */
     background-color: #e5f7ea;
     border-radius: 10px;
     margin: 4px;
}

div.mensaje 
{
    <!--overflow: visible;-->
    color: #4e504f;
    margin-left: 5px;
    /*height: 137px;*/
    width: 590px;
    margin-right: 0px;
    margin-top: 5px;
    margin-bottom: 5px;
}

div.mensaje2
{
    overflow: visible;
    float: left;
    border: 5px double #8bd7e0;
    width: 600px;
    /*height: 160px;*/
    margin: 0 auto;
    background-color: #e5f4f7;
    border-radius: 10px;
    margin: 4px;
}

label.mensaje 
{
    margin-left: 40px;
    overflow: visible;
}

p.coment
{
    overflow: visible;
    color: #8c7052;
    width: 590px;
    font-style:italic;
    float: right;
    margin-right:5px;
    text-align: right;
}

/* FIN DEL CSS */

        #TextArea1
        {
            z-index: 1;
            left: 513px;
            top: 583px;
            position: absolute;
            height: 122px;
            width: 592px;
        }
        .style1
        {
            width: 208px;
        }

</style>

</asp:Content>


<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Mensajes
        <asp:Label ID="labelConversador" runat="server"></asp:Label>
        <asp:Label ID="labelEmail" runat="server" Visible="False"></asp:Label>
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
            .mensaje
            {
                width: 467px;
            }
            </style>

        <div id="divPanelIzquierdo" 
        style="width:200px; float: left; height: 623px;">
        
        <fieldset class="asig" style="width: 160px; height: 540px">
            <legend>Usuarios</legend>
            <!--<div style="width:160px; float:left">-->
                        <asp:TextBox ID="textboxFiltro" runat="server" Width="125px" style="float: left"
                placeholder="Buscar usuario..." ontextchanged="textboxFiltro_TextChanged"></asp:TextBox>
                        
                        <asp:Button ID="botonBuscar" runat="server" Text="B" Width="25px" 
                style="float: left; margin-left:5px" onclick="botonBuscar_Click" />
                        
                        <asp:ListBox ID="listaUsuarios" runat="server" Height="398px" 
                Width="160px" style="margin: 0 auto; float:left; margin-top:5px" 
                onselectedindexchanged="listaUsuarios_SelectedIndexChanged">
                        </asp:ListBox>

                <asp:Button ID="botonVerPerfil" runat="server" Text="Ver perfil" width="160px" style="float:left; margin-top:5px"></asp:Button>

                <asp:Button ID="botonBorrarMensajes" runat="server" Text="Borrar mensajes" width="160px" style="float:left; margin-top:5px"></asp:Button>
                    </fieldset>
            <!--</div>-->
        </div>

        <div id="divPanelContenido" style="width:715px; float: left; margin-left:5px; overflow: visible">
                <fieldset class="envMens" style="width: 687px; height:155px">
                        <legend>Enviar mensaje</legend>
                        <div style="height: 150px; width: 687px; margin-top:-15px">
                            <!--<textarea  id="TextArea1" name="S1" style="resize: none; position:relative; left:0px; top:0px; margin-top:10px"></textarea>&nbsp;-->
                            <asp:TextBox ID="textoMensaje" TextMode="MultiLine" runat="server" 
                                Height="145px" Width="622px" style="resize: none; position:relative; left:0px; top:0px; margin-top:0px"></asp:TextBox>
                            <asp:Button ID="botonEnviar" runat="server" Width="50px" onclick="botonEnviar_Click" style="margin-left:5px; margin-top:-13px"
                                Text="Enviar" />
                                                                
                                </div>
                </fieldset>


                <div style="overflow: visible" > 

                    <% = conversacion %>

                </div>
                <!--<hr style="float:left"/>-->
                        
       </div>

    </asp:Content>
