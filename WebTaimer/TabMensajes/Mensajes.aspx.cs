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
        User receptor;
        List<Mensaje> listamensajes;
        protected string conversacion;

        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");

            listaUsuarios.AutoPostBack = true;
            checkSoloNoLeidos.AutoPostBack = true;

            if (usuarios == null)
                cargarTodosUsuarios();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.QueryString["usuario"];

            if (email == null && labelConversador.Visible == false)
            {
                textoMensaje.Enabled = false;
                botonEnviar.Enabled = false;
                conversacion = "<div style=\"color: #000000; float:center; border: 5px double #117777; background-color: #118888; overflow: visible; border-radius: 10px; margin: 4px; text-align:center \" >Selecciona un usuario para ver sus mensajes.</div>";
            }
            else if (email == ((User)Session["usuario"]).Email)
            {
                textoMensaje.Enabled = false;
                botonEnviar.Enabled = false;
                conversacion = "<div style=\"color: #000000; float:center; border: 5px double #117777; background-color: #118888; overflow: visible; border-radius: 10px; margin: 4px; text-align:center \" >No puedes enviarte mensajes a ti mismo.</div>";
            }
            else
            {
                receptor = Taimer.User.GetUserByEmail(email);

                if (receptor != null)
                {
                    for (int i = 0; i < listaUsuarios.Items.Count; i++)
                    {
                        if (listaUsuarios.Items[i].Text == receptor.Nombre)
                        {
                            listaUsuarios.SelectedIndex = i;
                            break;
                        }
                    }
                    LoadUser();
                }
                else
                {
                    textoMensaje.Enabled = false;
                    botonEnviar.Enabled = false;
                    conversacion = "<div style=\"color: #000000; float:center; border: 5px double #117777; background-color: #118888; overflow: visible; border-radius: 10px; margin: 4px; text-align:center \" >El usuario no existe.</div>";
                }
            }
        }


        // Selecciona un usuario al hacer clic sobre él en la lista
        protected void SelectUser(string indice)
        {
            receptor = Taimer.User.GetUserByDNIQuick(indice);

            HyperLinkConversador.Text = receptor.Nombre;
            HyperLinkConversador.NavigateUrl = "~/TabPerfil/VerPerfil.aspx?user=" + receptor.Email;
            labelDNI.Text = receptor.DNI;
            listaUsuarios.SelectedItem.Text = receptor.Nombre;  // De este modo se limpia el número de mensajes no leídos

            conversacion = cargarConversacion();
            UpdatePanelConversacion.Update();
            UpdatePanelNombreConversador.Update();
        }


        // Selecciona un usuario al hacer clic sobre él en la lista
        protected void LoadUser()
        {
            if (receptor != null)
            {
                
                HyperLinkConversador.Text = receptor.Nombre;
                HyperLinkConversador.NavigateUrl = "~/TabPerfil/VerPerfil.aspx?user=" + receptor.Email;
                labelDNI.Text = receptor.DNI;

                if (receptor.Email != ((User)Session["usuario"]).Email)
                {
                    conversacion = cargarConversacion();
                }
                else
                {
                    conversacion = "<div style=\"color: #000000; float:center; border: 5px double #117777; background-color: #118888; overflow: visible; border-radius: 10px; margin: 4px; text-align:center \" >No puedes enviarte mensajes a ti mismo.</div>";
                }
                
                UpdatePanelConversacion.Update();
                UpdatePanelNombreConversador.Update();
            }
        }


        // Carga la conversación (la "dibuja") del usuario seleccionado
        protected string cargarConversacion()
        {
            textoMensaje.Enabled = true;
            botonEnviar.Enabled = true;
            labelConversador.Visible = true;

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
        }


        // Enviar mensaje
        protected void botonEnviar_Click(object sender, EventArgs e)
        {
            string contenido = textoMensaje.Text;
            string nuevotexto = "";
            
            // Fragmentar las palabras de más de 50 caracteres para no descuadrar el cuadro de mensajes
            int acumuladas = 0;
            for (int i = 0; i < contenido.Length; i++)
            {
                if (contenido[i] == ' ')
                    acumuladas = 0;
                else
                    acumuladas++;

                if (acumuladas > 50)
                {
                    nuevotexto += " ";
                    acumuladas = 1;
                }

                nuevotexto += contenido[i];
            }

            receptor = Taimer.User.GetUserByDNIQuick(labelDNI.Text);
            Mensaje mensaje = new Mensaje(100, nuevotexto, ((User)Session["usuario"]), receptor, DateTime.Now, false);
            mensaje.Agregar();
            textoMensaje.Text = "";
            SelectUser(receptor.DNI);
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
            int noleidos = 0;
            string aux = "";

            if (usuarios != null)
            {
                foreach (User u in usuarios)
                {
                    noleidos = Taimer.Mensaje.getNumMensajesNoLeidosEspecifico((User)Session["usuario"], u);

                    aux = u.Nombre;

                    if (noleidos > 0)
                        aux += " (" + noleidos.ToString() + ")";

                    listaUsuarios.Items.Add(aux);
                    listaUsuarios.Items[i].Value = u.DNI;
                    i++;
                }
            }
        }


        // Carga los usuarios a los que se aplique el filtro
        protected void cargaFiltro(string textofiltro, bool noleidos)
        {
            if (noleidos)
            {
                usuarios = Taimer.User.GetUsersFiltroNoLeidosQuick(textofiltro, ((User)Session["usuario"]).DNI);
            }
            else
            {
                usuarios = Taimer.User.GetUsersFiltroQuick(textofiltro, ((User)Session["usuario"]).DNI);
            }

            llenarLista();
        }

        // Carga el filtro del TextBox de filtrado
        protected void botonBuscar_Click(object sender, EventArgs e)
        {
            cargaFiltro(textboxFiltro.Text, checkSoloNoLeidos.Checked);
        }

        // Comprueba si se ha marcado la casilla de "no leídos" y ordena filtrarlos
        protected void checkSoloNoLeidos_CheckedChanged(object sender, EventArgs e)
        {
            cargaFiltro(textboxFiltro.Text, checkSoloNoLeidos.Checked);
        }
    }
}