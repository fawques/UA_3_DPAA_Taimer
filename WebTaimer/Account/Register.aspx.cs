using Taimer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer.Account
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btReg_Click(object sender, EventArgs e) {
            string nom = UserName.Text;
            string dni = DNI.Text;
            string mail = Email.Text;
            string pass = Password.Text;
            int curso = 1;
            try {
                curso = int.Parse(Curso.SelectedItem.Value);
            }
            catch {

            }
            string titulacion = Titulacion.Text;
            User user = new User(nom, dni, mail, pass, curso, titulacion);

            //user.Agregar();
        }

    }
}
