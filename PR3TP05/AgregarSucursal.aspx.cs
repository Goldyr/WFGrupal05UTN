using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace PR3TP05
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string Nombre = txtbx_NombreSucursal.Text.Trim();
            string Descripcion = txtbx_DescripcionSucursal.Text.Trim();
            string Provincia = ddl_ProvinciaSucursal.SelectedValue; //???????????
            string Direccion = txtbx_DireccionSucursal.Text.Trim();

            string consulta = $"insert into Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) values( '{Nombre}', '{Descripcion}', '{Provincia}', '{Direccion}')";

            
            int Filas = conexion.AgregarSucursal(consulta);

            if(Filas == 0)
            {
                lblMensaje.Text = "No se agrego";
                //no se agrego
            }
            else
            {
                lblMensaje.Text = "Se agrego";
                //se agrego
            }

            //Limpio las textbox
            Limpiar();           
            //txtbx_DescripcionSucursal.Text = txtbx_DireccionSucursal.Text = txtbx_NombreSucursal.Text = null;
        }

        public void Limpiar()
        {
            txtbx_DescripcionSucursal.Text = txtbx_DireccionSucursal.Text = txtbx_NombreSucursal.Text = null;

        }
    }
}