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
        int selectedRow = 0;
        public List<Taimer.Actividad_a> asignaturas = new List<Taimer.Actividad_a>();

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

        private void button1_Click(object sender, EventArgs e) {
            if (childTur != null) {
                Hide();

                childTur.loadAsig(null);

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

        private void btCancel_Click(object sender, EventArgs e) {

        }

        public void addTurn(string dia, string hIni, string hFin, string ubi) {

            dgTurns.Rows.Add(dia, hIni, hFin, ubi);
        }

        public void clearTurns() {

            dgTurns.Rows.Clear();
        }

        public void updateTableAsig() {
            dgAsig.Rows.Clear();
            foreach (Taimer.Actividad_a acti in Program.Asignaturas) {
                dgAsig.Rows.Add(acti.Nombre, acti.NombreCoordinador);
                dgAsig.Rows[dgAsig.RowCount - 1].Tag = acti;
            }
        }

        private void AGestAsig_Load(object sender, EventArgs e) {
            Taimer.Actividad_a acti1 = new Taimer.Actividad_a("DPAA", "Clases de DPAA de Teoria", Program.CodAsignaturas, "Irene");
            Taimer.Actividad_a acti2 = new Taimer.Actividad_a("SO1", "Sistemas Operativos de 2º", Program.CodAsignaturas, "Mora");

            Taimer.Hora hor1 = new Taimer.Hora(13,30);
            Taimer.Hora hor2 = new Taimer.Hora(15,0);
            Taimer.Hora hor3 = new Taimer.Hora(17,0);

            Taimer.Turno turn11 = new Taimer.Turno(hor1, hor2, "Lunes", "LAB01");
            Taimer.Turno turn12 = new Taimer.Turno(hor1, hor2, "Martes", "LAB01");

            acti1.AddTurno(turn11);
            acti1.AddTurno(turn12);

            Taimer.Turno turn21 = new Taimer.Turno(hor2, hor3, "Jueves", "LAB02");
            Taimer.Turno turn22 = new Taimer.Turno(hor2, hor3, "Viernes", "LAB02");

            acti2.AddTurno(turn21);
            acti2.AddTurno(turn22);

            //Program.AddAsignatura(new Taimer.Actividad_a("DPAA", "Clases de DPAA de Teoria", Program.CodAsignaturas, "Irene", 1));
            //Program.AddAsignatura(acti2);

            //updateTableAsig();

            asignaturas.Add(acti1);
            asignaturas.Add(acti2);

            dgAsig.Rows.Add(acti1.Nombre, acti1.NombreCoordinador);
            dgAsig.Rows[dgAsig.RowCount - 1].Tag = acti1;

            dgAsig.Rows.Add(acti2.Nombre, acti2.NombreCoordinador);
            dgAsig.Rows[dgAsig.RowCount - 1].Tag = acti2;
        }

        private void dgAsig_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex >= 0 && e.RowIndex < dgAsig.Rows.Count) {

                selectedRow = e.RowIndex;

                Taimer.Actividad_a asig = (Taimer.Actividad_a)dgAsig.Rows[selectedRow].Tag;

                showInfo(asig);

                btCancel.Enabled = true;
            }
        }

        public void clearLabels() {
            lbName.Text = "";
            lbDesc.Text = "";
            lbCoord.Text = "";
        }

        public void showInfo(Taimer.Actividad_a asig) {

            lbName.Text = asig.Nombre;
            lbDesc.Text = asig.Descripcion;
            lbCoord.Text = asig.NombreCoordinador;

            dgTurns.Rows.Clear();
            foreach (Taimer.Turno turno in asig.Turnos) {
                dgTurns.Rows.Add(turno.DiaString, turno.HoraInicio.toString(), turno.HoraFin.toString());
            }

            btGestTurno.Enabled = true;
        }
    }
}
