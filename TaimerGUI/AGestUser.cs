using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class AGestUser : Form {

        AAddUser childForm = null;

        public AGestUser() {
            InitializeComponent();
        }

        public void setChild(AAddUser form) {
            childForm = form;
        }

        private void btNewUser_Click(object sender, EventArgs e) {
            if (childForm != null) {
                Hide();
                childForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        // Nombre

        private void lbUserName_Click(object sender, EventArgs e) {
            tbName.Text = lbUserName.Text;
            lbUserName.Visible = false;
            tbName.Visible = true;
            tbName.Focus();
        }

        private void tbName_Validated(object sender, EventArgs e) {
            lbUserName.Text = tbName.Text;
            tbName.Visible = false;
            lbUserName.Visible = true;
            btCancel.Enabled = true;
            btConfirm.Enabled = true;
        }

        // Email

        private void lbEmail_Click(object sender, EventArgs e) {
            tbEmail.Text = lbEmail.Text;
            lbEmail.Visible = false;
            tbEmail.Visible = true;
            tbEmail.Focus();
        }

        private void tbEmail_Validated(object sender, EventArgs e) {
            lbEmail.Text = tbEmail.Text;
            tbEmail.Visible = false;
            lbEmail.Visible = true;
            btCancel.Enabled = true;
            btConfirm.Enabled = true;
        }

        // User

        private void lbUser_Click(object sender, EventArgs e) {
            cbUser.Text = lbUser.Text;
            lbUser.Visible = false;
            cbUser.Visible = true;
            cbUser.Focus();
        }

        private void cbUser_Validated(object sender, EventArgs e) {
            lbUser.Text = cbUser.Text;
            cbUser.Visible = false;
            lbUser.Visible = true;
            btCancel.Enabled = true;
            btConfirm.Enabled = true;
        }

        // Dni

        private void lbDni_Click(object sender, EventArgs e) {
            tbDni.Text = lbDni.Text;
            lbDni.Visible = false;
            tbDni.Visible = true;
            tbDni.Focus();
        }

        private void tbDni_Validated(object sender, EventArgs e) {
            lbDni.Text = tbDni.Text;
            tbDni.Visible = false;
            lbDni.Visible = true;
            btCancel.Enabled = true;
            btConfirm.Enabled = true;
        }

        // Curso

        private void lbCurso_Click(object sender, EventArgs e) {
            tbCurso.Text = lbCurso.Text;
            lbCurso.Visible = false;
            tbCurso.Visible = true;
            tbCurso.Focus();
        }

        private void tbCurso_Validated(object sender, EventArgs e) {
            lbCurso.Text = tbCurso.Text;
            tbCurso.Visible = false;
            lbCurso.Visible = true;
            btCancel.Enabled = true;
            btConfirm.Enabled = true;
        }

        // Titulacion

        private void lbTitu_Click(object sender, EventArgs e) {
            tbTitu.Text = lbTitu.Text;
            lbTitu.Visible = false;
            tbTitu.Visible = true;
            tbTitu.Focus();
        }

        private void tbTitu_Validated(object sender, EventArgs e) {
            lbTitu.Text = tbTitu.Text;
            tbTitu.Visible = false;
            lbTitu.Visible = true;
            btCancel.Enabled = true;
            btConfirm.Enabled = true;
        }
    }
}
