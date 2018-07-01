<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pago.aspx.cs" Inherits="WebApplication2.Pago" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirmar Pago</title>
</head>
<body>
    <form id="ConfPago" runat="server">
        <div>
            <h1>Confirmar Pago</h1>
            <h2>Suscripcion</h2>
            <asp:Label runat="server" id="Psusc"></asp:Label>
            <h2>Por Usuarios</h2>
            <asp:Label runat="server" id="pUsers"></asp:Label>
            <asp:Button ID="Confirmar"
                                Text="Confirmar"
                                class="btn btn-default"
                                type="button"
                                OnClick="Confirmar_Click"
                                runat="server"/>
                <asp:Button ID="Cancelar"
                                Text="Cancelar"
                                class="btn btn-default"
                                type="button"
                                OnClick="Cancelar_Click"
                                runat="server"/>
        </div>
    </form>
</body>
</html>
