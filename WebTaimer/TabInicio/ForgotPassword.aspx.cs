using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;      // Necesario para el envío de e-mails
using Taimer;

namespace WebTaimer.TabInicio
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> listausuarios = new List<User>();
                listausuarios = Taimer.User.GetAllUsers();

                string nombreu = "";
                string passwordu = "";
                string emailu = "";

                bool encontrado = false;

                foreach (User u in listausuarios)   // Busca al usuario en toda la lista
                {
                    if (u.Email == UserName.Text || u.Nombre == UserName.Text)  // Coincide nombre o e-mail
                    {
                        nombreu = u.Nombre;
                        passwordu = u.Password;
                        emailu = u.Email;
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)    // Si no encuentra usuario, lanza excepción
                    throw new Exception("El usuario o dirección de e-mail no existe.");

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                MailMessage mensaje = new MailMessage();

                MailAddress fromAddress = new MailAddress("taimerapp@gmail.com", "Taimer");    // Dirección desde la que se envía y alias
                MailAddress toAddress = new MailAddress(emailu, nombreu);    // Dirección que recibe el e-mail y alias (alias no necesario)
                mensaje.From = fromAddress;
                mensaje.To.Add(toAddress);
                mensaje.Subject = "Recuperación de contraseña de Taimer";   // Asunto
                mensaje.Body = "Hola, " + nombreu + ".\n\nHa solicitado la recuperación de contraseña.\n\nSu contraseña es: " + passwordu;    // Cuerpo del mensaje
                smtpClient.EnableSsl = true;

                smtpClient.Credentials = new System.Net.NetworkCredential("taimerapp@gmail.com", "thisistaimer");    // Usuario y contraseña del correo de Taimer
                smtpClient.Send(mensaje);
            }
            catch (Exception ex)
            {
                // ¿Avisar de que ha fallado?
            }

            Response.Redirect("SinLogin.aspx");     // Después de enviar el e-mail, devuelve a la página de inicio
        }
    }
}