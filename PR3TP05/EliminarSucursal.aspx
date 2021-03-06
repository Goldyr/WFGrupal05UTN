<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="PR3TP05.EliminarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hlink_AgregarSucursal" runat="server" NavigateUrl="AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
            &nbsp;&nbsp;
            <asp:HyperLink ID="hlink_ListarSucursal" runat="server" NavigateUrl="ListarSucursal.aspx">Listar Sucursal</asp:HyperLink>
            &nbsp;&nbsp;
            <asp:HyperLink ID="hlink_EliminarSucursal" runat="server" NavigateUrl="EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
        &nbsp;<br />
            <br />
            <span class="auto-style1"><strong>Eliminar Sucursales<br />
            <br />
            </strong></span><span class="auto-style2">Ingrese ID sucursal: </span>
            <asp:TextBox ID="txtSucursal_eli" runat="server" TextMode="Number" ValidationGroup="eliminar"></asp:TextBox>
            <span class="auto-style1"><strong>&nbsp;
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" ValidationGroup="eliminar" />
            <br />
            <asp:Label ID="lbl_eliminar" runat="server"></asp:Label>
            </strong></span>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
