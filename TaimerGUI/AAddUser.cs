using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class AAddUser : Form {

        AGestUser parentForm = null;

        public AAddUser() {
            InitializeComponent();
        }

        public void setParent(AGestUser form) {
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

        private void btCreate_Click(object sender, EventArgs e) {
            bool valid = true;

            // Nombre
            if (tbName.Text == "") {
                lbErrName.Visible = true;
                valid = false;
            } else {
                lbErrName.Visible = false;
            }

            // Apellidos
            if (tbApell.Text == "") {
                lbErrApell.Visible = true;
                valid = false;
            } else {
                lbErrApell.Visible = false;
            }

            // Email
            Regex emailRegex = new Regex("[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}");
            if (tbEmail.Text == "") {
                lbErrEmail.Visible = true;
                lbErrEmailBad.Visible = false;
                valid = false;
            } else if (!emailRegex.IsMatch(tbDni.Text)) {
                lbErrEmail.Visible = false;
                lbErrEmailBad.Visible = true;
                valid = false;
            } else {
                lbErrEmail.Visible = false;
                lbErrEmailBad.Visible = false;
            }

            // DNI
            if (tbDni.Text == "") {
                lbErrDni.Visible = true;
                valid = false;
            } else {
                lbErrDni.Visible = false;
            }

            // Curso
            if (tbCurso.Text == "") {
                lbErrCurso.Visible = true;
                valid = false;
            } else {
                lbErrCurso.Visible = false;
            }

            // Titulacion
            if (tbTitu.Text == "") {
                lbErrTitu.Visible = true;
                valid = false;
            } else {
                lbErrTitu.Visible = false;
            }


            if (parentForm != null && valid) {

                tbName.Text = "";
                tbDni.Text = "";
                tbApell.Text = "";
                tbDni.Text = "";
                tbCurso.Text = "";
                tbTitu.Text = "";

                Hide();
                parentForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }

        }

    }
}
