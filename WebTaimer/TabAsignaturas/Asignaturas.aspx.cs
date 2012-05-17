using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer.TabAsignaturas
{
    public partial class Asignaturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");

            ListAct.AutoPostBack = true;
        }
        protected void botNuevoComentario_Click(object sender, EventArgs e)
        {
            // Lleva a la página de crear comentarios
            Response.Redirect("~/TabAsignaturas/Comentar.aspx");
        }
    }
}