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
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e) {

            GraphicsPath shape = RoundedRectangle.Create(0, 0, this.Width, this.Height + 10, 5);
            
            PathGradientBrush pgb = new PathGradientBrush(shape);

            pgb.CenterPoint = new PointF(this.Width / 2,
                                         this.Height / 2);
            pgb.CenterColor = Color.White;
            pgb.SurroundColors = new Color[] { Color.Cornsilk };

            e.Graphics.FillPath(pgb, shape);
            
            this.Region = new System.Drawing.Region(shape);

        }

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams {
            get {
                CreateParams p = base.CreateParams;
                p.ClassStyle |= CS_DROPSHADOW;
                return p;
            }
        }

        bool beingDragged;
        Point mouseOffset;
        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            beingDragged = true;
            mouseOffset.X = e.X;
            mouseOffset.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if (this.beingDragged) {
                Point currentScreenPos = PointToScreen(e.Location);
                Point p = new Point(currentScreenPos.X - this.mouseOffset.X, currentScreenPos.Y - this.mouseOffset.Y);
                this.Location = p;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e) {
            this.beingDragged = false;
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            beingDragged = false;
        }

        private void btClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btLoginEntrar_Click(object sender, EventArgs e) {

            // Cojemos el usuario
            string user = tbLoginUser.Text;

            // Cojemos el password
            string pass = tbLoginPassword.Text;

            // Comprobamos si es una combinacion correcta
            int loginStatus = checkUserPass(user, pass);

            switch (loginStatus) {
                case 0:     // Combinación incorrecta
                    lbLoginBadUserPass.Visible = true;
                    break;

                case 1:     // Es un administrador
                    lbLoginBadUserPass.Visible = false;
                    AdminForm administrator = new AdminForm();
                    administrator.Show();
                    this.Hide();
                    break;

                case 2:     // Es un usuario
                    lbLoginBadUserPass.Visible = false;
                    ClientForm client = new ClientForm();
                    client.Show();
                    this.Hide();
                    break;
            }
        }

        private int checkUserPass(string usuario, string password) {

            if (usuario == "admin" && password == "admin")
                return 1;
            
            if (usuario == "user" && password == "user")
                return 2;

            return 0;
        }

        private void btMinimize_MouseEnter(object sender, EventArgs e) {
            // Cambiamos la imagen del boton por la del boton resaltado
        }

        private void btMinimize_MouseLeave(object sender, EventArgs e) {
            // Cambiamos la imagen del boton por la del boton normal
        }

        private void btClose_MouseEnter(object sender, EventArgs e) {
            // Cambiamos la imagen del boton por la del boton resaltado
        }

        private void btClose_MouseLeave(object sender, EventArgs e) {
            // Cambiamos la imagen del boton por la del boton normal
        }
    }
}
