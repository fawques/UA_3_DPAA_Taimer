using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taimer;
using System.Web.UI.HtmlControls;

namespace WebTaimer.TabInicio
{
    public partial class ConLogin : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");
        }

        protected void Page_Load(object sender, EventArgs e) {
            if (Session.Count == 0) {
                Response.Redirect("SinLogin.aspx");
                Response.Write("No estás logeado");
            } else {
                User usuario = (User)Session["usuario"];
                lbBienvenida.Text = "Bienvenido, " + usuario.Nombre;
                nombrePrincipalUser.Text = usuario.Nombre;

                labelMensajesSinLeer.Text = "Tienes " + Taimer.Mensaje.getNunMensajesNoLeidos(usuario).ToString()
                    + " mensaje(s) sin leer.";
                
                if (usuario.Imagen != "" && usuario.Imagen != null)
                    imagenAvatar.ImageUrl = "~/Images/" + usuario.Imagen;
                else
                    imagenAvatar.ImageUrl = "~/Images/default.jpg";

                int totAct = 0;
                HtmlGenericControl li, ul;
                // Actividades del dia
                int i = 0;
                foreach(Horario horario in usuario.Horarios) {

                    //Taimer.dias dia = getTaimerDia("Monday");
                    Taimer.dias dia = getTaimerDia(DateTime.Now.DayOfWeek.ToString());

                    totAct += horario.getTurnosDia(dia).Count;
                    if (i < 3) {
                        li = new HtmlGenericControl("li");
                        li.InnerText = horario.Nombre;
                        listaActPer.Controls.Add(li);

                        ul = new HtmlGenericControl("ul");
                        int count = 0;
                        foreach (Turno turno in horario.getTurnosDia(dia)) {

                            li = new HtmlGenericControl("li");
                            li.InnerText = turno.Actividad.Nombre;
                            ul.Controls.Add(li);
                            count++;
                            if (count == 2) {
                                HtmlGenericControl a = new HtmlGenericControl("a");
                                a.Attributes.Add("href", "../TabHorarios/Horarios.aspx?id=" + i);
                                a.InnerText = " Mas...";
                                li.Controls.Add(a);
                                break;
                            }
                        }
                        listaActPer.Controls.Add(ul);
                        i++;
                    }
                }

                lbActividadesHoy.Text = "Tienes " + totAct + " actividad(es) hoy.";
            }
        }

        protected void botonHorariosPropios_Click(object sender, ImageClickEventArgs e) {
            // Lleva a la página de ver horarios
            Response.Redirect("~/TabHorarios/Horarios.aspx");
        }

        protected void botonAsignaturas_Click(object sender, ImageClickEventArgs e) {
            // Lleva a la página de asignaturas
            Response.Redirect("~/TabAsignaturas/Asignaturas.aspx");
        }

        protected void botonHorariosPublicos_Click(object sender, ImageClickEventArgs e) {
            // Lleva a la página de ver horarios públicos
            Response.Redirect("~/TabHorariosPublicos/HorariosPublicos.aspx");
        }

        protected void botonMensajes_Click(object sender, ImageClickEventArgs e) {
            // Lleva a la página de mensajería
            Response.Redirect("~/TabMensajes/Mensajes.aspx");
        }

        protected void botonActividades_Click(object sender, ImageClickEventArgs e) {
            // Lleva a la página de ver actividades personales
            Response.Redirect("~/TabActividades/Actividades.aspx");
        }

        protected void botonPerfil_Click(object sender, ImageClickEventArgs e) {
            // Lleva a la página de ver horarios públicos
            Response.Redirect("~/TabPerfil/VerPerfil.aspx");
        }

        private Taimer.dias getTaimerDia(string day) {
            Taimer.dias dia;
            switch (day) {
                case "Monday":
                    dia = Taimer.dias.L;
                    break;
                case "Tuesday":
                    dia = Taimer.dias.M;
                    break;
                case "Wednesday":
                    dia = Taimer.dias.X;
                    break;
                case "Thursday":
                    dia = Taimer.dias.J;
                    break;
                case "Friday":
                    dia = Taimer.dias.V;
                    break;
                case "Saturday":
                    dia = Taimer.dias.S;
                    break;
                case "Sunday":
                    dia = Taimer.dias.D;
                    break;
                default:
                    dia = Taimer.dias.L;
                    break;
            }
            return dia;
        }
    }
}