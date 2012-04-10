using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class AAddAsig : Form {

        AGestAsig parentForm = null;
        AGestTurn childForm = null;

        Taimer.Actividad_a asig = null;

        public AAddAsig() {
            InitializeComponent();
        }

        public void setParent(AGestAsig form) {
            parentForm = form;
        }

        public void setChild(AGestTurn form) {
            childForm = form;
        }

        private void btCancel_Click(object sender, EventArgs e) {
            if (parentForm != null) {
                Hide();
                parentForm.Show();

                asig = null;
                clearLabels();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
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

            if (valid && parentForm != null) {

                // Creo una asignatura 
                asig.Nombre = tbName.Text;
                asig.Descripcion = tbDesc.Text;
                asig.NombreCoordinador = tbCoord.Text;
                clearLabels();

                // La añado a la lista
                parentForm.addAsig(asig);

                asig = null;

                Hide();
                parentForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        private void btAddTurn_Click(object sender, EventArgs e) {
            if (childForm != null) {
                Hide();

                childForm.loadAsig(asig);

                childForm.setParent(this);
                childForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        private void clearLabels() {
            tbName.Clear();
            tbDesc.Clear();
            tbCoord.Clear();
        }

        private void AAddAsig_Enter(object sender, EventArgs e) {
            if (asig == null) {
                asig = new Taimer.Actividad_a("", "", 0, "");
                clearLabels();
            }
            dgTurnos.Rows.Clear();
            foreach (Taimer.Turno turno in asig.Turnos) {
                dgTurnos.Rows.Add(turno.DiaString, turno.HoraInicio.toString(), turno.HoraFin.toString(), turno.Ubicacion);
            }

        }
    }
}
