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
    public partial class ClientVerActividades : Form
    {
        private User usrAux;
        public ClientVerActividades(User usr)
        {
            InitializeComponent();
            usrAux = usr;
        }


        private void loadPersonales() {
            if (usrAux != null) {
                int posY = 10;
                foreach(Actividad_p obj in usrAux.ActPersonales){
                    Label auxlbl = new Label();
                    auxlbl.Text = obj.Nombre;
                    auxlbl.Tag = obj;
                    auxlbl.Location = new Point(25, posY);
                    auxlbl.Cursor = Cursors.Hand;
                    auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                    auxlbl.Click += new EventHandler(label_Click);
                    auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                    posY += 25;
                    pnlPersonales.Controls.Add(auxlbl);
                }
            }
        }

        private void loadOficiales() {
            if (usrAux != null) {
                int posY = 10;
                foreach(Actividad_a obj in usrAux.ActAcademicas){
                    Label auxlbl = new Label();
                    auxlbl.Text = obj.Nombre;
                    auxlbl.Tag = obj;
                    auxlbl.Location = new Point(25, posY);
                    auxlbl.Cursor = Cursors.Hand;
                    auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                    auxlbl.Click += new EventHandler(label_Click);
                    auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                    posY += 25;
                    pnlOficiales.Controls.Add(auxlbl);
                }
            }
        }

        private void loadPersonales(string nom) {
            if (usrAux != null) {
                int posY = 10;
                foreach (Actividad_p obj in usrAux.ActPersonales) {
                    if (obj.Nombre.ToLower().Contains(nom)) {
                        Label auxlbl = new Label();
                        auxlbl.Text = obj.Nombre;
                        auxlbl.Tag = obj;
                        auxlbl.Location = new Point(25, posY);
                        auxlbl.Cursor = Cursors.Hand;
                        auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                        auxlbl.Click += new EventHandler(label_Click);
                        auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                        posY += 25;
                        pnlPersonales.Controls.Add(auxlbl);
                    }
                }
            }
        }

        private void loadOficiales(string nom) {
            if (usrAux != null) {
                int posY = 10;
                foreach (Actividad_a obj in usrAux.ActAcademicas) {
                    if (obj.Nombre.ToLower().Contains(nom)) {
                        Label auxlbl = new Label();
                        auxlbl.Text = obj.Nombre;
                        auxlbl.Tag = obj;
                        auxlbl.Location = new Point(25, posY);
                        auxlbl.Cursor = Cursors.Hand;
                        auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                        auxlbl.Click += new EventHandler(label_Click);
                        auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                        posY += 25;
                        pnlOficiales.Controls.Add(auxlbl);
                    }
                }
            }
        }

        private void limpiar() {
            pnlOficiales.Controls.Clear();
            pnlPersonales.Controls.Clear();
        }

        private void label_MouseEnter(object sender, EventArgs e) {
            ((Label)sender).BackColor = Color.White;
        }
        private void label_MouseLeave(object sender, EventArgs e) {
            ((Label)sender).BackColor = Color.Transparent;
        }
        private void label_Click(object sender, EventArgs e) {
            if (sender is Label) {
                Actividad act = (Actividad)((Label)sender).Tag;
                loadGrupBoxData(act);
            }

        }

        private void ClientVerActividades_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (grpBoxDatosAct.Tag != null) {
                ((Actividad)grpBoxDatosAct.Tag).Nombre = txtBoxNombre.Text;
                ((Actividad)grpBoxDatosAct.Tag).Descripcion = txtBoxDescripcion.Text;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                panel1.Focus();
            }
        }

        private void lblNombre_Click(object sender, EventArgs e) {
            txtBoxNombre.Text = lblNombre.Text;
            lblNombre.Visible = false;
            txtBoxNombre.Visible = true;
            txtBoxNombre.Focus();
        }

        private void txtBoxNombre_Leave(object sender, EventArgs e) {
            if (txtBoxNombre.Text != lblNombre.Text) {
                lblNombre.Text = txtBoxNombre.Text;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            txtBoxNombre.Visible = false;
            lblNombre.Visible = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
        }

        private void lblDescripcion_Click(object sender, EventArgs e) {
            txtBoxDescripcion.Text = lblDescripcion.Text;
            lblDescripcion.Visible = false;
            txtBoxDescripcion.Visible = true;
            txtBoxDescripcion.Focus();
            txtBoxDescripcion.SelectionStart = 0;
            txtBoxDescripcion.SelectionLength = txtBoxDescripcion.Text.Length;
        }

        private void txtBoxDescripcion_Leave(object sender, EventArgs e) {
            if (txtBoxDescripcion.Text != lblDescripcion.Text) {
                lblDescripcion.Text = txtBoxDescripcion.Text;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            txtBoxDescripcion.Visible = false;
            lblDescripcion.Visible = true;
        }

        public void loadGrupBoxData(Taimer.Actividad act){
            if (act != null) {
                txtBoxNombre.Visible = false;
                lblNombre.Visible = true;
                txtBoxDescripcion.Visible = false;
                lblDescripcion.Visible = true;
                txtBoxNombre.Text = lblNombre.Text = act.Nombre;
                txtBoxDescripcion.Text = lblDescripcion.Text = act.Descripcion;
                grpBoxDatosAct.Tag = act;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e) {
        }

        private void ClientVerActividades_Activated(object sender, EventArgs e) {
            limpiar();
            loadPersonales();
            loadOficiales();
        }


        private void txtBoxFiltro_TextChanged(object sender, EventArgs e) {
            limpiar();
            loadPersonales(txtBoxFiltro.Text.ToLower());
            loadOficiales(txtBoxFiltro.Text.ToLower());
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            if (grpBoxDatosAct.Tag != null){
                loadGrupBoxData((Actividad)grpBoxDatosAct.Tag);
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void txtBoxNombre_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {//si se presiona la tecla enter
                txtBoxNombre_Leave(sender, e);
            }
        }

        private void txtBoxDescripcion_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {//si se presiona la tecla enter
                txtBoxDescripcion_Leave(sender, e);
            }
        }

        
    }
}
