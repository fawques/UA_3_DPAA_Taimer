using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer.TabPeticiones
{
    public partial class Peticiones : System.Web.UI.Page
    {

        protected void Page_PreInit(object sender, EventArgs e) {
            if (Session["usuario"] == null)
                Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botNuevaPeticion_Click(object sender, EventArgs e)
        {
            // Lleva a la página de hacer una nueva petición
            Response.Redirect("~/TabPeticiones/NuevaPeticion.aspx");
        }
    }
}