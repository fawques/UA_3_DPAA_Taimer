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

        public Login()
        {
            InitializeComponent();
            minimizeButton.FlatAppearance.BorderSize = 0;
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
            loginIn();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            minimizeButton.ForeColor = Color.White;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter){//si se presiona la tecla enter
                loginIn();
            }
        }


        /* Funcion que logea y lanza la ventana correspondiente
         * 
         */
        private void loginIn()
        {
            if (textBoxUser.Text == "admin" && textBoxPassword.Text == "admin")
            {
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
