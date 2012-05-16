using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer.TabPeticiones
{
    public partial class NuevaPeticion : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e) {
            if (Session["usuario"] == null)
                Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botCrearPeticion_Click(object sender, EventArgs e)
        {
            // Vuelve a la página de peticiones
            Response.Redirect("~/TabPeticiones/Peticiones.aspx");
        }

        protected void botCancelar_Click(object sender, EventArgs e)
        {
            // Vuelve a la página de peticiones
            Response.Redirect("~/TabPeticiones/Peticiones.aspx");
        }
    }
}