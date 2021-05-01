using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;


namespace PR3TP05
{
    public class Conexion
    {
        private string ruta = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = BDSucursales; Integrated Security = True";

        public int AgregarSucursal (string consulta)
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consulta, conexion);

            int FilasAfectadas = cmd.ExecuteNonQuery();
            
            //conexion.Close();
            return FilasAfectadas;
        }

        public void Cargarddl( DropDownList ddlProvincia)
        {          
            String consulta = "Select * from Provincia";

            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection(ruta);
            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);
            adaptador.Fill(ds, "Provincia");
            ddlProvincia.DataSource = ds.Tables["Provincia"];
            ddlProvincia.DataTextField = "DescripcionProvincia";
            ddlProvincia.DataValueField = "Id_Provincia";
            ddlProvincia.DataBind();
            cn.Close();
        }

    }
}