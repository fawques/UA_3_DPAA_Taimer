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
    public partial class ClientVerActividades : Form
    {
        public ClientVerActividades()
        {
            InitializeComponent();
        }


        private void loadPersonales() {
            int posY = 10;
            for (int i = 0; i < 10; i++) {
                Label auxlbl = new Label();
                auxlbl.Text = "Personal " + i;
                auxlbl.Location = new Point(25, posY);
                auxlbl.Cursor = Cursors.Hand;
                auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                auxlbl.Click += new EventHandler(label_Click);
                auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                posY += 25;
                pnlPersonales.Controls.Add(auxlbl);
            }
        }

        private void loadOficiales() {
            int posY = 10;
            for (int i = 0; i < 10; i++) {
                Label auxlbl = new Label();
                auxlbl.Text = "Oficial " + i;
                auxlbl.Location = new Point(25, posY);
                auxlbl.Cursor = Cursors.Hand;
                auxlbl.MouseEnter += new EventHandler(label_MouseEnter);
                auxlbl.Click += new EventHandler(label_Click);
                auxlbl.MouseLeave += new EventHandler(label_MouseLeave);
                posY += 25;
                pnlOficiales.Controls.Add(auxlbl);
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
            ((Label)sender).BackColor = Color.Red;
        }

        private void ClientVerActividades_Load(object sender, EventArgs e) {
            loadPersonales();
            loadOficiales();
        }

        private void button1_Click(object sender, EventArgs e) {
            
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
            limpiar();
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
                lblNombre.Text = act.Nombre;
                lblDescripcion.Text = act.Descripcion;
            }
        }

        
    }
}
