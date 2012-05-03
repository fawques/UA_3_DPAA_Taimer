using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer.TabHorarios
{
    public partial class Horarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonMasInformacion_Click(object sender, EventArgs e)
        {
            // Lleva a la página de asignaturas
            Response.Redirect("~/TabAsignaturas/Asignaturas.aspx");
        }

        protected void Comentar_Click(object sender, EventArgs e) {
             
            Response.Redirect("~/TabAsignaturas/Asignaturas.aspx");
        }

        protected void botCambiarNombre_Click(object sender, EventArgs e)
        {
            // Debería mostrar lo que se conocía en VB como InputBox.
        }

        protected void botBorrarHorario_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de confirmación.
        }
    }
}