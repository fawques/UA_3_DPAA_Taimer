using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer.TabPerfil
{
    public partial class VerPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botEditarPerfil_Click(object sender, EventArgs e)
        {
            // Lleva a la página de editar perfil
            Response.Redirect("~/TabPerfil/EditarPerfil.aspx");
        }
    }
}