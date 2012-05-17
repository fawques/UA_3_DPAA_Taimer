using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taimer;

namespace WebTaimer.TabPerfil
{
    public partial class EditarPerfil : System.Web.UI.Page
    {       
        protected void Page_PreInit(object sender, EventArgs e) {
            if (Session["usuario"] == null)
                Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");                    
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                User u = ((User)Session["usuario"]);
                UserName.Text = u.Nombre;
                Email.Text = u.Email;
                Titulacion.Text = u.Titulacion;
                Curso.SelectedIndex = u.Curso - 1;

                if (u.Imagen != "" && u.Imagen != null)
                    imagenAvatar.ImageUrl = "~/Images/" + u.Imagen;
                else
                    imagenAvatar.ImageUrl = "~/Images/default.jpg";

                FrasePersonal.Text = u.Frase;
            }
        }

        protected void botonModificarDatos_Click(object sender, EventArgs e)
        {                
            User user = (User)Session["usuario"];
            string name=UserName.Text, titulacion=Titulacion.Text, email=Email.Text;
            string pass=PasswordAnterior.Text, pass2=NuevoPassword.Text, pass2Check=ConfirmarNuevoPassword.Text;
            string frase = FrasePersonal.Text, url="C:\\Taimer\\WebTaimer\\Images\\";
            int curso = Curso.SelectedIndex + 1;
            bool error = false, cambio = false;

            if (name != "")
            {
                user.Nombre = name;
                cambio = true;
            }

            if (titulacion != "")
            {
                user.Titulacion = titulacion;
                cambio = true;
            }

            if (email != "")
            {                
                EmailValidation.Validate();

                if (!EmailValidation.IsValid)                                  
                    error = true;
               
                else
                {
                    user.Email = email;
                    cambio = true;
                }
            }
            
            if (pass != "")
            {
                if (pass != user.Password)
                {
                    PasswordRequired.IsValid = false;
                    error = true;
                }
                else if (pass2 != "")
                {
                    NuevoPassValidator.Validate();
                    if (NuevoPassValidator.IsValid)
                    {
                        if (pass2 != pass2Check)
                        {
                            ConfirmarNuevoPassRequiered.IsValid = false;
                            error = true;
                        }
                        else
                        {
                            user.Password = pass2;
                            cambio = true;
                        }
                    }
                    else
                        error = true;
                }
                else
                {                    
                    NuevoPassRequiered.IsValid = false;
                    error = true;
                }
            }

            if (curso != user.Curso)
            {
                user.Curso = curso;
                cambio = true;
            }

            if (frase != "")
            {
                user.Frase = frase;
                cambio = true;
            }

            if (cargarArchivo.HasFile)
            {
                user.InsertaFoto(cargarArchivo.FileName);
                url += user.Imagen;
                cargarArchivo.SaveAs(url);                
                imagenAvatar.ImageUrl = "~/Images/" + user.Imagen;                
                cambio = true;
            }

            if (!error && cambio)
            {
                user.Modificar();                
                Session.Remove("usuario");
                Session.Add("usuario", user);
                Response.Redirect("~/TabPerfil/VerPerfil.aspx");
            }
        }

        protected void botonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TabPerfil/VerPerfil.aspx");
        }
    }
}