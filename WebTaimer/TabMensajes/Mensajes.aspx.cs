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

            if (usuarios == null)
                cargarTodosUsuarios();

            //if (conversacion == null)
            //{
            //    textoMensaje.Enabled = false;
            //    botonEnviar.Enabled = false;
            //    conversacion = "<div style=\"color: #000000; float:center; border: 5px double #117777; background-color: #118888; overflow: visible; border-radius: 10px; margin: 4px; text-align:center \" >Selecciona un usuario para ver sus mensajes.</div>";
            //}

            //if (listamensajes == null)
            //    cargarTodosMensajes();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string dni = Request.QueryString["dni"];

            if (dni == null)
            {
                textoMensaje.Enabled = false;
                botonEnviar.Enabled = false;
                conversacion = "<div style=\"color: #000000; float:center; border: 5px double #117777; background-color: #118888; overflow: visible; border-radius: 10px; margin: 4px; text-align:center \" >Selecciona un usuario para ver sus mensajes.</div>";
            }
            else
            {
                receptor = Taimer.User.GetUserByDNI(dni);
                LoadUser();
            }
        }


        // Selecciona un usuario al hacer clic sobre él en la lista
        protected void SelectUser(string indice)
        {
            receptor = Taimer.User.GetUserByDNIQuick(indice);

            labelConversador.Text = " - Conversación con " + receptor.Nombre;
            labelDNI.Text = receptor.DNI;

            conversacion = cargarConversacion();
            UpdatePanelConversacion.Update();
            UpdatePanelNombreConversador.Update();
        }


        // Selecciona un usuario al hacer clic sobre él en la lista
        protected void LoadUser()
        {
            labelConversador.Text = " - Conversación con " + receptor.Nombre;
            labelDNI.Text = receptor.DNI;

            conversacion = cargarConversacion();
            UpdatePanelConversacion.Update();
            UpdatePanelNombreConversador.Update();
        }


        // Carga la conversación (la "dibuja") del usuario seleccionado
        protected string cargarConversacion()
        {
            textoMensaje.Enabled = true;
            botonEnviar.Enabled = true;

            string cont = "";

            listamensajes = Taimer.Mensaje.getConversacionQuick((User)Session["usuario"], receptor);

            string dnipropio = ((User)Session["usuario"]).DNI;
            string dniotro = receptor.DNI;

            if (listamensajes.Count == 0)
            {
                cont = "<div style=\"color: #000000; float:center; border: 5px double #117777; background-color: #118888; overflow: visible; border-radius: 10px; margin: 4px; text-align:center \" >No tienes mensajes con " + receptor.Nombre + ".</div>";
            }
            else
            {
                foreach (Mensaje m in listamensajes)
                {
                    if (m.Receptor.DNI == dnipropio)      // Mensaje del "otro"
                    {
                        if (m.Leido)
                            cont += "<div class=\"mensajedeotro\">";
                        else
                        {
                            cont += "<div class=\"mensajedeotronuevo\">";
                            m.MarcarComoLeido();
                        }
                        cont += "<p class=\"coment\">Enviado por " + m.Emisor.Nombre + " - " + m.FechaToString() + "</p><p class=\"texto\">" + m.Texto + "</p></div>";
                    }
                    else if (m.Emisor.DNI == dnipropio)   // Mensaje propio
                    {
                        cont += "<div class=\"mensajepropio\">";
                        cont += "<p class=\"coment\">Enviado por " + m.Emisor.Nombre + " - " + m.FechaToString() + "</p><p class=\"texto\">" + m.Texto + "</p></div>";
                    }
                }
            }

            if(cont == "")
                cont = "<div style=\"color: #000000; float:center; border: 5px double #117777; background-color: #118888; overflow: visible; border-radius: 10px; margin: 4px; text-align:center \" >No tienes mensajes con " + receptor.Nombre + ".</div>";

            return cont;
        }


        // Detecta si se ha cambiado el usuario seleccionado en la lista
        protected void listaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indicelista = listaUsuarios.SelectedValue;
            SelectUser(indicelista);
            //UpdatePanelConversacion.Update();       // EUREKA
        }


        // Enviar mensaje
        protected void botonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                receptor = Taimer.User.GetUserByDNIQuick(labelDNI.Text);
                Mensaje mensaje = new Mensaje(100, textoMensaje.Text, ((User)Session["usuario"]), receptor, DateTime.Now, false);
                mensaje.Agregar();
                textoMensaje.Text = "";
                SelectUser(receptor.DNI);
            }
            catch(Exception ex)
            {
                labelConversador.Text = ex.Message;
                UpdatePanelNombreConversador.Update();
            }
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

            int i = 0;

            foreach (User u in usuarios)
            {
                listaUsuarios.Items.Add(u.Nombre);
                listaUsuarios.Items[i].Value = u.DNI;
                i++;
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

        protected void botonVerPerfil_Click(object sender, EventArgs e)
        {
            
        }

        //protected void cargarTodosMensajes()
        //{
        //    listamensajes = Taimer.Mensaje.getMensajesUsuario((User)Session["usuario"]);
        //}
    }
}