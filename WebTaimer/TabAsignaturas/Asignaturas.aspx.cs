using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taimer;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace WebTaimer.TabAsignaturas
{
    public partial class Asignaturas : System.Web.UI.Page
    {
        protected List<Actividad_a> actividades = new List<Actividad_a>();
        protected List<Actividad_a> actodas = new List<Actividad_a>();
        protected List<Comentario> listaComentarios = new List<Comentario>();
        protected List<Comentario> comentariosAct = new List<Comentario>();
        protected string comentarios;
        protected string puntuacion;
        protected Actividad_a actividadactual=null;

        protected void Page_Init(object sender, EventArgs e)
        {

            if (Session["usuario"] == null)
                Response.Redirect("~/TabAsignaturas/AsignaturasSin.aspx?error=true");
            else
            {
                actodas = Actividad_a.GetAllActividades_a();
                listaComentarios = Comentario.GetAllComentarios();
                string id = Request.QueryString["idActividad"];
                if (id != null)
                {
                    int idact = Convert.ToInt32(id);
                    actividades.Add(darActividad(idact));
                    foreach(Actividad_a a in actodas)
                    {
                        if (a.Codigo != darActividad(idact).Codigo)
                            actividades.Add(a);
                    }
                    llenarLista();           
                    rellenocuadro(idact);
                    
                }
                else
                {
                    cargarTodasActividades();
                    rellenocuadroPrimero(0);
                    
                }
            }
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");
            else
            {

               
                 //rellenocuadro(Convert.ToInt16(ListAct.SelectedValue));

            }
        }
        // Carga todas las actividades de la lista
        protected void cargarTodasActividades()
        {
            actividades = actodas;
            llenarLista();
        }
        protected void cargarTurnos(Actividad_a act)
        {
            string fecha;
            listaTurnos.DataBind();
            listaTurnos.Items.Clear();
            foreach (Turno turno in act.Turnos)
            {
                fecha = turno.DiaString + ", de " + turno.HoraInicio.toString() + " a " + turno.HoraFin.toString();
                listaTurnos.Items.Add(fecha);

            }
        }
        // Llena la lista de actividades (se hayan cargado todas, o con el filtro)
        protected void llenarLista()
        {
            ListAct.DataBind();
            ListAct.Items.Clear();
            int i = 0;
            foreach (Actividad_a act in actividades)
            {
                ListAct.Items.Add(act.Nombre);
                ListAct.Items[i].Value = Convert.ToString(act.Codigo);
                i++;

            }
            ListAct.SelectedIndex = 0;
        }
        protected void seleccionar(object sender, EventArgs e)
        {
            int indicelista = Convert.ToInt32(ListAct.SelectedValue);
            rellenocuadro(indicelista);
        }
        

        protected void rellenocuadro(int codigo)
        {
            actividades = actodas;
            bool existe = false;
            foreach (Actividad_a act in actividades)
            {
                if (act.Codigo == codigo)
                {
                    
                    labelNombreAsignatura.Text = act.Nombre;
                    labelCoordinadorAsignatura.Text = act.NombreCoordinador;
                    labelDescripcionAsignatura.Text = act.Descripcion;
                    cargarTurnos(act);
                    tituPun.Visible = true;
                    tituloCoor.Visible = true;
                    labelTurnos.Visible = true;
                    r1.CurrentRating = Convert.ToInt16(Math.Round(act.NotaMedia()));
                    listaTurnos.Visible = true;
                    //coment.Visible = true;
                    comentarios = cargarComentarios(act);
                    UpdatePanelConversacion.Update();
                    existe = true;
                }

            }
            if (existe == false)
            {
                labelNombreAsignatura.Text = "El indice que se pasa no es correcto";
                labelCoordinadorAsignatura.Text = "";
                labelDescripcionAsignatura.Text = "";
                tituPun.Visible = false;
                tituloCoor.Visible = false;
                labelTurnos.Visible = false;
                
                listaTurnos.Visible = false;
                //coment.Visible = false;
            }

        }

        protected void rellenocuadroPrimero(int indice)
        {
            if (actividades.Count > 0)
            {

                labelNombreAsignatura.Text = actividades[indice].Nombre;
                labelCoordinadorAsignatura.Text = actividades[indice].NombreCoordinador;
                labelDescripcionAsignatura.Text = actividades[indice].Descripcion;
                r1.CurrentRating = Convert.ToInt16(Math.Round(actividades[indice].NotaMedia()));
                cargarTurnos(actividades[indice]);
                tituPun.Visible = true;
                tituloCoor.Visible = true;
                labelTurnos.Visible = true;
                listaTurnos.Visible = true;
                //coment.Visible = true;
                //cargarComentarios(actividades[indice]);
                comentarios = cargarComentarios(actividades[indice]);
                UpdatePanelConversacion.Update();
                
            }
            else
            {
                labelNombreAsignatura.Text = "No hay resultados en la lista de actividades";
                labelCoordinadorAsignatura.Text = "";
                labelDescripcionAsignatura.Text = "";
                tituPun.Visible = false;
                tituloCoor.Visible = false;
                labelTurnos.Visible = false;
                
                listaTurnos.Visible = false;
                //coment.Visible = false;

            }

        }
        // Carga el filtro del TextBox de filtrado
        protected void botFiltrar_Click(object sender, EventArgs e)
        {
            cargaFiltro(textboxFilter.Text.ToLower());
        }
        // Carga los usuarios a los que se aplique el filtro
        protected void cargaFiltro(string nom)
        {

            List<Actividad_a> actfiltro = new List<Actividad_a>();
            if (nom != null && nom != "")
            {
                cargarTodasActividades();
                foreach (Actividad_a obj in actividades)
                {
                    if (obj.Nombre.ToLower().Contains(nom) || obj.Descripcion.ToLower().Contains(nom) || obj.NombreCoordinador.ToLower().Contains(nom))
                    {
                        actfiltro.Add(obj);

                    }

                }
                actividades = actfiltro;
                rellenocuadroPrimero(0);
                llenarLista();
            }
            else
            {
                cargarTodasActividades();
                
                rellenocuadroPrimero(0);
            }

        }
        protected List<Comentario> rellenoComenAct(Actividad_a act)
        {
            List<Comentario> coment = new List<Comentario>();

            if (listaComentarios.Count > 0)
            {
                foreach (Comentario com in listaComentarios)
                {
                    if (com.ActividadAcademica.Codigo == act.Codigo)
                        coment.Add(com);

                }
            }
            return coment;

        }
        protected string cargarComentarios(Actividad_a act)
        {

            comentariosAct = rellenoComenAct(act);
            string comentarios = "";
            if (comentariosAct.Count == 0)
            {
                comentarios = "<div style=\"color: #000000; float:center; background-color:#fff199;; overflow: visible; border-radius: 10px; margin: 4px; text-align:center \" >Esta atividad aún no tiene comentarios.</div>";
            }
            else
            {
                comentarios = "";
                foreach (Comentario com in comentariosAct)
                {

                    string nomUsuario = "";
                    string imagen = "";
                    if (com.Usuario != null)
                    {
                        nomUsuario = com.Usuario.Nombre;
                        imagen = rutaImagen(com.Usuario);
                    }
                    else
                    {
                        nomUsuario = "Anónimo";
                        imagen = "../Images/default.jpg";
                    }
                   
                    if (com.Usuario != null)
                    {
                        if (((User)Session["usuario"]).DNI == com.Usuario.DNI)
                        { // debería poner un botón para borrar
                            comentarios += "<div class='comentario'> <p class='cabecera'> Comentario enviado por: " + nomUsuario + " (" + com.FechaToString() + ")</p><span><span class='comentarioimg'><img class='comentario' src='" + imagen + "'/></span><span><p class='comentario'>" + com.Texto + "</p></span></span><span class='comentarioclear'></div>";                           
                        }
                        else
                        {
                            comentarios += "<div class='comentario'> <p class='cabecera'> Comentario enviado por: " + nomUsuario + " (" + com.FechaToString() + ")</p><span><span class='comentarioimg'><img class='comentario' src='" + imagen + "'/></span><span><p class='comentario'>" + com.Texto + "</p></span></span><span class='comentarioclear'></div>";
                        }
                    }                    else                    {
                        comentarios += "<div class='comentario'> <p class='cabecera'> Comentario enviado por: " + nomUsuario + " (" + com.FechaToString() + ")</p><span><span class='comentarioimg'><img class='comentario' src='" + imagen + "'/></span><span><p class='comentario'>" + com.Texto + "</p></span></span><span class='comentarioclear'></div>";                    }
                }
            }
            return comentarios;
        }
        protected void Borrar(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(Button.Text));
        }

        protected string rutaImagen(User user)
        {
            string ruta = "";
            if (user.Imagen != "" && user.Imagen != null)
                ruta = "../Images/" + user.Imagen;
            else
                ruta = "../Images/default.jpg";
            return ruta;
        }

        protected Actividad_a darActividad(int indice)
        {

            foreach (Actividad_a act in actodas)
            {
                if (act.Codigo == indice)
                {
                    return act;
                }
            }
            return null;
        }
        protected void botNuevoComentario_Click(object sender, EventArgs e)
        {
            string texto = textoComent.Text; 
            Comentario com = null;
            actividadactual = darActividad(Convert.ToInt32(ListAct.SelectedValue));
            
            if (texto != null || texto != "")
            {
                // Fragmentar las palabras de más de 50 caracteres para no descuadrar el cuadro de mensajes
                int acumuladas = 0;
                string nuevotexto = "";
                for (int i = 0; i < texto.Length; i++)
                {
                    if (texto[i].Equals(" "))
                        acumuladas = 0;
                    else
                        acumuladas++;

                    if (acumuladas > 50)
                    {
                        nuevotexto += " " + texto[i];
                        //advertencia = true;
                        acumuladas = 1;
                    }
                    else
                    {
                        nuevotexto += texto[i];
                    }

                }
                if(checkAnonimo.Checked)
                {

                    com = new Comentario(0, nuevotexto, actividadactual, null, DateTime.Now);
                }
                else
                {

                    com = new Comentario(0,nuevotexto, actividadactual, (User)Session["usuario"], DateTime.Now);
                }

                com.Agregar();
                listaComentarios.Insert(0, com);
                rellenocuadro(Convert.ToInt32(ListAct.SelectedValue));
                com = null;
                textoComent.Text = "";
                
            }
        }
        protected void Submit1_onclick(object sender, AjaxControlToolkit.RatingEventArgs e)
        {
            actividadactual = darActividad(Convert.ToInt32(ListAct.SelectedValue));
            actodas.Remove(actividadactual);
            int nota = Convert.ToInt16(e.Value);
            actividadactual.NotaTotal = actividadactual.NotaTotal+nota;
            actividadactual.NumVotos++;
            actividadactual.Modificar();
            actodas.Insert(0,actividadactual);
            rellenocuadro(Convert.ToInt32(ListAct.SelectedValue));
        }

    }
}