using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taimer;
using System.Windows.Forms;

namespace WebTaimer.TabActividades
{
    public partial class Actividades : System.Web.UI.Page
    {
        protected List<Actividad_p> listaFiltro = new List<Actividad_p>();
        protected List<Actividad_p> todas = new List<Actividad_p>();
        protected User user;
        protected Actividad_p actividad;       

        /*protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] == null)
                    Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");

                else
                    cargarTodas();
            }
        }*/
        
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");
              
            else
            {                
                string id = Request.QueryString["id"];
                user = ((User)Session["usuario"]);
                todas = user.ActPersonales;

                if (id != null)
                {
                    int idact = Convert.ToInt32(id);
                    
                    foreach (Actividad_p act in user.ActPersonales)
                    {
                        if (idact == act.Codigo)
                        {
                            listaFiltro.Add(act);                    
                            actividad = act;
                        }
                        
                    }

                    foreach (Actividad_p act in user.ActPersonales)
                    {
                        if (act.Codigo != idact)
                        {
                            listaFiltro.Add(act);                           
                        }
                    }

                    if (actividad == null)
                    {
                        labelNombreActividad.Text = "La actividad no existe";
                        labelDescripcionActividad.Text = "";
                        labelTurnos.Visible = false;
                        listaTurnos.Visible = false;
                        botonBorrarActividad.Visible = false;
                        botonEditarActividad.Visible = false;
                    }

                    else                                           
                        rellenocuadro(idact);                    

                    llenarLista();
                    
                }
                else
                {                    
                    cargarTodas();
                    rellenocuadroPrimero(0);

                }
                ListAct.SelectedIndex = 0;
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
            if (nom != null && nom != "")
            {
                List<Actividad_p> aux = new List<Actividad_p>();
                cargarTodas();
                foreach (Actividad_p act in listaFiltro)
                {
                    if (act.Nombre.ToLower().Contains(nom) || act.Descripcion.ToLower().Contains(nom))
                    {
                        aux.Add(act);
                    }

                }
                listaFiltro = aux;
                rellenocuadroPrimero(0);
                llenarLista();
            }
            else
            {
                cargarTodas();
                rellenocuadroPrimero(0);
            }
        }

        protected void cargarTodas()
        {
            listaFiltro = todas;           
            llenarLista();
        }

        // Llena la lista de actividades (se hayan cargado todas, o con el filtro)
        protected void llenarLista()
        {
            ListAct.DataBind();
            ListAct.Items.Clear();
            int i = 0;            
            foreach (Actividad_p act in listaFiltro)
            {
                ListAct.Items.Add(act.Nombre);
                ListAct.Items[i].Value = Convert.ToString(act.Codigo);
                i++;
            }
        }

        protected void cargarTurnos(Actividad_p act)
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

        protected void seleccionar(object sender, EventArgs e)
        {            
            int indicelista = Convert.ToInt32(ListAct.SelectedValue);         
            rellenocuadro(indicelista);
        }

        protected void rellenocuadro(int codigo)
        {
            listaFiltro=todas;
            
            foreach (Actividad_p act in listaFiltro)
            {
                if (act.Codigo == codigo)
                {
                    labelNombreActividad.Text = act.Nombre;
                    labelDescripcionActividad.Text = act.Descripcion;
                    cargarTurnos(act);
                    labelTurnos.Visible = true;
                    listaTurnos.Visible = true;
                    botonBorrarActividad.Visible = true;
                    botonEditarActividad.Visible = true;  
                }
            }                               
        }

        protected void rellenocuadroPrimero(int indice)
        {
            if (listaFiltro.Count > 0)
            {
                labelNombreActividad.Text = listaFiltro[indice].Nombre;                
                labelDescripcionActividad.Text = listaFiltro[indice].Descripcion;                             
                cargarTurnos(listaFiltro[indice]);                
                labelTurnos.Visible = true;                
                listaTurnos.Visible = true;
                botonBorrarActividad.Visible = true;
                botonEditarActividad.Visible = true;  
            }
            else
            {
                labelNombreActividad.Text = "La actividad no existe";                
                labelDescripcionActividad.Text = "";                
                labelTurnos.Visible = false;
                listaTurnos.Visible = false;
                botonBorrarActividad.Visible = false;
                botonEditarActividad.Visible = false;                
            }
            
        }

        protected void botonEditarActividad_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(ListAct.SelectedValue);

            foreach (Actividad_p act in listaFiltro)
            {
                if (id == act.Codigo)
                    actividad = act;
            }

            Response.Redirect("EditarActividad.aspx?id=" + actividad.Codigo);
        }

        protected void botonBorrarActividad_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(ListAct.SelectedValue);

            foreach (Actividad_p act in listaFiltro)
            {
                if (id == act.Codigo)
                    actividad = act;
            }
            
            ConfirmaBorrar.Visible = true;
            botonBorrarActividad.Visible = false;
            botonEditarActividad.Visible = false;
   
            filtro.Visible = false;
            asig.Visible = false;            
        }

        protected void botonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TabActividades/Actividades.aspx");
        }

        protected void botonConfirmar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(ListAct.SelectedValue);

            foreach (Actividad_p act in listaFiltro)
            {
                if (id == act.Codigo)
                    actividad = act;
            }
                    
            user.BorraActPersonal(actividad);
            Response.Redirect("~/TabActividades/Actividades.aspx");
        }
    }
}