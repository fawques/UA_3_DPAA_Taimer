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
        List<Actividad_a> actividades=new List<Actividad_a>();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                cargarTodasActividades();

            }

        }
        // Carga todas las actividades de la lista
        protected void cargarTodasActividades()
        {
            actividades = Actividad_a.GetAllActividades_a();
            rellenocuadroPrimero(0);

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
            int i=0;
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
            actividades = Actividad_a.GetAllActividades_a();
            foreach (Actividad_a act in actividades)
            {
                if (act.Codigo == codigo)
                {
                    labelNombreAsignatura.Text = act.Nombre;
                    labelCoordinadorAsignatura.Text = act.NombreCoordinador;
                    labelDescripcionAsignatura.Text = act.Descripcion;
                    r1.CurrentRating = Convert.ToInt16(Math.Round(act.NotaMedia()));
                    cargarTurnos(act);
                }

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
                cargarTodasActividades();
        }
         
                
    }
        
}