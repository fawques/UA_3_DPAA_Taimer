<%@ Page Title="Mensajes" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
CodeBehind="Mensajes.aspx.cs" Inherits="WebTaimer.TabMensajes.Mensajes" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">

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
        Mensajes</h2>

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
                        <asp:ListBox ID="ListBox1" runat="server" Height="398px" 
                Width="160px" style="margin: 0 auto;">
                            <asp:ListItem>Usuario 1</asp:ListItem>
                            <asp:ListItem>Usuario 2</asp:ListItem>
                            <asp:ListItem>Usuario 3</asp:ListItem>
                            <asp:ListItem>Usuario 4</asp:ListItem>
                            <asp:ListItem>Usuario 5</asp:ListItem>
                        </asp:ListBox>
                    </fieldset>
        </div>

        <div id="divPanelContenido" style="width:715px; float: left; margin-left:5px">
        <fieldset class="infoAsig" style="width: 687px; height:540px">
                        <legend>Conversación</legend>
                    
                <div style="height: 373px; overflow: auto;  border: 1px solid Gray" > 
                    <div class="mensaje1">
                        <div class="mensaje"><label class="mensaje"><p class="comentario">
                            Enviado a las HH:MM el DD/MM/AAAA</p>
                        blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla 
                        blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla 
                        blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla 
                        blabla blabla blabla blabla blabla blabla blabla blabla
                        </label>
                        </div>
                    </div>

                    <div class="mensaje2">
                        <div class="mensaje"><label class="mensaje"><p class="comentario">
                            Enviado a las HH:MM el DD/MM/AAAA</p>
                        blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla 
                        blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla 
                        blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla 
                        blabla blabla blabla blabla blabla blabla blabla blabla
                        </label>
                        </div>
                    </div>
                    <div class="mensaje1">
                        <div class="mensaje"><label class="mensaje"><p class="comentario">
                            Enviado a las HH:MM el DD/MM/AAAA</p>
                        blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla 
                        blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla 
                        blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla 
                        blabla blabla blabla blabla blabla blabla blabla blabla
                        </label>
                        </div>
                    </div>

                    <div class="mensaje2">
                        <div class="mensaje"><label class="mensaje"><p class="comentario">
                            Enviado a las HH:MM el DD/MM/AAAA</p>
                        blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla 
                        blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla 
                        blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla blabla 
                        blabla blabla blabla blabla blabla blabla blabla blabla
                        </label>
                        </div>
                    &nbsp;</div>
                </div>


                        
                        <div style="height: 150px; width: 658px;">
                            <textarea 
                                id="TextArea1" name="S1" style="resize: none; position:relative; left:0px; top:0px; margin-top:10px"></textarea>
                                
                                <input id="Button1" type="button" value="Enviar" />
                                                                
                                </div>
       </div>

    </asp:Content>
