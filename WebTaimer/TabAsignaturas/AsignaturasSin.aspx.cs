using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taimer;

namespace WebTaimer.TabAsignaturas
{
    public partial class AsignaturasSin : System.Web.UI.Page
    {
        protected List<Actividad_a> actividades = new List<Actividad_a>();
        protected List<Actividad_a> actodas = new List<Actividad_a>();
        protected List<Comentario> listaComentarios = new List<Comentario>();
        protected List<Comentario> comentariosAct = new List<Comentario>();
        protected string comentarios;

        protected void Page_Init(object sender, EventArgs e)
        {
            actodas = Actividad_a.GetAllActividades_a();
            listaComentarios = Comentario.GetAllComentarios();
           string id = Request.QueryString["idActividad"];
            if (id != null)
            {
                int idact = Convert.ToInt32(id);
                if (darActividad(idact) != null)
                {
                    actividades.Add(darActividad(idact));

                    foreach (Actividad_a a in actodas)
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
                    rellenocuadro(idact);
                    
                }
               
                
            }
            else
            {
                cargarTodasActividades();
                rellenocuadroPrimero(0);

            }
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
                    r1.CurrentRating = Convert.ToInt16(Math.Round(act.NotaMedia()));
                    cargarTurnos(act);
                    tituPun.Visible = true;
                    tituloCoor.Visible = true;
                    labelTurnos.Visible = true;
                    r1.Visible = true;
                    listaTurnos.Visible = true;
                    coment.Visible = true;
                    cargarComentarios(act);
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
                r1.Visible = false;
                listaTurnos.Visible = false;
                coment.Visible = false;
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
                r1.Visible = true;
                listaTurnos.Visible = true;
                coment.Visible = true;
                cargarComentarios(actividades[indice]);

            }
            else
            {
                labelNombreAsignatura.Text = "No hay resultados en la lista de actividades";
                labelCoordinadorAsignatura.Text = "";
                labelDescripcionAsignatura.Text = "";
                tituPun.Visible = false;
                tituloCoor.Visible = false;
                labelTurnos.Visible = false;
                r1.Visible = false;
                listaTurnos.Visible = false;
                coment.Visible = false;

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
        protected void cargarComentarios(Actividad_a act)
        {
            
            comentariosAct = rellenoComenAct(act);
            if (comentariosAct.Count == 0)
            {
                comentarios = "<div style=\"color: #000000; float:center; background-color:#fff199;; overflow: visible; border-radius: 10px; margin: 4px; text-align:center \" >Esta actividad aún no tiene comentarios.</div>";
            }
            else
            {
                comentarios = "";
                foreach (Comentario com in comentariosAct)
                {
                    string nomUsuario="";
                    string imagen = "";
                    if (com.Usuario != null)
                    {
                        nomUsuario = com.Usuario.Nombre;
                        imagen = rutaImagen(com.Usuario);
                    }
                    else
                    { 
                        nomUsuario="Anónimo";
                        imagen = "../Images/default.jpg";
                    }
                    comentarios += "<div class='comentario'> <p class='cabecera'> Comentario enviado por: " + nomUsuario + " (" + com.FechaToString() + ")</p><span><span class='comentarioimg'><img class='comentario' src='" + imagen + "'/></span><span><p class='comentario'>" + com.Texto + "</p></span></span><span class='comentarioclear'></div>";
                    
                                    
                }
            }
            

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
        

    }        
 }
        
