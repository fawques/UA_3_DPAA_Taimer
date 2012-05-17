using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e) {


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["nuevo"] != null)
            {
                NuevoUsuarioOK.Visible = true;
            }
        }

        protected void BotAceptar_Click(object sender, EventArgs e)
        {
            //NuevoUsuarioOK.Visible = false; --> con redirect quita los parámetros de la url
            Response.Redirect("./SinLogin.aspx");
        }
    }
}
