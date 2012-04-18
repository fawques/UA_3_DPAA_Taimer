<%@ Page Title="Mensajes" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
CodeBehind="Mensajes.aspx.cs" Inherits="WebTaimer.TabMensajes.Mensajes" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">

        #TextArea1
        {
            z-index: 1;
            left: 231px;
            top: 251px;
            position: absolute;
            height: 16px;
            width: 617px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Mensajes
    </h2>
    <p>
        <asp:Label ID="labelConversacionCon" runat="server" Text="Conversación con:" 
        style="z-index: 1; left: 45px; top: 0px; position: relative;"
            Font-Size="Medium"></asp:Label>
            </p>
            <p>
        <asp:ListBox ID="ListBox1" runat="server" Width="200px"
        style="z-index: 1; left: 12px; top: 0px; position: relative; height: 400px;">
        </asp:ListBox>
            </p>
            <p>
                    <asp:Button ID="botNuevaConversacion" runat="server"
        style="z-index: 1; left: 25px; top: 0px; position: relative; height: 25px; width: 175px"
            Text="Nueva conversación" />
        <textarea id="TextArea1" name="S1" 
                        
                        style="resize: none; z-index: 1; left: 50px; top: 3px; position: relative"></textarea>
                        <asp:Button ID="botEnviar" runat="server" style="resize: none; z-index: 1; left: 55px; top: 0px; position: relative" Text="Enviar" />
    </p>
</asp:Content>
