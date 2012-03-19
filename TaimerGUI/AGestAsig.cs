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
    }
}
