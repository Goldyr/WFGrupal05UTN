using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PR3TP05
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //Limpio las textbox
            txtbx_DescripcionSucursal.Text = txtbx_DireccionSucursal.Text = txtbx_NombreSucursal.Text = null;
        }
    }
}