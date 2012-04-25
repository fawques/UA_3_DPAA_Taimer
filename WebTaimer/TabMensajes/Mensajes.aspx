<%@ Page Title="Mensajes" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
CodeBehind="Mensajes.aspx.cs" Inherits="WebTaimer.TabMensajes.Mensajes" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">

        #TextArea1
        {
            z-index: 1;
            left: 520px;
            top: 588px;
            position: absolute;
            height: 45px;
            width: 606px;
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
    </h2>

    <table style="width: 100%;">
        <tr>
            <td class="style1">
                <asp:Panel ID="panelConversacion" runat="server" GroupingText="Usuarios">
                    <asp:ListBox ID="listaUsuarios" runat="server"
        
    style="z-index: 1; left: 0px; top: 0px; position: relative; height: 400px; width: 180px;">
                    </asp:ListBox>
                    <br />
                    <br />
                    <asp:Button ID="botonConversar" runat="server" Text="Conversar" Width="87px" />
                    <asp:Button ID="botonVerPerfil" runat="server" Text="Ver perfil" Width="87px"/>
                </asp:Panel>
            
            </td>
            <td>
                <asp:Panel ID="panelMensajes" runat="server" GroupingText="Conversación">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <textarea ID="TextArea1" cols="20" name="S1" rows="2" style="z-index: 1; left: 0px; top: 0px; position: relative"></textarea><br />
                </asp:Panel>
            </td>
        </tr>
    </table>

    </asp:Content>
