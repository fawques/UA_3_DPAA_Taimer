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
    public partial class Login : Form
    {
        bool dragging;
        Point offset;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;
            offset.X = e.X;
            offset.Y = e.Y;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Point p = new Point(currentScreenPos.X - this.offset.X,currentScreenPos.Y - this.offset.Y);
                this.Location = p;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "admin" && textBoxPassword.Text == "admin"){
                Program.adminWindow = new Admin();
                Program.adminWindow.Show();
                Hide();
            }
            else if (textBoxUser.Text == "ruben" && textBoxPassword.Text == "ruben")
            {   
                Program.clientWindow = new Client();
                Program.clientWindow.Show();
                Hide();
            }   
        }
    }
}
