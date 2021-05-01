using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PR3TP05
{
    public partial class ListarSucursal : System.Web.UI.Page
    {
        private Sucursal _sucursal = new Sucursal();

        protected void Page_Load(object sender, EventArgs e)
        {
            String consulta = "SELECT Id_Sucursal as 'ID Sucursal', NombreSucursal as 'Nombre sucursal', " +
            "DescripcionSucursal as 'Descripcion', Provincia.DescripcionProvincia as 'Provincia' , DireccionSucursal as 'Direccion' " +
            "FROM Sucursal " +
            "INNER JOIN Provincia ON Provincia.Id_Provincia = Sucursal.Id_ProvinciaSucursal";

            if (!IsPostBack) _sucursal.CargarEnTabla(grdDatos, consulta); 
        }
    }
}