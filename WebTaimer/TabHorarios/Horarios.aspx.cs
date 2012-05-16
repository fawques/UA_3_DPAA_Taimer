using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taimer;
using System.Net;

namespace WebTaimer.TabHorarios
{
    public partial class Horarios : System.Web.UI.Page
    {
        List<Horario> horarios;
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            listaHorarios.AutoPostBack = true;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                horarios = ((User)Session["usuario"]).Horarios;

                listaHorarios.DataBind();
                listaHorarios.Items.Clear();
                foreach (Horario item in horarios)
                {
                    listaHorarios.Items.Add(item.Nombre);
                }
            }
        }

        protected void botonMasInformacion_Click(object sender, EventArgs e)
        {
            // Lleva a la página de asignaturas
            Response.Redirect("~/TabAsignaturas/Asignaturas.aspx");
        }

        protected void Comentar_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/TabAsignaturas/Asignaturas.aspx");
        }

        protected void listaHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            Response.Write("<script>alert(\"has seleccionado " + ((User)Session["usuario"]).Horarios[listaHorarios.SelectedIndex].Nombre + "! \")</script>");


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