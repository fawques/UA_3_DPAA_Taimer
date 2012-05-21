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

        protected void Page_PreInit(object sender, EventArgs e) {
            if (Session["usuario"] == null)
                Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.QueryString["user"];
            
            if (email != null && email != ((User)Session["usuario"]).Email)
            {
                Taimer.User user = Taimer.User.GetUserByEmail(email);
                if (user != null)
                {
                    botEditarPerfil.Visible = false;

                    labelNombreUsuario.Text = user.Nombre;
                    labelTitulacion.Text = user.Titulacion;
                    labelCurso.Text = user.Curso.ToString();
                    labelDNI.Text = user.DNI;
                    labelEmail.Text = user.Email;
                    labelFrasePersonal.Text = user.Frase;

                    if (user.Imagen != "" && user.Imagen != null)
                        imagenAvatar.ImageUrl = "~/Images/" + user.Imagen;
                    else
                        imagenAvatar.ImageUrl = "~/Images/default.jpg";
                }

                else
                {
                    divAvatar.Visible = false;
                    divDatos.Visible = false;
                    encabezado.InnerText = "El usuario no existe";
                }
                
            }

            else if(email==((User)Session["usuario"]).Email || email==null)
            {
                botEnviarMensaje.Visible = false;
                botVerHorarios.Visible = false;
                User user = ((User)Session["usuario"]);

                labelNombreUsuario.Text = user.Nombre;
                labelTitulacion.Text = user.Titulacion;
                labelCurso.Text = user.Curso.ToString();
                labelDNI.Text = user.DNI;
                labelEmail.Text = user.Email;
                labelFrasePersonal.Text = user.Frase;

                if (user.Imagen != "" && user.Imagen != null)                
                    imagenAvatar.ImageUrl = "~/Images/" + user.Imagen;                
                else                                    
                    imagenAvatar.ImageUrl = "~/Images/default.jpg";                
            }            
        }

        protected void botEditarPerfil_Click(object sender, EventArgs e)
        {
            // Lleva a la página de editar perfil
            Response.Redirect("~/TabPerfil/EditarPerfil.aspx");
        }

        protected void botEnviarMensaje_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TabMensajes/Mensajes.aspx?usuario=" + labelEmail.Text);
        }

        protected void botVerHorarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TabHorariosPublicos/HorariosPublicos.aspx?usuario=" + labelEmail.Text);
        }
    }
}