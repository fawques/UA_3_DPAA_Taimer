using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer.TabDescarga
{
    public partial class Descarga : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e) {
            if (Session["usuario"] == null)
                Response.Redirect("~/TabDescarga/DescargaSin.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}