<%@ Page Title="Asistencia" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Asistencia.aspx.vb" Inherits="IPC2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: Title %>.</h1>
    <body>
        <form id="form1">
            <p>Ingresar Codigo Empleado</p><input  type="text"/>
            <p>Ingresar Hora Entrada</p><input  type="time"/>
            <p>Ingresar Hora Salida</p><input  type="time"/>
            <input  type="submit" value="ingresar"/>
            <asp:Button id="horarios"
                text="Ver Horarios"
                OnClick="horarios_Click"
                runat="server"
                />
        </form>
    </body>
</asp:Content>
