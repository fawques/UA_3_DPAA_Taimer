using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer
{
    public partial class NoLogin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            Session.Add("usuario",textboxUsuario.Text);
            Response.Redirect("~/TabInicio/ConLogin.aspx");
        }
    }
}