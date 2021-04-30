using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

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

        public SqlDataReader Traer_datos(string consulta)
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consulta, conexion);

            cmd.CommandType = CommandType.Text;

            SqlDataReader dr = cmd.ExecuteReader();

            //conexion.Close();
            return dr;
        }

    }
}