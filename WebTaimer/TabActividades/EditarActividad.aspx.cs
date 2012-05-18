using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Taimer;

namespace WebTaimer.TabActividades
{
    public partial class EditarActividad : System.Web.UI.Page
    {
        Actividad_p actividad;
        Turno turnoSelec;
        User user;

        /*protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] == null)
                    Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");

                else
                {
                    user = (User)Session["usuario"];
                    actividad = getActividad();
                    MessageBox.Show(actividad.Nombre);
                }
            }
        }*/

        protected void Page_Init(object sender, EventArgs e)
        {            
            if (Session["usuario"] == null)
                Response.Redirect("~/TabInicio/SinLogin.aspx?error=true");

            else
            {                
                user = (User)Session["usuario"];
                actividad = getActividad();
                tbNombreActividad.Text = actividad.Nombre;
                tbDescActividad.Text = actividad.Descripcion;

                if (actividad.Turnos.Count > 0)
                {
                    cargarTurnos(actividad);
                    listaTurnos.SelectedIndex = 0;
                    int index = Convert.ToInt16(listaTurnos.SelectedValue);                    

                    foreach (Turno t in actividad.Turnos)
                    {
                        if (t.Codigo == index)
                        {
                            tbCambiaDia.Text = t.DiaString;
                            tbCambiaHoraI.Text = t.HoraInicio.toString();
                            tbCambiaHoraF.Text = t.HoraFin.toString();
                            turnoSelec = t;
                        }
                    }
                }
            }
        }
      
        protected void botonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TabActividades/Actividades.aspx");
        }

        protected void botonModificar_Click(object sender, EventArgs e)
        {
            actividad.Nombre = tbNombreActividad.Text;
            actividad.Descripcion = tbDescActividad.Text;
            actividad.Modificar();
            Response.Redirect("~/TabActividades/Actividades.aspx");            
        }

        protected void CambiarTurno(object sender, EventArgs e)
        {
            if (actividad.Turnos.Count > 0)
            {
                cargarTurnos(actividad);
                listaTurnos.SelectedIndex = 0;
                int index = Convert.ToInt16(listaTurnos.SelectedValue);

                foreach (Turno t in actividad.Turnos)
                {
                    if (t.Codigo == index)
                    {
                        tbCambiaDia.Text = t.DiaString;
                        tbCambiaHoraI.Text = t.HoraInicio.toString();
                        tbCambiaHoraF.Text = t.HoraFin.toString();
                        turnoSelec = t;
                    }
                }
            }
        }

        protected Actividad_p getActividad()
        {            
            int cod = Convert.ToInt32(Request.QueryString["id"]);
            foreach (Actividad_p a in user.ActPersonales)
            {
                if (cod == a.Codigo)
                    return a;
            }
            return null;
        }

        protected void cargarTurnos(Actividad_p act)
        {
            string fecha;
            listaTurnos.DataBind();
            listaTurnos.Items.Clear();
            int i = 0;
            foreach (Turno turno in act.Turnos)
            {
                fecha = turno.DiaString + ", de " + turno.HoraInicio.toString() + " a " + turno.HoraFin.toString();
                listaTurnos.Items.Add(fecha);
                listaTurnos.Items[i].Value = Convert.ToString(turno.Codigo);
                i++;
            }
        }

        protected void btCambiaTurno_Click(object sender, EventArgs e)
        {
            if (listaTurnos.Items.Count > 0)
            {

                divCambiaTurno.Visible = true;
                btCambiaTurno.Visible = false;
                btBorraTurno.Visible = false;
                btCancelaTurno.Visible = true;
                btNuevoTurno.Visible = false;
            }
        }

        protected void btBorraTurno_Click(object sender, EventArgs e)
        {
            if (listaTurnos.Items.Count > 0)
            {
                btBorraTurno.Visible = false;
                btCambiaTurno.Visible = false;
                btConfirmaBorrar.Visible = true;
                btCancelaBorrar.Visible = true;
                btNuevoTurno.Visible = false;
            }
        }

        protected void btConfirmaTurno_Click(object sender, EventArgs e)
        {            
            turnoSelec.DiaString = tbCambiaDia.Text;           
            turnoSelec.HoraI(tbCambiaHoraI.Text);
            turnoSelec.HoraF(tbCambiaHoraF.Text);
            turnoSelec.Ubicacion=tbCambiaUbic.Text;
            turnoSelec.Modificar();

            btCancelaTurno.Visible = false;
            btConfirmaTurno.Visible = false;

            Response.Redirect("EditarActividad.aspx?id="+actividad.Codigo);
        }

        protected void btCancelaTurno_Click(object sender, EventArgs e)
        {
            divCambiaTurno.Visible = false;
            btCambiaTurno.Visible = true;
            btBorraTurno.Visible = true;
            btCancelaTurno.Visible = false;
            btNuevoTurno.Visible = true;
        }

        protected void btConfirmaBorrar_Click(object sender, EventArgs e)
        {            
            actividad.BorraTurno(turnoSelec.Codigo);
            btCambiaTurno.Visible = true;
            btConfirmaBorrar.Visible = false;
            Response.Redirect("EditarActividad.aspx?id=" + actividad.Codigo);
        }

        protected void btCancelaBorrar_Click(object sender, EventArgs e)
        {            
            btCambiaTurno.Visible = true;
            btBorraTurno.Visible = true;
            btCancelaBorrar.Visible = false;
            btConfirmaBorrar.Visible = false;
            btNuevoTurno.Visible = true;
        }

        protected void btNuevoTurno_Click(object sender, EventArgs e)
        {
            divNuevoTurno.Visible = true;
            btCambiaTurno.Visible = false;
            btBorraTurno.Visible = false;
            btNuevoTurno.Visible = false;
         
        }

        protected void btConfirmaNuevo_Click(object sender, EventArgs e)
        {
            Hora ini = new Hora(tbNuevaHoraI.Text);
            Hora fin = new Hora(tbNuevaHoraF.Text);
            turnoSelec = new Turno(ini,fin,tbNuevoDia.Text,tbNuevaUbic.Text);
          
            actividad.AddTurno(turnoSelec);

            btCancelaNuevo.Visible = false;
            btConfirmaNuevo.Visible = false;

            Response.Redirect("EditarActividad.aspx?id=" + actividad.Codigo);
        }
        
        protected void btCancelaNuevo_Click(object sender, EventArgs e)
        {
            divNuevoTurno.Visible = false;
            btCancelaNuevo.Visible = true;
            btConfirmaNuevo.Visible = true;

            btCambiaTurno.Visible = true;
            btBorraTurno.Visible = true;
            btNuevoTurno.Visible = true;

            //Response.Redirect("EditarActividad.aspx?id=" + actividad.Codigo);
        }
    }
}