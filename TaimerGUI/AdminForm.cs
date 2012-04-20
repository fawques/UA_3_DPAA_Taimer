using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class AdminForm : Form {

        ABienvenida bienvenidaForm;
        AGestUser gestionUserForm;
        AGestAsig gestionAsigForm;
        AAddAsig addAsigForm;
        AAddUser addUserForm;
        AGestTurn gestTurnForm;

        int currentForm = 0;

        public AdminForm() {
            InitializeComponent();

            bienvenidaForm = new ABienvenida();
            gestionUserForm = new AGestUser();
            gestionAsigForm = new AGestAsig();
            addAsigForm = new AAddAsig();
            addUserForm = new AAddUser();
            gestTurnForm = new AGestTurn();

            gestionUserForm.setChild(addUserForm);
            addUserForm.setParent(gestionUserForm);

            gestionAsigForm.setChild(addAsigForm, gestTurnForm);
            addAsigForm.setParent(gestionAsigForm);
            addAsigForm.setChild(gestTurnForm);
            addAsigForm.setChild(gestTurnForm);

            bienvenidaForm.MdiParent = this;
            gestionUserForm.MdiParent = this;
            gestionAsigForm.MdiParent = this;
            addAsigForm.MdiParent = this;
            addUserForm.MdiParent = this;
            gestTurnForm.MdiParent = this;
        }

        protected override void OnPaint(PaintEventArgs e) {

            GraphicsPath shape = RoundedRectangle.Create(0, 0, this.Width, this.Height, 10);

            this.Region = new System.Drawing.Region(shape);

        }

        bool beingDragged;
        Point mouseOffset;
        private void pnTop_MouseDown(object sender, MouseEventArgs e) {
            beingDragged = true;
            mouseOffset.X = e.X;
            mouseOffset.Y = e.Y;
        }


        private void pnTop_MouseMove(object sender, MouseEventArgs e) {
            if (this.beingDragged) {
                Point currentScreenPos = PointToScreen(e.Location);
                Point p = new Point(currentScreenPos.X - this.mouseOffset.X, currentScreenPos.Y - this.mouseOffset.Y);
                this.Location = p;
            }
        }

        private void pnTop_MouseUp(object sender, MouseEventArgs e) {
            this.beingDragged = false;
        }

        private void AdminForm_Load(object sender, EventArgs e) {
            beingDragged = false;

            //////////////// MDI //////////////////////////

            //Esto para el color de fondo
            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls) {
                try {
                    // Attempt to cast the control to type MdiClient.
                    MdiClient ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                } catch (InvalidCastException) {
                    // Catch and ignore the error if casting failed.
                }
            }

            bienvenidaForm.Show();
            currentForm = 0;
            //////////////// --- //////////////////////////
        }

      

        private void btSidePanelUser_Click(object sender, EventArgs e) {
            hideChilds();
            gestionUserForm.Show();
            positionChilds();
        }

        private void btSidePanelAsig_Click(object sender, EventArgs e) {
            hideChilds();
            gestionAsigForm.Show();
            positionChilds();
        }

        public void hideChilds() {
            bienvenidaForm.Hide();
            gestionUserForm.Hide();
            gestionAsigForm.Hide();
            gestTurnForm.Hide();
            addAsigForm.Hide();
            addUserForm.Hide();
        }

        public void positionChilds() {
            bienvenidaForm.Location = new Point(0, 0);
            gestionUserForm.Location = new Point(0, 0);
            gestionAsigForm.Location = new Point(0, 0);
            gestTurnForm.Location = new Point(0, 0);
            addAsigForm.Location = new Point(0, 0);
            addUserForm.Location = new Point(0, 0);
        }

        private void label1_Click(object sender, EventArgs e) {
            hideChilds();
            bienvenidaForm.Show();
            positionChilds();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Seguro que desea salir?",
               "¿Salir?",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.OK) {
                Application.Exit();
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Seguro que desea cerrar sesión?",
               "¿Cerrar sesión?",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                Program.loginForm.Show();
                Close();
            }
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e) {
            hideChilds();
            gestionUserForm.Show();
            positionChilds();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e) {
            hideChilds();
            addUserForm.Show();
            positionChilds();
        }

        private void verAsignaturasToolStripMenuItem_Click(object sender, EventArgs e) {
            hideChilds();
            gestionAsigForm.Show();
            positionChilds();
        }

        private void nuevaAsignaturaToolStripMenuItem_Click(object sender, EventArgs e) {
            hideChilds();
            addAsigForm.Show();
            positionChilds();
        }

        /*
       *      Control de los botones de cerrar, maximizar y minimizar
       */

        private void btMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btMaximize_Click(object sender, EventArgs e) {
            //Desactivamos el borderless para hacer el maxmizado normal, si no se pone a pantalla completa
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            if (this.WindowState != FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Maximized;
            } else {
                this.WindowState = FormWindowState.Normal;

            }
            // desactivamos el maximizado para que deje de mostrar el borde
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btClose_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Seguro que desea salir?",
                "¿Salir?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.OK) {
                Application.Exit();
            }
        }

        /**   Cambio de imagen botones **/
        private void btMinimize_MouseEnter(object sender, EventArgs e) {
            btMinimize.Image = TaimerGUI.Properties.Resources.tbMinimizeOn;
        }

        private void btMinimize_MouseLeave(object sender, EventArgs e) {
            btMinimize.Image = TaimerGUI.Properties.Resources.tbMinimizeOff;
        }

        private void btMinimize_MouseDown(object sender, MouseEventArgs e) {
            btMinimize.Image = TaimerGUI.Properties.Resources.tbMinimizeClick;
        }

        private void btMinimize_MouseUp(object sender, MouseEventArgs e) {
            btMinimize.Image = TaimerGUI.Properties.Resources.tbMinimizeOn;
        }

        private void btClose_MouseEnter(object sender, EventArgs e) {
            btClose.Image = TaimerGUI.Properties.Resources.tbCloseOn;
        }

        private void btClose_MouseLeave(object sender, EventArgs e) {
            btClose.Image = TaimerGUI.Properties.Resources.tbCloseOff;
        }

        private void btClose_MouseDown(object sender, MouseEventArgs e) {
            btClose.Image = TaimerGUI.Properties.Resources.tbCloseClick;
        }

        private void btClose_MouseUp(object sender, MouseEventArgs e) {
            btClose.Image = TaimerGUI.Properties.Resources.tbCloseOn;
        }

        private void btMaximize_MouseEnter(object sender, EventArgs e) {
            btMaximize.Image = TaimerGUI.Properties.Resources.maximizeOn;
        }

        private void btMaximize_MouseLeave(object sender, EventArgs e) {
            btMaximize.Image = TaimerGUI.Properties.Resources.maximizeOff1;
        }

        private void btMaximize_MouseDown(object sender, MouseEventArgs e) {
            btMaximize.Image = TaimerGUI.Properties.Resources.maximizeClick;
        }

        private void btMaximize_MouseUp(object sender, MouseEventArgs e) {
            btMaximize.Image = TaimerGUI.Properties.Resources.maximizeOn;
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
            ab.Dispose();
        }
    }
}
