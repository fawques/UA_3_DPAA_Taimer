using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taimer;

namespace WebTaimer.TabInicio
{
    public partial class ConLogin : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count == 0)
            {
                Response.Redirect("SinLogin.aspx");
                Response.Write("No estás logeado");
            }
            else
            {
                User usuario = (User)Session["usuario"];
                lbBienvenida.Text = "Bienvenido, " + usuario.Nombre;
            }
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
            // Lleva a la página de asignaturas
            Response.Redirect("~/TabAsignaturas/Asignaturas.aspx");
        }

        protected void botonMensajes_Click(object sender, EventArgs e)
        {
            // Lleva a la página de mensajería
            Response.Redirect("~/TabMensajes/Mensajes.aspx");
        }

        protected void botonActividadesPersonales_Click(object sender, EventArgs e)
        {
            // Lleva a la página de ver actividades personales
            Response.Redirect("~/TabActividades/Actividades.aspx");
        }

        protected void botonPerfil_Click(object sender, EventArgs e)
        {
            // Lleva a la página de ver horarios públicos
            Response.Redirect("~/TabPerfil/VerPerfil.aspx");
        }
    }
}