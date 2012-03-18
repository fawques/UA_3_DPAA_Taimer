using System;
using Taimer;
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

        bool closeSesion = false;

        Taimer.User usuario;

        public ClientBienvenida formWelcome;
        public ClientHorHome formHorHome;
        public ClientHorVer formHorDetails;
        public ClientCrearHor1 formCreateHor1;
        public ClientCrearHor2 formCreateHor2;

        public ClientMatriculacionActiv formMatric;
        public ClientVerActividades formVerAct;
        public ClientCrearActiv formCrearAct;
        
        private void ClientForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;

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

            formWelcome = new ClientBienvenida(this);
            formHorHome = new ClientHorHome();

            formHorDetails = new ClientHorVer();
            //this.formHorDetails.Dock = DockStyle.Fill;
            //this.formHorDetails.WindowState = FormWindowState.Maximized;

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

            //formHorDetails.Show();
            formWelcome.Show();
            //////////////// --- //////////////////////////

            beingDragged = false;
            beingResized = false;

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            pnlMenuHorarios.Focus();
            loadLastHorarios();
            pnlMenuActivi.Focus();
            loadLastActividades();
        }

        private void loadLastHorarios()
        {
            int posY = 20;
            for (int i = 0; i < 10; i++)
            {
                Label auxlbl = new Label();
                auxlbl.Text = "Horario " + i;
                auxlbl.Location = new Point(25, posY);
                auxlbl.Cursor = Cursors.Hand;
                auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                auxlbl.Click += new EventHandler(verHorario_Click);
                auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                posY += 25;
                groupBoxUltimosHorarios.Controls.Add(auxlbl);
            }
        }

        private void loadLastActividades()
        {
            int posY = 20;
            for (int i = 0; i < 10; i++)
            {
                Label auxlbl = new Label();
                auxlbl.Text = "Horario " + i;
                auxlbl.Location = new Point(25, posY);
                auxlbl.Cursor = Cursors.Hand;
                auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                auxlbl.Click += new EventHandler(verHorario_Click);
                auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                posY += 25;
                groupBoxUltActivi.Controls.Add(auxlbl);
            }
        }

        //////////////// MDI //////////////////////////
        public void hideAllChilds()
        {
            //formWelcome.Hide();
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
                Size adj = this.Size;
                if (e.Location.Y - mouseOffset.Y < 0 && e.Location.X - mouseOffset.X < 0) {
                    if (this.Size.Height > 300 && this.Size.Width > 300) {
                        if (this.Size.Width <= 300) {
                            adj = new Size(this.Size.Height, e.Location.Y - mouseOffset.Y);
                        } else if (this.Size.Width <= 300) {
                            adj = new Size(e.Location.X - mouseOffset.X, this.Size.Width);
                        } else {
                            adj = new Size(e.Location.X - mouseOffset.X, e.Location.Y - mouseOffset.Y);
                        }
                        this.Size += adj;
                        mouseOffset = e.Location - adj;  // NOTA: Tienes que mover tambien la localizacion
                    }
                    
                } else {
                    adj = new Size(e.Location.X - mouseOffset.X, e.Location.Y - mouseOffset.Y);
                    this.Size += adj;
                    mouseOffset = e.Location - adj;  // NOTA: Tienes que mover tambien la localizacion
                }
                
               

                this.Refresh();
            }
        }
        /*     ---------------     */


        /** CONSTRUCTOR **/
        public ClientForm(string usr)
        {
            InitializeComponent();
            //TODO: Hay que hacer esto como se tenga que hacer
            Titulacion t = new Titulacion("II", "001");
            User usuario = new User(usr, "11111111P", usr+"@gmail.com", "*****", t, 3);
            userTlSMnItem.Text = usuario.Nombre;

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
            if (!closeSesion) {
                Application.Exit();
            } else {
                Program.loginForm.Show();
            }
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?",
                    "¿Salir?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                        Close();
            }
        }

        private void toolStripCloseSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesión?",
            "¿Cerrar sesión?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                closeSesion = true;
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

                this.formHorDetails.WindowState = FormWindowState.Maximized;
                this.formHorDetails.Dock = DockStyle.Fill;
            }
            else
            {
                //Restauramos la mascara de redondeado
                this.Region = new System.Drawing.Region(shape);
                this.WindowState = FormWindowState.Normal;

                this.formHorDetails.WindowState = FormWindowState.Normal;
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

        private void verHorarios_Click(object sender, EventArgs e)
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

        public void crearHorario_Click(object sender, EventArgs e)
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

        private void verHorario_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formHorDetails.setHorario(new Taimer.Horario("Horario", (new Taimer.User("", "", "", "", new Taimer.Titulacion("", ""), 1))));
            formHorDetails.Show();
            positionAllChilds();
        }

        public void crearActividad_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formCrearAct.Show();
            positionAllChilds();
        }

        private void matriculacion_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formMatric.Show();
            positionAllChilds();
        }

        private void verActividades_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formVerAct.Show();
            positionAllChilds();
        }


        

       

        /**   Cambio de imagen botones **/
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

        private void label_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.White;
        }
        private void label_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Transparent;
        }

        private void pnlMenuHorarios_MouseEnter(object sender, EventArgs e)
        {
            pnlMenuHorarios.Focus();
        }

        private void pnlMenuActivi_MouseEnter(object sender, EventArgs e)
        {
            pnlMenuActivi.Focus();
        }

        private void iconNotifClient_MouseDoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
            ab.Dispose();
        }

        private void btClose_ClientSizeChanged(object sender, EventArgs e) {

        }

        private void btMaximize_MouseEnter(object sender, EventArgs e) {
            btMaximize.Image = TaimerGUI.Properties.Resources.maximizeOn;
        }

        private void btMaximize_MouseLeave(object sender, EventArgs e) {
            btMaximize.Image = TaimerGUI.Properties.Resources.maximizeOff1;
        }

        private void btMaximize_MouseDown(object sender, MouseEventArgs e) {
            btMaximize.Image = TaimerGUI.Properties.Resources.maximizeClick;
        }

        private void btMaximize_MouseUp(object sender, MouseEventArgs e) {
            btMaximize.Image = TaimerGUI.Properties.Resources.maximizeOn;
        }

        private void pnlResize_Paint(object sender, PaintEventArgs e) {

        }

    }
}
