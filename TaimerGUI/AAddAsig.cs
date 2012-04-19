using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TaimerGUI
{
    public partial class AAddAsig : Form
    {

        AGestAsig parentForm = null;
        AGestTurn childForm = null;

        Taimer.Actividad_a asig = null;

        public AAddAsig()
        {
            InitializeComponent();
        }

        public void setParent(AGestAsig form)
        {
            parentForm = form;
        }

        public void setChild(AGestTurn form)
        {
            childForm = form;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(
                    "¿Esta seguro de que desea descartar la asignatura?",
                    "Descartar asignatura",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (parentForm != null)
                {
                    Hide();
                    parentForm.Show();

                    asig = null;
                    clearLabels();

                    AdminForm parent = (AdminForm)this.MdiParent;
                    parent.positionChilds();
                }
            }
        }

        private void btCreate_Click(object sender, EventArgs e) {
            bool valid = true;
            // Comprobamos los datos

            if (tbName.Text == "") {
                lbErrName.Visible = true;
                valid = false;
            } else {
                lbErrName.Visible = false;
            }

            if (tbDesc.Text == "") {
                lbErrDesc.Visible = true;
                valid = false;
            } else {
                lbErrDesc.Visible = false;
            }

            if (tbCoord.Text == "") {
                lbErrCoord.Visible = true;
                valid = false;
            } else {
                lbErrCoord.Visible = false;
            }

            if (tbTitu.Text == "") {
                lbErrTit.Visible = true;
                valid = false;
            }else {
                lbErrTit.Visible = false;
            }


            if (valid && parentForm != null) {

                try
                {
                    if (asig == null)
                    {
                        asig = new Taimer.Actividad_a(tbName.Text, tbDesc.Text, tbCoord.Text, (int)udCurso.Value, tbTitu.Text);
                    }
                    else
                    {
                        // Meto los datos
                        asig.Nombre = tbName.Text;
                        asig.Descripcion = tbDesc.Text;
                        asig.NombreCoordinador = tbCoord.Text;
                        asig.Titulacion = tbTitu.Text;
                        asig.Curso = (int) udCurso.Value;
                    }

                    asig.Agregar();
                    //foreach (Taimer.Turno item in asig.Turnos) {
                    //    item.Agregar();
                    //}

                    clearLabels();

                    // La añado a la lista
                    parentForm.addAsig(asig);
                    Program.CodAsignaturas++;

                    asig = null;

                    Hide();
                    parentForm.Show();

                    AdminForm parent = (AdminForm)this.MdiParent;
                    parent.positionChilds();

                }
                catch (SqlException ex)
                {
                    if(ex.Message.Contains("PRIMARY KEY"))
                        MessageBox.Show("El código se repite");
                    else
                        MessageBox.Show(ex.Message);
                }
            }
        }

        private void btAddTurn_Click(object sender, EventArgs e)
        {
            if (childForm != null)
            {
                Hide();

                if (asig == null) {
                    lbErrCoord.Visible = true;
                }

                childForm.loadAsig(asig);

                childForm.setParent(this);
                childForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        private void clearLabels()
        {
            tbName.Clear();
            tbDesc.Clear();
            tbCoord.Clear();
        }

        private void AAddAsig_Enter(object sender, EventArgs e)
        {
            dgTurnos.Rows.Clear();
            if (asig == null)
            {
                asig = new Taimer.Actividad_a("", "", "", "",Program.CodAsignaturas);

                if (asig == null) {
                    lbErrCoord.Visible = true;
                }
                
                clearLabels();
            }
            else
            {
                foreach (Taimer.Turno turno in asig.Turnos)
                {
                    dgTurnos.Rows.Add(turno.DiaString, turno.HoraInicio.toString(), turno.HoraFin.toString(), turno.Ubicacion);
                }
            }

        }
    }
}
