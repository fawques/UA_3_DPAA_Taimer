using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taimer;

namespace TaimerGUI
{
    public partial class ClientBienvenida : Form
    {
        ClientForm padre = null;
        User usrAux = null;
        
        public ClientBienvenida(ClientForm f, User usr)
        {
            InitializeComponent();
            padre = f;
            usrAux = usr;
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            loadLastActividades();
            loadLastHorarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            padre.crearHorario_Click(null, null);
        }

        private void button2_Click(object sender, EventArgs e) {
            padre.crearActividad_Click(null, null);
        }

        public void loadLastHorarios() {
            if (usrAux != null) {
                pnlUltimoHorarios.Controls.Clear();
                int posY = 20;
                foreach (Horario obj in usrAux.Horarios) {
                    Label auxlbl = new Label();
                    auxlbl.Text = obj.Nombre;
                    auxlbl.Tag = obj;
                    auxlbl.Location = new Point(25, posY);
                    auxlbl.Cursor = Cursors.Hand;
                    auxlbl.MouseEnter += new EventHandler(padre.label_MouseEnter);
                    auxlbl.Click += new EventHandler(padre.verHorario_Click);
                    auxlbl.MouseLeave += new EventHandler(padre.label_MouseLeave);
                    posY += 25;
                    pnlUltimoHorarios.Controls.Add(auxlbl);
                }
            }
        }

        public void loadLastActividades() {
            if (usrAux != null) {
                pnlUltimasActividades.Controls.Clear();
                int posY = 20;
                foreach (Actividad_p obj in usrAux.ActPersonales) {
                    //MessageBox.Show("iteracion");
                    Label auxlbl = new Label();
                    auxlbl.Text = obj.Nombre;
                    auxlbl.Tag = obj;
                    auxlbl.Location = new Point(25, posY);
                    auxlbl.Cursor = Cursors.Hand;
                    auxlbl.MouseEnter += new EventHandler(padre.label_MouseEnter);
                    auxlbl.Click += new EventHandler(padre.verActividad_Click);
                    auxlbl.MouseLeave += new EventHandler(padre.label_MouseLeave);
                    posY += 25;
                    pnlUltimasActividades.Controls.Add(auxlbl);
                }
            }
        }

        private void label_MouseEnter(object sender, EventArgs e) {
            ((Label)sender).BackColor = Color.White;
        }
        private void label_MouseLeave(object sender, EventArgs e) {
            ((Label)sender).BackColor = Color.Transparent;
        }
        private void verHorario_Click(object sender, EventArgs e) {
            padre.hideAllChilds();
            padre.formHorDetails.setHorario(null);
            padre.formHorDetails.Show();
            padre.positionAllChilds();
        }
        private void verActividad_Click(object sender, EventArgs e) {
            padre.hideAllChilds();
            padre.formVerAct.Show();
            padre.positionAllChilds();
        }
    }
}
