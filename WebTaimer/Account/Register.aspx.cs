using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

// Todo está comentado porque he eliminado la basura del CreateUserWizard QUE NO DEJABA TOCAR NADA.

namespace WebTaimer.Account
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }

        /*
        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            //FormsAuthentication.SetAuthCookie(RegisterUser.UserName, false /* createPersistentCookie);*/

            /*
            string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            Response.Write("<script>alert('pene'); </script>");
            if (String.IsNullOrEmpty(continueUrl))
            {
                continueUrl = "~/";
            }
            Response.Redirect(continueUrl);
         }
         */

        // E-mail de bienvenida *****************************
        protected void crearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                MailMessage mensaje = new MailMessage();

                MailAddress fromAddress = new MailAddress("taimerapp@gmail.com", "Taimer");    // Dirección desde la que se envía y alias
                MailAddress toAddress = new MailAddress(Email.Text, UserName.Text);    // Dirección que recibe el e-mail y alias (alias no necesario)
                mensaje.From = fromAddress;
                mensaje.To.Add(toAddress);
                mensaje.Subject = "Bienvenido a Taimer";   // Asunto
                mensaje.Body = "Hola, " + UserName.Text + ". Bienvenido a Taimer.\n\n" +
                               "Aquí están los datos de su nueva cuenta de usuario.\n\n" +
                               "Nombre: " + UserName.Text + "\n" +
                               "Correo electrónico: " + Email.Text + "\n" +
                               "Contraseña: " + Password.Text + "\n" +
                               "DNI: " + DNI.Text + "\n" +
                               "Titulación: " + Titulacion.Text + "\n" +
                               "Curso: " + Curso.Text;
                smtpClient.EnableSsl = true;

                smtpClient.Credentials = new System.Net.NetworkCredential("taimerapp@gmail.com", "thisistaimer");    // Usuario y contraseña del correo de Taimer
                smtpClient.Send(mensaje);

                // ¿Redirigir a una página que diga "Enhorabuena, has creado tu cuenta, revisa tu e-mail, blablabla"?
            }
            catch (Exception ex)
            {
                // ¿Avisar de que ha fallado?
            }
        }

    }
}
