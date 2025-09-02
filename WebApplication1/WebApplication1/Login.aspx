<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox> 
    <br />
    <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
    <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" class="btn btn-outline-success " OnClick="btnEnviar_Click" />
</asp:Content>
