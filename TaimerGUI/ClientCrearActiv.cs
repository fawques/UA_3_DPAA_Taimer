using System;
using Taimer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI
{
    public partial class ClientCrearActiv : Form
    {
        private User usrAux;
        private Actividad_p actAux = null;
        private ClientGestTurno formGestTurnos;
        public ClientCrearActiv(User usr, ClientGestTurno f)
        {
            InitializeComponent();
            usrAux = usr;
            formGestTurnos = f;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((ClientForm)this.MdiParent).verActividades_Click(null, null);
        }


        private void gVHorasTemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gVHorasTemp.Columns["Borrar"].Index)
            {
                gVHorasTemp.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void bttnCrearActiv_Click(object sender, EventArgs e)
        {


            if (validarTodo())
            {
                if (actAux == null || actAux.Turnos.Count <= 0)
                {

                }
                if (MessageBox.Show("¿Seguro que desea crearla?",
                "¿Crear actividad?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (actAux == null)
                    {
                        actAux = new Actividad_p(tBNombre.Text, rTBDescripcion.Text, usrAux.CodActPers, usrAux);
                    }
                    actAux.Nombre = tBNombre.Text;
                    actAux.Descripcion = rTBDescripcion.Text;
                    try
                    {
                        usrAux.AddActPersonal(actAux);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ((ClientForm)this.MdiParent).loadLastActividades();
                    ((ClientForm)this.MdiParent).verActividad_Click(null, null);
                }
            }

        }

        private bool validarTodo()
        {
            bool correcto = true;
            if (tBNombre.Text == "")
            {
                lblErrorNombre.Visible = true;
                correcto = false;
            }
            else
            {
                lblErrorNombre.Visible = false;
            }

            return correcto;
        }

        public void loadBoxTurnos()
        {
            gVHorasTemp.Rows.Clear();
            if (actAux != null)
            {
                foreach (Turno t in actAux.Turnos)
                {
                    gVHorasTemp.Rows.Add(t.DiaString, t.HoraInicio.toString(), t.HoraFin.toString(), t.Ubicacion);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (actAux == null)
            {
                actAux = new Actividad_p(tBNombre.Text, rTBDescripcion.Text, usrAux.CodActPers, usrAux);
            }
            this.formGestTurnos.reiniciar();
            this.formGestTurnos.setFormPadre(this);
            this.formGestTurnos.setActividad(actAux);
            this.formGestTurnos.Show();
            this.formGestTurnos.Focus();
        }

        private void ClientCrearActiv_Activated(object sender, EventArgs e)
        {
        }

        public void reiniciar()
        {
            actAux = null;
            tBNombre.Text = "";
            rTBDescripcion.Text = "";
            gVHorasTemp.Rows.Clear();
        }

        private void ClientCrearActiv_Load(object sender, EventArgs e)
        {

        }

    }
}