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

        private User usuario = null;

        public ClientBienvenida formWelcome;
        public ClientHorHome formHorHome;
        public ClientHorVer formHorDetails;
        public ClientCrearHor1 formCreateHor1;
        public ClientCrearHor2 formCreateHor2;

        public ClientMatriculacionActiv formMatric;
        public ClientVerActividades formVerAct;
        public ClientCrearActiv formCrearAct;
        public ClientGestTurno formGestTurnos;

        /** CONSTRUCTOR **/
        public ClientForm(User usr) {
            InitializeComponent();
            // Aquí debería llamar a la función que cargue desde la BD
            usuario = Program.Usuarios[0];

            //Redondeado de bordes
            shape = RoundedRectangle.Create(0, 0, this.Width, this.Height, 10);
            this.Region = new System.Drawing.Region(shape);
        }

        public User getUsuario() {
            return usuario;
        }

        //FUNCION SOLO PARA DEBUG, LUEGO BORRAR
        private User generateUserDebug() {
            // el user será el 1er elemento de la lista de users de Program
            User usertest = new User("Usuario Test", "12345678X", "bill_gates@hotmail.com", "password", 1, "Ingeniería de Magisterio");

            // los turnos y actividades estarán almacenadas en Program
            Turno t1 = new Turno(new Hora(10, 30), new Hora(12, 30), dias.M, "L04");
            Turno t2 = new Turno(new Hora(11, 30), new Hora(13, 30), dias.L, "L04");
            Turno t3 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.M, "L04");
            Turno t4 = new Turno(new Hora(10, 30), new Hora(12, 30), dias.X, "L04");
            Turno t5 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.X, "L04");
            Turno t6 = new Turno(new Hora(14, 30), new Hora(16, 30), dias.L, "L04");
            Turno t7 = new Turno(new Hora(10, 30), new Hora(14, 30), dias.M, "L04");
            Turno t8 = new Turno(new Hora(11, 30), new Hora(14, 30), dias.V, "L04");
            Turno t9 = new Turno(new Hora(0, 30), new Hora(1, 30), dias.L, "L04");

            Actividad_p actP = new Actividad_p("P1", "Asignatura P1 que descripcion 1", 6, usertest);
            actP.AddTurno(t1);

            Actividad_p actP2 = new Actividad_p("P2", "Otra cosa muy distinta a la uno", 7, usertest);
            actP2.AddTurno(t4);
            actP2.AddTurno(t5);
            actP2.AddTurno(t6);

            usertest.AddActPersonal(actP);
            usertest.AddActPersonal(actP2);

            Actividad_a actA = new Actividad_a("A1", "descripcion2", 8, "Un profesor");
            actA.AddTurno(t2);
            actA.AddTurno(t3);

            Actividad_a actA2 = new Actividad_a("A2", "descripcion2", 9, "Otro profesor");
            actA2.AddTurno(t7);
            //actA2.AddTurno(t8);
            actA2.AddTurno(t9);
            usertest.AddActAcademica(actA);
            usertest.AddActAcademica(actA2);
            
            return usertest;
        }
        
        private void ClientForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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
          
            formWelcome = new ClientBienvenida(this,usuario);
            formHorHome = new ClientHorHome();
            formHorDetails = new ClientHorVer();
            formCreateHor1 = new ClientCrearHor1(usuario);
            formCreateHor2 = new ClientCrearHor2(usuario);
            formMatric = new ClientMatriculacionActiv(usuario);
            formGestTurnos = new ClientGestTurno();
            formVerAct = new ClientVerActividades(usuario, formGestTurnos);
            formCrearAct = new ClientCrearActiv(usuario);

            

            //Para comunicarse entre ellos
            formCreateHor1.setContinueForm(formCreateHor2);
            formCreateHor2.setBackForm(formCreateHor1);
            formGestTurnos.setFormBack(formVerAct);

            formWelcome.MdiParent = this;
            formHorHome.MdiParent = this;
            formHorDetails.MdiParent = this;
            formCreateHor1.MdiParent = this;
            formCreateHor2.MdiParent = this;
            formMatric.MdiParent = this;
            formVerAct.MdiParent = this;
            formCrearAct.MdiParent = this;
            formGestTurnos.MdiParent = this;



            formWelcome.Show();
            formHorHome.Show();
            formHorDetails.Show();
            formCreateHor1.Show();
            formCreateHor2.Show();
            formMatric.Show();
            formVerAct.Show();
            formCrearAct.Show();
            formGestTurnos.Show();
            formWelcome.Show();
            formWelcome.Focus();
            //////////////// --- //////////////////////////


            loadLastHorarios();
            loadLastActividades();

            beingDragged = false;
            beingResized = false;

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);


            this.WindowState = FormWindowState.Normal;
        }

        public void loadLastHorarios()
        {
            if (usuario != null) {
                groupBoxUltimosHorarios.Controls.Clear();
                int posY = 20;
                foreach (Horario obj in usuario.Horarios) {
                    Label auxlbl = new Label();
                    auxlbl.Text = obj.Nombre;
                    auxlbl.Tag = obj;
                    auxlbl.Location = new Point(25, posY);
                    auxlbl.Cursor = Cursors.Hand;
                    auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                    auxlbl.Click += new EventHandler(verHorario_Click);
                    auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                    posY += 25;
                    groupBoxUltimosHorarios.Controls.Add(auxlbl);
                }
                formWelcome.loadLastHorarios();
            }
        }

        public void loadLastActividades()
        {
            if (usuario != null) {
                //MessageBox.Show("No es null");
                groupBoxUltActivi.Controls.Clear();
                int posY = 20;
                foreach (Actividad_p obj in usuario.ActPersonales){
                    //MessageBox.Show("iteracion");
                    Label auxlbl = new Label();
                    auxlbl.Text = obj.Nombre;
                    auxlbl.Tag = obj;
                    auxlbl.Location = new Point(25, posY);
                    auxlbl.Cursor = Cursors.Hand;
                    auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                    auxlbl.Click += new EventHandler(verActividad_Click);
                    auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                    posY += 25;
                    groupBoxUltActivi.Controls.Add(auxlbl);
                }
                formWelcome.loadLastActividades();
            }
        }

        //////////////// MDI //////////////////////////
        public void hideAllChilds()
        {
            /*formWelcome.Hide();
            formHorHome.Hide();
            formHorDetails.Hide();
            formCreateHor1.Hide();
            formCreateHor2.Hide();
            formMatric.Hide();
            formVerAct.Hide();
            formCrearAct.Hide();*/
        }

        public void positionAllChilds()
        {
            //Esto se tiene que poder hacer mas facil
            /*formWelcome.Location = new Point(0, 0);
            formHorHome.Location = new Point(0, 0);
            formHorDetails.Location = new Point(0, 0);
            formCreateHor1.Location = new Point(0, 0);
            formCreateHor2.Location = new Point(0, 0);
            formMatric.Location = new Point(0, 0);
            formVerAct.Location = new Point(0, 0);
            formCrearAct.Location = new Point(0, 0);*/
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

        public void verHorarios_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formHorHome.Show();
            formHorHome.Focus();
            positionAllChilds();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formHorHome.Show();
            formWelcome.Focus();
            positionAllChilds();
        }

        public void crearHorario_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formCreateHor1.reiniciar();
            formCreateHor1.Show();
            formCreateHor1.Focus();
            positionAllChilds();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formHorHome.Show();
            formHorHome.Focus();
            positionAllChilds();
        }

        public void verHorario_Click(object sender, EventArgs e)
        {
            if (sender is Label) {
                if (((Label)sender).Tag is Horario) {
                    Horario hor = (Horario)((Label)sender).Tag;
                    formHorDetails.setHorario(hor);
                }
            }
            formHorDetails.Show();
            formHorDetails.Focus();
        }


        public void verActividad_Click(object sender, EventArgs e) {
            Actividad_p act = null;
            if (sender is Label) {
                if (((Label)sender).Tag is Actividad_p) {
                    act = (Actividad_p)((Label)sender).Tag;
                }
            }
            formVerAct.Show();
            formVerAct.Focus();
            formVerAct.loadGrupBoxData(act);
        }

        public void crearActividad_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formCrearAct.Show();
            formCrearAct.Focus();
            positionAllChilds();
        }

        private void matriculacion_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formMatric.Show();
            formMatric.Focus();
            positionAllChilds();
        }

        private void verActividades_Click(object sender, EventArgs e)
        {
            hideAllChilds();
            formVerAct.Show();
            formVerAct.Focus();
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

        public void label_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.White;
        }
        public void label_MouseLeave(object sender, EventArgs e)
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
