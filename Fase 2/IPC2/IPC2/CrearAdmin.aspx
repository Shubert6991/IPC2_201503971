<%@ Page Title="CrearAdministrador" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearAdmin.aspx.vb" Inherits="IPC2.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <asp:Button id="CrearAdmin"
                text="Crear Administrador de Plataforma"
                OnClick="CrearAdmin_Click"
                runat="server"
                />
</asp:Content>
