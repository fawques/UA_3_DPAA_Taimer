using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI
{
    public partial class ClientBienvenida : Form
    {
        ClientForm padre = null;
        public ClientBienvenida(ClientForm f)
        {
            InitializeComponent();
            padre = f;
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

        private void loadLastHorarios() {
            int posY = 20;
            for (int i = 0; i < 5; i++) {
                Label auxlbl = new Label();
                auxlbl.Text = "Horario " + i;
                auxlbl.Location = new Point(25, posY);
                auxlbl.Cursor = Cursors.Hand;
                auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                auxlbl.Click += new EventHandler(verHorario_Click);
                auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                posY += 25;
                pnlUltimoHorarios.Controls.Add(auxlbl);
            }
        }

        private void loadLastActividades() {
            int posY = 20;
            for (int i = 0; i < 5; i++) {
                Label auxlbl = new Label();
                auxlbl.Text = "Actividad " + i;
                auxlbl.Location = new Point(25, posY);
                auxlbl.Cursor = Cursors.Hand;
                auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                auxlbl.Click += new EventHandler(verActividad_Click);
                auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                posY += 25;
                pnlUltimasActividades.Controls.Add(auxlbl);
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
