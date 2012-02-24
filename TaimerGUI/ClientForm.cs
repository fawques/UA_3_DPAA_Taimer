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
    public partial class ClientForm : Form {

        bool exitOfAplication = false;
        bool closeForm = false;

        /*     MOVER VENTANA     */
        bool beingDragged;
        Point mouseOffset;

        private void pnlTittle_MouseDown(object sender, MouseEventArgs e)
        {
            this.beingDragged = true;
            this.mouseOffset.X = e.X;
            this.mouseOffset.Y = e.Y;
        }

        private void pnlTittle_MouseUp(object sender, MouseEventArgs e)
        {
            this.beingDragged = false;
        }

        private void pnlTittle_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.beingDragged)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Point p = new Point(currentScreenPos.X - this.mouseOffset.X, currentScreenPos.Y - this.mouseOffset.Y);
                this.Location = p;
            }
        }
        /*     ---------------     */

        
        public ClientForm() {
            InitializeComponent();
            //Redondeado de bordes
            GraphicsPath shape = RoundedRectangle.Create(0, 0, this.Width, this.Height, 10);
            this.Region = new System.Drawing.Region(shape);
        }

        /*     ---------------     */


        //////////////// MDI //////////////////////////
        private void ClientForm_Load(object sender, EventArgs e)
        {
            Bienvenida init = new Bienvenida();
            init.PointToClient(new Point(150, 150));

            init.MdiParent = this;
            init.Show();
            init.Location = new Point(100, 100);

            exitOfAplication = false;
            beingDragged = false;
        }

        private void iconNotifClient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitOfAplication)
            {
                if (!closeForm)
                {
                    e.Cancel = true;
                    Hide();
                }
            }
            else
            {
                Application.Exit();
            }
                
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            exitOfAplication = true;
            Close();
        }

        private void toolStripCloseSesion_Click(object sender, EventArgs e)
        {
            closeForm = true;
            Program.loginForm.Show();
            Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?",
                "¿Salir?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                exitOfAplication = true;
                Close();
            }
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btMaximize_Click(object sender, EventArgs e)
        {
            //Desactivamos el borderless para hacer el maxmizado normal, si no se pone a pantalla completa
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
            // desactivamos el maximizado para que deje de mostrar el borde
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://penis.com/");
        }

        

    }
}
