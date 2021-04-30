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
            if(IsPostBack == false)
            {
                string consulta2 = "select * from Provincia";
                SqlDataReader dr = conexion.Traer_datos(consulta2);
          
                //ddl_ProvinciaSucursal.DataTextField = "DescripcionProvincia";
                //ddl_ProvinciaSucursal.DataValueField = "Id_Provincia";

                while (dr.Read())
                {
                    //ddl_ProvinciaSucursal.Items.Add(dr["DescripcionProvincia"];

                    //ddl_ProvinciaSucursal.Items.Insert(0, ListItem("[Id_Provincia]"), ""));
                    //ddl_ProvinciaSucursal.Items.Insert(0, new ListItem("[DescripcionProvincia]", "0"));

                    ddl_ProvinciaSucursal.DataTextField = "DescripcionProvincia";
                    ddl_ProvinciaSucursal.DataValueField = "Id_Provincia";
                    //ddl_ProvinciaSucursal.DataTextField = "DescripcionProvincia";
                   
                    ddl_ProvinciaSucursal.DataBind();
                    lblMensaje.Text = "Cambio";
                }

                ddl_ProvinciaSucursal.DataBind();

            }

        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string Nombre = txtbx_NombreSucursal.Text.Trim();
            string Descripcion = txtbx_DescripcionSucursal.Text.Trim();
            string Provincia = ddl_ProvinciaSucursal.SelectedValue; 
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