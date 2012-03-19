using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class AModiTurn : Form {
        AGestTurn parentForm = null;

        public AModiTurn() {
            InitializeComponent();
        }

        public void setParent(AGestTurn form) {
            parentForm = form;
        }

        public void hideEditable() {
            cbDia.Visible = false;
            udHoraIni.Visible = false;
            udMinIni.Visible = false;
            udHoraFin.Visible = false;
            udMinFin.Visible = false;
            tbUbi.Visible = false;
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
            bool valid = true;

            // Ubi
            if (tbUbi.Text == "") {
                lbErrUbi.Visible = true;
                valid = false;
            } else {
                lbErrUbi.Visible = false;
            }

            // Hora
            Taimer.Hora horI = new Taimer.Hora((int)udHoraIni.Value, (int)udMinIni.Value);
            Taimer.Hora horF = new Taimer.Hora((int)udHoraFin.Value, (int)udMinFin.Value);

            if (horI > horF) {
                lbErrHora.Visible = true;
                valid = false;
            } else {
                lbErrHora.Visible = false;
            }


            if (valid && parentForm != null) {

                parentForm.modRow(cbDia.Text, horI.toString(), horF.toString(), tbUbi.Text);

                Hide();
                parentForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }

        }

        private void lbDia_Click(object sender, EventArgs e) {
            cbDia.Text = lbDia.Text;

            hideEditable();
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

            hideEditable();
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

            hideEditable();
            lbHoraIni.Visible = false;
            udHoraIni.Visible = true;
            udMinIni.Visible = true;
            udHoraIni.Focus();
        }

        private void udHoraIni_Validated(object sender, EventArgs e) {
            udMinIni.Focus();
        }

        private void udMinIni_Validated(object sender, EventArgs e) {

            Taimer.Hora horaIni = new Taimer.Hora((int)udHoraIni.Value, (int) udMinIni.Value);
            lbHoraIni.Text = horaIni.toString();
            udHoraIni.Visible = false;
            udMinIni.Visible = false;
            lbHoraIni.Visible = true;
            lbHoraIni.Focus();
        }

        private void lbHoraFin_Click(object sender, EventArgs e) {
            string[] horaMin = lbHoraFin.Text.Split(':');

            udHoraFin.Value = Convert.ToDecimal(horaMin[0]);
            udMinFin.Value = Convert.ToDecimal(horaMin[1]);

            hideEditable();
            lbHoraFin.Visible = false;
            udHoraFin.Visible = true;
            udMinFin.Visible = true;
            udHoraFin.Focus();
        }

        private void udHoraFin_Validated(object sender, EventArgs e) {
            udMinFin.Focus();
        }

        private void udMinFin_Validated(object sender, EventArgs e) {
            Taimer.Hora horaFin = new Taimer.Hora((int)udHoraFin.Value, (int)udMinFin.Value);
            lbHoraFin.Text = horaFin.toString();
            udHoraFin.Visible = false;
            udMinFin.Visible = false;
            lbHoraFin.Visible = true;
            lbHoraFin.Focus();
        }

        public void setInfo(string dia, string ini, string fin, string ubi) {
            lbDia.Text = dia;
            lbHoraIni.Text = ini;
            lbHoraFin.Text = fin;
            lbUbi.Text = ubi;
        }

    }
}
