using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taimer;

namespace WebTaimer.TabPerfil
{
    public partial class VerPerfil : System.Web.UI.Page
    {
        string dnibuscado = "00000001A";

        protected void Page_Load(object sender, EventArgs e)
        {
            // Muestra los botones adecuados dependiendo de si es nuestro perfil o no (a medias, sólo compara nombre con "Alberto")
            if (((User)Session["usuario"]).DNI != dnibuscado)
            {
                botEditarPerfil.Visible = false;
            }
            else
            {
                botEnviarMensaje.Visible = false;
                botVerHorarios.Visible = false;
            }

            labelNombreUsuario.Text = ((User)Session["usuario"]).Nombre;
            labelTitulacion.Text = ((User)Session["usuario"]).Titulacion;
            labelCurso.Text = ((User)Session["usuario"]).Curso.ToString();
            labelDNI.Text = ((User)Session["usuario"]).DNI;
            labelEmail.Text = ((User)Session["usuario"]).Email;
        }

        protected void botEditarPerfil_Click(object sender, EventArgs e)
        {
            // Lleva a la página de editar perfil
            Response.Redirect("~/TabPerfil/EditarPerfil.aspx");
        }
    }
}