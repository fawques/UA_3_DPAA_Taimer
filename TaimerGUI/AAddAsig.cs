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

            if (valid && parentForm != null) {

                // Creo una asignatura 

                Hide();
                parentForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        public void addTurn(string dia, string hIni, string hFin, string ubi) {

            dgTurnos.Rows.Add(dia, hIni, hFin, ubi);
        }

        public void clearTurns() {

            dgTurnos.Rows.Clear();
        }

        private void btAddTurn_Click(object sender, EventArgs e) {
            if (childForm != null) {
                Hide();

                childForm.clearRows();
                foreach (DataGridViewRow row in dgTurnos.Rows) {
                    childForm.addRow(row.Cells["Dia"].Value.ToString(),
                        row.Cells["HoraInicio"].Value.ToString(),
                        row.Cells["HoraFin"].Value.ToString(),
                        row.Cells["Ubicacion"].Value.ToString());
                }

                childForm.setParent(this);
                childForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }
    }
}
