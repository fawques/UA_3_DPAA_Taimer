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
        int currentForm;

        public AdminForm() {
            InitializeComponent();

            bienvenidaForm = new ABienvenida();
            bienvenidaForm.PointToClient(new Point(0, 0));
            bienvenidaForm.MdiParent = this;

            gestionUserForm = new AGestUser();
            gestionUserForm.PointToClient(new Point(0, 0));
            gestionUserForm.MdiParent = this;

            gestionAsigForm = new AGestAsig();
            gestionAsigForm.MdiParent = this;

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
                } catch (InvalidCastException exc) {
                    // Catch and ignore the error if casting failed.
                }
            }

            bienvenidaForm.Show();
            currentForm = 0;
            //////////////// --- //////////////////////////
        }

        /*
         *      Control de los botones de cerrar, maximizar y minimizar
         */

        private void btMinimize_MouseClick(object sender, MouseEventArgs e) {
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
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btSidePanelUser_Click(object sender, EventArgs e) {
            hideCurrent();
            currentForm = 1;

            gestionUserForm.Show();
            gestionUserForm.Location = new Point(0, 0);
        }

        private void btSidePanelAsig_Click(object sender, EventArgs e) {
            hideCurrent();
            currentForm = 2;

            gestionAsigForm.Show();
            gestionAsigForm.Location = new Point(0, 0);
        }

        private void btSidePanelEstad_Click(object sender, EventArgs e) {

        }

        private void hideCurrent() {
            switch (currentForm) {
                case 0:
                    bienvenidaForm.Hide();
                    break;
                case 1:
                    gestionUserForm.Hide();
                    break;
                case 2:
                    gestionAsigForm.Hide();
                    break;
            }
        }
    }
}
