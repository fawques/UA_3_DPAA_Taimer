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
    }
}
