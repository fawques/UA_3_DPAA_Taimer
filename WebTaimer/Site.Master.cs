using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cerrar_Sesion(object sender, EventArgs e)
        {
            Session.Abandon();
        }

        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e) {
            //Response.Write("<script>alert(\"Salir!\")</script>");
            Session.Remove("usuario");
            Session.Abandon();
            Response.Redirect("~/TabInicio/SinLogin.aspx");
        }
    }
}
