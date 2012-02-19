using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rubenDesign
{
    public partial class Client : Form
    {
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        bool dragging;
        Point offset;
        public Client()
        {
            InitializeComponent();
            this.dragging = false;
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;
            offset.X = e.X;
            offset.Y = e.Y;
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Point p = new Point(currentScreenPos.X - this.offset.X, currentScreenPos.Y - this.offset.Y);
                this.Location = p;
            }
        }
        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void buttonExitClient_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCloseSession_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.loginWindow.Show();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeButton_MouseMove(object sender, MouseEventArgs e)
        {
            minimizeButton.ForeColor = Color.White;
        }

        private void Buton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void buttonClose_MouseMove(object sender, MouseEventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.ForeColor = Color.Black;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Image = rubenDesign.Properties.Resources.maxmimizebuttonWhite;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = rubenDesign.Properties.Resources.maxmimizebutton;
        }

        private void buttonGotoWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.es");
        }

        private void Client_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((keyData & Keys.Alt) == Keys.Alt)
            {
                menuStripMain.Visible = !menuStripMain.Visible;
                return true;
            }
            else
                return base.ProcessDialogKey(keyData);
        }

        
    }
}
