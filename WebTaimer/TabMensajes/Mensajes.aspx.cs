using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taimer;

namespace WebTaimer.TabMensajes
{
    public partial class Mensajes : System.Web.UI.Page
    {
        List<User> usuarios;

        protected void Page_Init(object sender, EventArgs e)
        {
            listaUsuarios.AutoPostBack = true;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Añadir todos los usuarios a la lista...
            }
        }
    }
}