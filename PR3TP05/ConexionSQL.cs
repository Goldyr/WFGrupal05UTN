using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace PR3TP05
{
    public class ConexionSQL
    {
        private string ruta = "Data Source = localhost\\sqlexpress; Initial Catalog = BDSucursales; Integrated Security = True";

      
        public int Transaccion(string consulta)//Depende la consulta puede insertar, eliminar o modificar la tabla. Devuelve la cantidad de filas afectadas
        {
            SqlConnection conexion = new SqlConnection(ruta);
            
            conexion.Open();
            
            SqlCommand comando = new SqlCommand(consulta, conexion);

            int filasafectadas = comando.ExecuteNonQuery();
            
            conexion.Close();
            
            return filasafectadas;
        }


    }
}