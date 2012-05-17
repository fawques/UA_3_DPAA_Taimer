using System;
//using System.Collections;
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
        User receptor;
        List<Mensaje> listamensajes;
        protected string conversacion;

        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");
            listaUsuarios.AutoPostBack = true;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count > 0)
            {
                if (!IsPostBack)
                {
                    cargarTodosUsuarios();
                }
            }
        }


        // Selecciona un usuario al hacer clic sobre él en la lista
        protected void SelectUser(int indice)
        {
            cargarTodosUsuarios();

            labelConversador.Text = "- Conversación con " + usuarios[indice].Nombre;
            receptor = usuarios[indice];
            labelEmail.Text = receptor.Email;   // Solución que roza los límites de la cutrez

            conversacion = cargarConversacion();

            receptor = usuarios[indice];
        }


        // Carga la conversación (la "dibuja") del usuario seleccionado
        protected string cargarConversacion()
        {
            string cont = "";
            listamensajes = Taimer.Mensaje.getConversacion((User)Session["usuario"], receptor);

            if (listamensajes.Count == 0)
            {
                cont = "<div style=\"color: #000000; float:center; border: 5px double #117777; background-color: #118888; overflow: visible; border-radius: 10px; margin: 4px; text-align:center \" >No tienes mensajes con " + receptor.Nombre + ".</div>";
            }
            else
            {
                foreach (Mensaje m in listamensajes)
                {
                    if (m.Emisor.DNI != ((User)Session["usuario"]).DNI)
                    {
                        cont += "<div style=\"color: #000000; float:left; border: 5px double #8bd7e0; background-color: #e5f4f7;";
                    }
                    else
                    {
                        cont += "<div style=\"color: #000000; float:right; border: 5px double #8be0a7; background-color: #e5f7ea;";
                    }

                    cont += "overflow: visible; width:600px; border-radius: 10px; margin: 4px;\" ><p class=\"coment\">Enviado por " + m.Emisor.Nombre + " - " + m.FechaToString() + "</p><p style=\"width:590px; margin-left:5px\">" + m.Texto + "</p></div>";
                }
            }

            return cont;
        }


        // Detecta si se ha cambiado el usuario seleccionado en la lista
        protected void listaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indicelista = listaUsuarios.SelectedIndex;
            SelectUser(indicelista);
            receptor = usuarios[indicelista];
        }


        // Enviar mensaje
        protected void botonEnviar_Click(object sender, EventArgs e)
        {
            receptor = Taimer.User.GetUserByEmail(labelEmail.Text);
            Mensaje mensaje = new Mensaje(100, textoMensaje.Text, ((User)Session["usuario"]), receptor, DateTime.Now, false);
            mensaje.Agregar();
            textoMensaje.Text = "";
        }


        // Carga todos los usuarios de la lista
        protected void cargarTodosUsuarios()
        {
            usuarios = Taimer.User.GetAllUsersExceptoUno(((User)Session["usuario"]).DNI);
            llenarLista();
        }


        // Llena la lista de usuarios (se hayan cargado todos, o con el filtro)
        protected void llenarLista()
        {
            listaUsuarios.DataBind();
            listaUsuarios.Items.Clear();

            foreach (User u in usuarios)
            {
                listaUsuarios.Items.Add(u.Nombre);
            }
        }


        // Carga los usuarios a los que se aplique el filtro
        protected void cargaFiltro(string textofiltro)
        {
            if (textofiltro != null && textofiltro != "")
            {
                usuarios = Taimer.User.GetUsersFiltro(textofiltro, ((User)Session["usuario"]).DNI);
                llenarLista();
            }
            else
                cargarTodosUsuarios();
        }

        // Carga el filtro del TextBox de filtrado
        protected void botonBuscar_Click(object sender, EventArgs e)
        {
            cargaFiltro(textboxFiltro.Text);
        }

        protected void textboxFiltro_TextChanged(object sender, EventArgs e)
        {
            //cargaFiltro(textboxFiltro.Text);
        }
    }
}