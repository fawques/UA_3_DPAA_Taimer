using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taimer;

namespace TaimerGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            GraphicsPath shape = RoundedRectangle.Create(0, 0, this.Width, this.Height, 10);

            PathGradientBrush pgb = new PathGradientBrush(shape);

            pgb.CenterPoint = new PointF(this.Width * 2 / 3, this.Height / 2);
            pgb.CenterColor = Color.White;
            pgb.SurroundColors = new Color[] { Color.Cornsilk };

            e.Graphics.FillPath(pgb, shape);

            this.Region = new System.Drawing.Region(shape);

        }

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams p = base.CreateParams;
                p.ClassStyle |= CS_DROPSHADOW;
                return p;
            }
        }

        bool beingDragged;
        Point mouseOffset;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            beingDragged = true;
            mouseOffset.X = e.X;
            mouseOffset.Y = e.Y;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btLoginEntrar_Click(object sender, EventArgs e)
        {

            // Cojemos el usuario
            string user = tbLoginUser.Text;

            // Cojemos el password
            string pass = tbLoginPassword.Text;

            // Comprobamos si es una combinacion correcta
            int loginStatus = checkUserPass(user, pass);

            switch (loginStatus)
            {
                case 0:     // Combinación incorrecta
                    lbLoginBadUserPass.Visible = true;
                    break;

                case 1:     // Es un administrador
                    lbLoginBadUserPass.Visible = false;
                    if (!cbLoginRemeberData.Checked)
                    {
                        tbLoginUser.Text = "";
                        tbLoginPassword.Text = "";
                    }
                    AdminForm administrator = new AdminForm();
                    administrator.Show();
                    this.Hide();
                    break;

                case 2:     // Es un usuario
                    lbLoginBadUserPass.Visible = false;
                    if (!cbLoginRemeberData.Checked)
                    {
                        tbLoginUser.Text = "";
                        tbLoginPassword.Text = "";
                    }
                    ClientForm client = new ClientForm(null);//TODO
                    client.Show();
                    this.Hide();
                    break;
            }
            
        }

        private int checkUserPass(string usuario, string password)
        {
            try
            {
                if (rbCliente.Checked)
                {
                    if(Program.Usuarios.Count == 0)
                        Program.Usuarios.Add(Taimer.User.CheckLoginUser(usuario, password));
                    else
                        Program.Usuarios[0] = Taimer.User.CheckLoginUser(usuario, password);
                    Program.Asignaturas = Actividad_a.GetAllActividades_a();
                    return 2;
                }
                else
                {
                    Program.Usuarios = Taimer.User.CheckLoginAdmin(usuario, password);
                    Program.Asignaturas = Actividad_a.GetAllActividades_a();
                    return 1;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /*
         *      Cambio de los iconos al pasar el raton por encima
         */

        private void btMinimize_MouseEnter(object sender, EventArgs e)
        {
            btMinimize.Image = TaimerGUI.Properties.Resources.tbMinimizeOn;
        }

        private void btMinimize_MouseLeave(object sender, EventArgs e)
        {
            btMinimize.Image = TaimerGUI.Properties.Resources.tbMinimizeOff;
        }

        private void btMinimize_MouseDown(object sender, MouseEventArgs e)
        {
            btMinimize.Image = TaimerGUI.Properties.Resources.tbMinimizeClick;
        }

        private void btMinimize_MouseUp(object sender, MouseEventArgs e)
        {
            btMinimize.Image = TaimerGUI.Properties.Resources.tbMinimizeOn;
        }

        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            btClose.Image = TaimerGUI.Properties.Resources.tbCloseOn;
        }

        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.Image = TaimerGUI.Properties.Resources.tbCloseOff;
        }

        private void btClose_MouseDown(object sender, MouseEventArgs e)
        {
            btClose.Image = TaimerGUI.Properties.Resources.tbCloseClick;
        }

        private void btClose_MouseUp(object sender, MouseEventArgs e)
        {
            btClose.Image = TaimerGUI.Properties.Resources.tbCloseOn;
        }

        /*
         *      Control del arrastrado de la ventana
         */

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.beingDragged)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Point p = new Point(currentScreenPos.X - this.mouseOffset.X, currentScreenPos.Y - this.mouseOffset.Y);
                this.Location = p;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.beingDragged = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            beingDragged = false;
        }

        private void lbTaimer_MouseDown(object sender, MouseEventArgs e)
        {
            panel1_MouseDown(sender, e);
        }

        private void lbTaimer_MouseMove(object sender, MouseEventArgs e)
        {
            panel1_MouseMove(sender, e);
        }

        private void lbTaimer_MouseUp(object sender, MouseEventArgs e)
        {
            panel1_MouseUp(sender, e);
        }

        private void pnSystemButtons_MouseDown(object sender, MouseEventArgs e)
        {
            panel1_MouseDown(sender, e);
        }

        private void pnSystemButtons_MouseMove(object sender, MouseEventArgs e)
        {
            panel1_MouseMove(sender, e);
        }

        private void pnSystemButtons_MouseUp(object sender, MouseEventArgs e)
        {
            panel1_MouseUp(sender, e);
        }


        //Puente para no tardar tanto en abrir la ventana
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.Usuarios.Count == 0)
                Program.Usuarios.Add(User.CheckLoginUser("alberto@alberto.es", "alberto"));
            else
                Program.Usuarios[0] = User.CheckLoginUser("alberto@alberto.es", "alberto");
            Program.Asignaturas = Actividad_a.GetAllActividades_a();
            ClientForm client = new ClientForm(null);
            
            client.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Usuarios = Taimer.User.CheckLoginAdmin("admin@admin.com", "admin");
            Program.Asignaturas = Actividad_a.GetAllActividades_a();
            AdminForm admin = new AdminForm();
            admin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Usuarios = Taimer.User.CheckLoginAdmin("admin@admin.com", "admin");
            Program.Usuarios.Insert(0,User.CheckLoginUser("alberto@alberto.es", "alberto"));
            Program.Asignaturas = Actividad_a.GetAllActividades_a();
            ClientForm client = new ClientForm(null);
            client.Show();
            this.Hide();
            AdminForm admin = new AdminForm();
            admin.Show();
            this.Hide();
        }

        private void llIrAWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.taimer.com/home.aspx");
        }

    }
}
