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
    public partial class ClientHorHome : Form
    {
        private User usrAux = null;
        private ClientHorVer verHorForm = null;
        public ClientHorHome(User usr, ClientHorVer f)
        {
            InitializeComponent();
            usrAux = usr;
            verHorForm = f;
        }

        private void ClientHorHome_Activated(object sender, EventArgs e) {
            this.loadHorarios();
        }
        public void loadHorarios() {
            if (usrAux != null) {
                pnlHorarios.Controls.Clear();
                int posY = 10;
                foreach (Horario hor in usrAux.Horarios) {
                    Label auxlbl = new Label();
                    auxlbl.AutoSize = false;
                    auxlbl.Width = 275;
                    auxlbl.Text = hor.Nombre;
                    auxlbl.Tag = hor;
                    auxlbl.Location = new Point(25, posY);
                    auxlbl.Cursor = Cursors.Hand;
                    auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                    auxlbl.Click += new EventHandler(label_Click);
                    auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                    posY += 25;
                    pnlHorarios.Controls.Add(auxlbl);
                }
            }
        }
        public void loadHorarios(string patron) {
            if (usrAux != null) {
                pnlHorarios.Controls.Clear();
                int posY = 10;
                foreach (Horario hor in usrAux.Horarios) {
                    if (hor.Nombre.ToLower().Contains(patron.ToLower())) {
                        Label auxlbl = new Label();
                        auxlbl.AutoSize = false;
                        auxlbl.Width = 275;
                        auxlbl.Text = hor.Nombre;
                        auxlbl.Tag = hor;
                        auxlbl.Location = new Point(25, posY);
                        auxlbl.Cursor = Cursors.Hand;
                        auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                        auxlbl.Click += new EventHandler(label_Click);
                        auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                        posY += 25;
                        pnlHorarios.Controls.Add(auxlbl);
                    }
                }
            }
        }

        private void label_MouseEnter(object sender, EventArgs e) {
            ((Label)sender).BackColor = Color.White;
        }
        private void label_MouseLeave(object sender, EventArgs e) {
            ((Label)sender).BackColor = Color.Transparent;
        }
        private void label_Click(object sender, EventArgs e) {
            if (sender is Label) {
                Horario act = (Horario)((Label)sender).Tag;
                verHorForm.setHorario(act);
                verHorForm.Show();
                verHorForm.Focus();
            }

        }

        private void txtBoxFilter_TextChanged(object sender, EventArgs e) {
            this.loadHorarios(txtBoxFilter.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void panel1_MouseEnter(object sender, EventArgs e) {
            ((Panel)sender).Focus();
        }

        private void pnlHorarios_MouseEnter(object sender, EventArgs e) {
            panel1.Focus();
        }
    }
}
