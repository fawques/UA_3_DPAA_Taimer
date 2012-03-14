using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class AGestTurno : Form {
        AGestAsig parentForm = null;

        public AGestTurno() {
            InitializeComponent();
        }

        public void setParent(AGestAsig form) {
            parentForm = form;
        }

        private void btCancel_Click(object sender, EventArgs e) {
            if (parentForm != null) {
                Hide();
                parentForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        private void btConfirm_Click(object sender, EventArgs e) {
            // Compruebo los datos
        }

        private void lbDia_Click(object sender, EventArgs e) {
            cbDia.Text = lbDia.Text;
            lbDia.Visible = false;
            cbDia.Visible = true;
            cbDia.Focus();
        }

        private void cbDia_Validated(object sender, EventArgs e) {
            lbDia.Text = cbDia.Text;
            cbDia.Visible = false;
            lbDia.Visible = true;
        }

        private void lbUbi_Click(object sender, EventArgs e) {
            tbUbi.Text = lbUbi.Text;
            lbUbi.Visible = false;
            tbUbi.Visible = true;
            tbUbi.Focus();
        }

        private void tbUbi_Validated(object sender, EventArgs e) {
            lbUbi.Text = tbUbi.Text;
            tbUbi.Visible = false;
            lbUbi.Visible = true;
            lbUbi.Focus();
        }

        private void lbHoraIni_Click(object sender, EventArgs e) {
            string[] horaMin = lbHoraIni.Text.Split(':');

            udHoraIni.Value = Convert.ToDecimal(horaMin[0]);
            udMinIni.Value = Convert.ToDecimal(horaMin[1]);
            lbHoraIni.Visible = false;
            udHoraIni.Visible = true;
            udMinIni.Visible = true;
            udHoraIni.Focus();
        }

        private void udHoraIni_Validated(object sender, EventArgs e) {
            udMinIni.Focus();
        }

        private void udMinIni_Validated(object sender, EventArgs e) {
            

            lbHoraIni.Text = Convert.ToString(udHoraIni.Value) + ":" + Convert.ToString(udMinIni.Value);
            udHoraIni.Visible = false;
            udMinIni.Visible = false;
            lbHoraIni.Visible = true;
            lbHoraIni.Focus();
        }

    }
}
