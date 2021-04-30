<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="PR3TP05.AgregarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hlink_AgregarSucursal" runat="server" NavigateUrl="AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
            <asp:HyperLink ID="hlink_ListarSucursal" runat="server" NavigateUrl="ListarSucursal.aspx">Listar Sucursal</asp:HyperLink>
            <asp:HyperLink ID="hlink_EliminarSucursal" runat="server" NavigateUrl="EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
        </div>

        <h2>
            GRUPO NUMERO no me acuerdo
        </h2>
        <h3>
            Agregar Sucursal
        </h3>
        <div>
            <div id="NomSuc">
                <p>Nombre Sucursal:</p>
                <asp:TextBox ID="txtbx_NombreSucursal" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_Nombre" runat="server" ControlToValidate="txtbx_NombreSucursal">Ingresar nombre valido</asp:RequiredFieldValidator>
            </div>
            <div id="DescSuc">
                <p>Descripcion:</p>
                <asp:TextBox ID="txtbx_DescripcionSucursal" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_Descripcion" runat="server" ControlToValidate="txtbx_DescripcionSucursal">Ingresar descripcion valida</asp:RequiredFieldValidator>
            </div>
            <div id="ProvSuc">
                <p>Provincia:</p>
                <asp:DropDownList ID="ddl_ProvinciaSucursal" runat="server"></asp:DropDownList>
            </div>
            <div id="DirSuc">
                <p>Direccion:</p>
                <asp:TextBox ID="txtbx_DireccionSucursal" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_Direccion" runat="server" ControlToValidate="txtbx_DireccionSucursal">Ingresar una direccion valida</asp:RequiredFieldValidator>
            </div>
            <div id="BtnAceptar">
                <asp:Button ID="btn_Aceptar" runat="server" Text="Aceptar" OnClick="btn_Aceptar_Click" />
            </div>
            <asp:Label ID="lbl_AgregadoExito" runat="server" Text="La sucursal se ha agregado con exito" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
