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
        public AdminForm() {
            InitializeComponent();
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
            Application.Exit();
        }

        private void iconNotifAdmin_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
        
        }

        private void btSidePanelUser_Click(object sender, EventArgs e) {
            lbProvisional.Text = "Gestion de Usuarios";
        }

        private void btSidePanelAsig_Click(object sender, EventArgs e) {
            lbProvisional.Text = "Gestion de Asignaturas";
        }

        private void btSidePanelEstad_Click(object sender, EventArgs e) {
            lbProvisional.Text = "Estadisticas de uso";
        }
    }
}
