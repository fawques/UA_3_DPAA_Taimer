using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer.TabInicio
{
    public partial class ConLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonHorariosPropios_Click(object sender, EventArgs e)
        {
            // Lleva a la página de ver horarios
            Response.Redirect("~/TabHorarios/Horarios.aspx");
        }

        protected void botonHorariosPublicos_Click(object sender, EventArgs e)
        {
            // Lleva a la página de ver horarios públicos
            Response.Redirect("~/TabHorariosPublicos/HorariosPublicos.aspx");
        }

        protected void botonMatricula_Click(object sender, EventArgs e)
        {
            // ¿Matrícula? Lleva a la página de asignaturas
            Response.Redirect("~/TabAsignaturas/Asignaturas.aspx");
        }

        protected void botonMensajes_Click(object sender, EventArgs e)
        {
            // Lleva a la página de mensajería
            Response.Redirect("~/TabMensajes/Mensajes.aspx");
        }
    }
}