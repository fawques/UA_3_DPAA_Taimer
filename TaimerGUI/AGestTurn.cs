using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class AGestTurn : Form {

        AAddAsig parentAdd = null;
        AGestAsig parentGest = null;
        AModiTurn childMod = null;
        int selectedRow = 0;

        public AGestTurn() {
            InitializeComponent();
        }

        public void setParent(AAddAsig form) {
            parentGest = null;
            parentAdd = form;
        }

        public void setParent(AGestAsig form) {
            parentGest = form;
            parentAdd = null;
        }

        public void setChild(AModiTurn form) {
            childMod = form;
        }

        private void btCreate_Click(object sender, EventArgs e) {

            if (parentGest != null) {

                parentGest.clearTurns();

                // Cojo la tabla y se la paso al padre
                foreach (DataGridViewRow row in dgTurnos.Rows) {
                    parentGest.addTurn(row.Cells["Dia"].Value.ToString(),
                        row.Cells["HoraInicio"].Value.ToString(),
                        row.Cells["HoraFin"].Value.ToString(),
                        row.Cells["Ubicacion"].Value.ToString());
                }

                Hide();
                parentGest.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            } else if (parentAdd != null) {

                parentAdd.clearTurns();

                // Cojo la tabla y se la paso al padre
                foreach (DataGridViewRow row in dgTurnos.Rows) {
                    parentAdd.addTurn(row.Cells["Dia"].Value.ToString(),
                        row.Cells["HoraInicio"].Value.ToString(),
                        row.Cells["HoraFin"].Value.ToString(),
                        row.Cells["Ubicacion"].Value.ToString());
                }

                Hide();
                parentAdd.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        private bool parentNotNull() {
            return parentAdd != null && parentGest != null;
        }

        private void btAdd_Click(object sender, EventArgs e) {
            bool valid = true;

            if (tbUbi.Text == "") {
                lbErrUbi.Visible = true;
                valid = false;
            } else {
                lbErrUbi.Visible = false;
            }

            Taimer.Hora horI = new Taimer.Hora((int)udHoraIni.Value, (int)udMinIni.Value);
            Taimer.Hora horF = new Taimer.Hora((int)udHoraFin.Value, (int)udMinFin.Value);

            if (horI > horF) {
                lbErrHora.Visible = true;
                valid = false;
            } else {
                lbErrHora.Visible = false;
            }

            if (valid) {

                // Lo añado a la tabla
                dgTurnos.Rows.Add(cbDia.Text, horI.toString(), horF.toString(), "", "", tbUbi.Text);

                tbUbi.Text = "";
                cbDia.SelectedIndex = 0;
                udHoraIni.Value = 0;
                udHoraFin.Value = 0;
                udMinFin.Value = 0;
                udMinIni.Value = 0;
            }
        }

        private void dgTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == dgTurnos.Columns["Borrar"].Index) {
                dgTurnos.Rows.RemoveAt(e.RowIndex);
            } else if (e.ColumnIndex == dgTurnos.Columns["Modificar"].Index) {

                if (childMod != null) {
                    selectedRow = e.RowIndex;
                    DataGridViewRow row = dgTurnos.Rows[selectedRow];
                    childMod.setInfo(row.Cells["Dia"].Value.ToString(),
                            row.Cells["HoraInicio"].Value.ToString(),
                            row.Cells["HoraFin"].Value.ToString(),
                            row.Cells["Ubicacion"].Value.ToString());

                    Hide();
                    childMod.Show();

                    AdminForm parent = (AdminForm)this.MdiParent;
                    parent.positionChilds();
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e) {
            if (parentGest != null) {

                // Vacio la tabla
                dgTurnos.Rows.Clear();

                Hide();
                parentGest.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            } else if (parentAdd != null) {
                // Vacio la tabla
                dgTurnos.Rows.Clear();

                Hide();
                parentAdd.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        public void modRow(string dia, string ini, string fin, string ubi) {
            dgTurnos.Rows[selectedRow].SetValues(dia, ini, fin, "", "", ubi);
        }

    }
}
