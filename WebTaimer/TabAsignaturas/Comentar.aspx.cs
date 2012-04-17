using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer.TabAsignaturas
{
    public partial class Comentar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botEnviarComentario_Click(object sender, EventArgs e)
        {
            // Lleva a la página de asignaturas
            Response.Redirect("~/TabAsignaturas/Asignaturas.aspx");
        }

        protected void botNoEnviar_Click(object sender, EventArgs e)
        {
            // Lleva a la página de asignaturas
            Response.Redirect("~/TabAsignaturas/Asignaturas.aspx");
        }
    }
}