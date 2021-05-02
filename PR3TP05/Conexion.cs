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
        protected string s_ruta;

        public Conexion()
        {
            s_ruta = "Data Source=localhost\\MSSQLSERVER2;Initial Catalog = BDSucursales; Integrated Security = True";
        }

        protected DataSet ConsultaDataSet(string consulta)    // Metodo para hacer consultas
        {
            SqlConnection Cn_V = new SqlConnection(s_ruta);
            Cn_V.Open();
            SqlCommand cmd = new SqlCommand(consulta, Cn_V);
            SqlDataAdapter adapter_V_local = new SqlDataAdapter(cmd);
            DataSet ds_V = new DataSet();
            adapter_V_local.Fill(ds_V);
            Cn_V.Close();
            return ds_V;
        }

        protected SqlDataReader Traer_datos(string consulta)
        {
            SqlConnection conexion = new SqlConnection(s_ruta);
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consulta, conexion);

            cmd.CommandType = CommandType.Text;

            SqlDataReader dr = cmd.ExecuteReader();

            //conexion.Close();
            return dr;
        }

        virtual protected void CargarDdl(DropDownList ddl, string consulta)
        {
       
        }


    }
}