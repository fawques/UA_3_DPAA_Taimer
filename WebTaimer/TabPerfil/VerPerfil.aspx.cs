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
            string email = Request.QueryString["user"];
            
            if (email != null && email != ((User)Session["usuario"]).Email)
            {
                Taimer.User user = Taimer.User.GetUserByEmail(email);
                botEditarPerfil.Visible = false;

                labelNombreUsuario.Text = user.Nombre;
                labelTitulacion.Text = user.Titulacion;
                labelCurso.Text = user.Curso.ToString();
                labelDNI.Text = user.DNI;
                labelEmail.Text = user.Email;
            }

            else if(email==((User)Session["usuario"]).Email || email==null)
            {
                botEnviarMensaje.Visible = false;
                botVerHorarios.Visible = false;

                labelNombreUsuario.Text = ((User)Session["usuario"]).Nombre;
                labelTitulacion.Text = ((User)Session["usuario"]).Titulacion;
                labelCurso.Text = ((User)Session["usuario"]).Curso.ToString();
                labelDNI.Text = ((User)Session["usuario"]).DNI;
                labelEmail.Text = ((User)Session["usuario"]).Email;
            }

            /*if (((User)Session["usuario"]).Email != email && email!="")
            {                
                //user = Taimer.User.GetUserByEmail(email);                
            }
            else
            {                
                //user=(User)Session["usuario"];                
            }
            Response.Write(user.Email);
            if (user == null)
            {
                if ((User)Session["usuario"] == null)
                    Response.Write("NULL");
            }

            else
            {
                labelNombreUsuario.Text = user.Nombre;
                labelTitulacion.Text = user.Titulacion;
                labelCurso.Text = user.Curso.ToString();
                labelDNI.Text = user.DNI;
                labelEmail.Text = user.Email;
            }*/
            
        }

        protected void botEditarPerfil_Click(object sender, EventArgs e)
        {
            // Lleva a la página de editar perfil
            Response.Redirect("~/TabPerfil/EditarPerfil.aspx");
        }
    }
}