using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class AGestAsig : Form {

        AAddAsig childNew = null;
        AGestTurn childTur = null;
        Taimer.Actividad_a currentAsig = null;
        Taimer.Actividad_a currentAsigCopy = null;

        bool modificado = false;

        public AGestAsig() {
            InitializeComponent();
        }

        public void setChild(AAddAsig form1, AGestTurn form2) {
            childNew = form1;
            childTur = form2;
        }

        private void btNewUser_Click_1(object sender, EventArgs e) {
            if (childNew != null) {
                Hide();
                childNew.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        private void btGestTurno_Click(object sender, EventArgs e) {
            if (childTur != null) {
                Hide();

                childTur.loadAsig(currentAsigCopy);

                childTur.setParent(this);
                childTur.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        private void lbUserName_Click(object sender, EventArgs e) {
            tbName.Text = lbName.Text;
            lbName.Visible = false;
            tbName.Visible = true;
            tbName.Focus();
        }

        private void tbName_Validated(object sender, EventArgs e) {
            lbName.Text = tbName.Text;
            tbName.Visible = false;
            lbName.Visible = true;
            btCancel.Enabled = true;
            btCreate.Enabled = true;
        }

        private void lbDesc_Click(object sender, EventArgs e) {
            tbDesc.Text = lbDesc.Text;
            lbDesc.Visible = false;
            tbDesc.Visible = true;
            tbDesc.Focus();
        }

        private void tbDesc_Validated(object sender, EventArgs e) {
            lbDesc.Text = tbDesc.Text;
            tbDesc.Visible = false;
            lbDesc.Visible = true;
            btCancel.Enabled = true;
            btCreate.Enabled = true;
        }

        private void lbCoord_Click(object sender, EventArgs e) {
            tbCoord.Text = lbCoord.Text;
            lbCoord.Visible = false;
            tbCoord.Visible = true;
            tbCoord.Focus();
        }

        private void tbCoord_Validated(object sender, EventArgs e) {
            lbCoord.Text = tbCoord.Text;
            tbCoord.Visible = false;
            lbCoord.Visible = true;
            btCancel.Enabled = true;
            btCreate.Enabled = true;
        }

        public void updateTableAsig() {
            dgAsig.Rows.Clear();
            foreach (Taimer.Actividad_a acti in Program.Asignaturas) {
                dgAsig.Rows.Add(acti.Nombre, acti.NombreCoordinador);
                dgAsig.Rows[dgAsig.RowCount - 1].Tag = acti;
            }
        }

        private void AGestAsig_Load(object sender, EventArgs e) {

            updateTableAsig();

            clearInfo();
        }

        private void dgAsig_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex >= 0 && e.RowIndex < dgAsig.Rows.Count) {
                if (dgAsig.Columns["Eliminar"].Index == e.ColumnIndex) {
                    // Borrarla tambien de la lista

                    if (MessageBox.Show(
                            "¿Esta seguro de que desea borrar la asignatura?",
                            "Borrar asignatura",
                            MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {

                        Taimer.Actividad_a asigBorr = (Taimer.Actividad_a)dgAsig.Rows[e.RowIndex].Tag;

                        if (currentAsig == asigBorr) {
                            clearInfo();
                        }

                        asigBorr.Borrar();
                        Program.Asignaturas.Remove(asigBorr);
                        dgAsig.Rows.RemoveAt(e.RowIndex);

                    }

                } else {
                    currentAsig = (Taimer.Actividad_a)dgAsig.Rows[e.RowIndex].Tag;
                    currentAsigCopy = new Taimer.Actividad_a(currentAsig);

                    changeCurrent(currentAsig);
                }
            }
        }

        public void clearInfo() {
            lbName.Text = "";
            lbDesc.Text = "";
            lbCoord.Text = "";
            dgTurns.Rows.Clear();
            btCreate.Enabled = false;
            btCancel.Enabled = false;
            btGestTurno.Enabled = false;
        }

        public void changeCurrent(Taimer.Actividad_a asig) {

            lbName.Text = asig.Nombre;
            lbDesc.Text = asig.Descripcion;
            lbCoord.Text = asig.NombreCoordinador;

            dgTurns.Rows.Clear();
            foreach (Taimer.Turno turno in asig.Turnos) {
                dgTurns.Rows.Add(turno.DiaString, turno.HoraInicio.toString(), turno.HoraFin.toString());
            }

            btGestTurno.Enabled = true;

            currentAsig.CopiarDesde(asig);
            //gbInfo.Visible = true;
        }

        private void btCreate_Click(object sender, EventArgs e) {
            // Modificamos la asignatura en la lista
            currentAsig.CopiarDesde(currentAsigCopy);
            currentAsig.Nombre = lbName.Text;
            currentAsig.Descripcion = lbDesc.Text;
            currentAsig.NombreCoordinador = lbCoord.Text;

            currentAsig.Modificar();

            clearInfo();
            updateTableAsig();
        }

        private void btCancel_Click(object sender, EventArgs e) {

            if (MessageBox.Show(
                    "¿Esta seguro de que desea descartar los cambios?", 
                    "Descartar cambios", 
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) 
            {
                clearInfo();
                currentAsig = null;
                currentAsigCopy = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            foreach (DataGridViewRow row in dgAsig.Rows) {
                Taimer.Actividad_a acti = (Taimer.Actividad_a)row.Tag;
                String texto = textBox1.Text;
                if (acti.Nombre.Contains(texto) ||
                    acti.Descripcion.Contains(texto) ||
                    acti.NombreCoordinador.Contains(texto)) {
                    row.Visible = true;
                } else {
                    row.Visible = false;
                }
            }
        }

        public void addAsig(Taimer.Actividad_a asig) {
            Program.Asignaturas.Add(asig);

            updateTableAsig();
        }

        private void AGestAsig_Enter(object sender, EventArgs e) {
            clearInfo();
            dgAsig.ClearSelection();
        }
    }
}
