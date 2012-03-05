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

        ClientBienvenida formWelcome;
        ClientHorHome formHorHome;
        ClientHorVer formHorDetails;
        ClientCrearHor1 formCreateHor1;
        ClientCrearHor2 formCreateHor2;

        ClientMatriculacionActiv formMatric;
        ClientVerActividades formVerAct;
        ClientCrearActiv formCrearAct;
        
        private void ClientForm_Load(object sender, EventArgs e)
        {
            //////////////// MDI //////////////////////////

            //Esto para el color de fondo
            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    MdiClient ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }

            formWelcome = new ClientBienvenida();
            formHorHome = new ClientHorHome();
            formHorDetails = new ClientHorVer();
            formCreateHor1 = new ClientCrearHor1();
            formCreateHor2 = new ClientCrearHor2();
            formMatric = new ClientMatriculacionActiv();
            formVerAct = new ClientVerActividades();
            formCrearAct = new ClientCrearActiv();

            

            //Para comunicarse entre ellos
            formCreateHor1.setContinueForm(formCreateHor2);
            formCreateHor2.setBackForm(formCreateHor1);

            formWelcome.MdiParent = this;
            formHorHome.MdiParent = this;
            formHorDetails.MdiParent = this;
            formCreateHor1.MdiParent = this;
            formCreateHor2.MdiParent = this;
            formMatric.MdiParent = this;
            formVerAct.MdiParent = this;
            formCrearAct.MdiParent = this;


            formWelcome.Show();
            //////////////// --- //////////////////////////


            exitOfAplication = false;
            beingDragged = false;
            beingResized = false;

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //////////////// MDI //////////////////////////
        public void hideAllChilds()
        {
            formWelcome.Hide();
            formHorHome.Hide();
            formHorDetails.Hide();
            formCreateHor1.Hide();
            formCreateHor2.Hide();
            formMatric.Hide();
            formVerAct.Hide();
            formCrearAct.Hide();
        }

        public void positionAllChilds()
        {
            //Esto se tiene que poder hacer mas facil
            formWelcome.Location = new Point(0, 0);
            formHorHome.Location = new Point(0, 0);
            formHorDetails.Location = new Point(0, 0);
            formCreateHor1.Location = new Point(0, 0);
            formCreateHor2.Location = new Point(0, 0);
            formMatric.Location = new Point(0, 0);
            formVerAct.Location = new Point(0, 0);
            formCrearAct.Location = new Point(0, 0);
        }
        //////////////// --- //////////////////////////


        //Mascara de redondeado inicializada en el constructor
        GraphicsPath shape;

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



        /*     Redimensionar VENTANA     */
        bool beingResized = false;
        
        private void pnlResize_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                //Quitamos la mascara de redondeado
                this.Region = new Region();

                this.beingResized = true;
                this.mouseOffset = e.Location;
            }
            
        }

        private void pnlResize_MouseUp(object sender, MouseEventArgs e)
        {
            if (beingResized)
            {
                this.beingResized = false;
                // Recalculamos la mascara de recorte
                shape = RoundedRectangle.Create(0, 0, this.Width, this.Height, 10);
                //Aplicamos la mascara
                this.Region = new System.Drawing.Region(shape);
            }
            
        }

        private void pnlResize_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.beingResized)
            {

                Size adj = new Size(e.Location.X - mouseOffset.X, e.Location.Y - mouseOffset.Y);
                this.Size += adj;
                mouseOffset = e.Location - adj;  // NOTA: Tienes que mover tambien la localizacion

                this.Refresh();
            }
        }
        /*     ---------------     */
        


        public ClientForm() {
            InitializeComponent();

            //Redondeado de bordes
            shape = RoundedRectangle.Create(0, 0, this.Width, this.Height, 10);
            this.Region = new System.Drawing.Region(shape);
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
                //Quitamos la mascara de redondeado
                this.Region = new Region();
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                //Restauramos la mascara de redondeado
                this.Region = new System.Drawing.Region(shape);
                this.WindowState = FormWindowState.Normal;
            }
            // desactivamos el maximizado para que deje de mostrar el borde
            this.FormBorderStyle = FormBorderStyle.None;
            
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://plus.google.com/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.es/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formHorHome.Show();
            positionAllChilds();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formWelcome.Show();
            positionAllChilds();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formCreateHor1.Show();
            positionAllChilds();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formHorHome.Show();
            positionAllChilds();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formHorDetails.Show();
            positionAllChilds();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formCrearAct.Show();
            positionAllChilds();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formMatric.Show();
            positionAllChilds();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formVerAct.Show();
            positionAllChilds();
        }


        

       


        

    }
}
