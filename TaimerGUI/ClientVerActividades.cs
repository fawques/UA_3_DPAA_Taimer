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
                    auxlbl.AutoSize = false;
                    auxlbl.Width = 275;
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
                    auxlbl.AutoSize = false;
                    auxlbl.Width = 275;
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
                        auxlbl.AutoSize = false;
                        auxlbl.Width = 275;
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
                        auxlbl.AutoSize = false;
                        auxlbl.Width = 275;
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

        private void reiniciar() {
            pnlOficiales.Controls.Clear();
            pnlPersonales.Controls.Clear();
            txtBoxDescripcion.Text = "";
            lblDescripcion.Text = "";
            txtBoxNombre.Text = "";
            lblNombre.Text = "";
            dgTurns.Visible = false;
            btnGestTurn.Visible = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnBorrar.Enabled = false;
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
            if (grpBoxDatosAct.Tag is Actividad) {
                ((Actividad)grpBoxDatosAct.Tag).Nombre = txtBoxNombre.Text;
                ((Actividad)grpBoxDatosAct.Tag).Descripcion = txtBoxDescripcion.Text;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                panel1.Focus();
            }
        }

        private void loadGridTurnos(Actividad act) {
            
            if (act != null) {
                dgTurns.Rows.Clear();
                foreach (Turno turn in act.Turnos) {
                    dgTurns.Rows.Add(TaimerLibrary.convertToString(turn.Dia),turn.HoraInicio.toString(),turn.HoraFin.toString());
                }
            }
        }

        private void lblNombre_Click(object sender, EventArgs e) {
            if (grpBoxDatosAct.Tag is Actividad_p) {
                txtBoxNombre.Text = lblNombre.Text;
                lblNombre.Visible = false;
                txtBoxNombre.Visible = true;
                txtBoxNombre.Focus();
            }
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
            if (grpBoxDatosAct.Tag is Actividad_p) {
                txtBoxDescripcion.Text = lblDescripcion.Text;
                lblDescripcion.Visible = false;
                txtBoxDescripcion.Visible = true;
                txtBoxDescripcion.Focus();
                txtBoxDescripcion.SelectionStart = 0;
                txtBoxDescripcion.SelectionLength = txtBoxDescripcion.Text.Length;
            }
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
                dgTurns.Visible = true;
                if (act is Actividad_p) {
                    btnGestTurn.Visible = true;
                    btnBorrar.Enabled = true;
                } else {
                    btnGestTurn.Visible = false;
                    btnBorrar.Enabled = false;
                }
                loadGridTurnos(act);
            }
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e) {
        }

        private void ClientVerActividades_Activated(object sender, EventArgs e) {
            this.recarga();
        }

        private void recarga() {
            reiniciar();
            loadPersonales();
            loadOficiales();

            if (this.MdiParent is ClientForm) {
                ClientForm pare = (ClientForm)this.MdiParent;
                pare.loadLastActividades();
            }
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

        private void btnGestTurn_Click(object sender, EventArgs e) {
            MessageBox.Show("¿Que pongo aqui? ¿Otro MDI? ¿O una ventana fuera? ¿O muestro un algo?");
        }

        private void btnBorrar_Click(object sender, EventArgs e) {
            if (grpBoxDatosAct.Tag is Actividad_p) {
                if (MessageBox.Show("¿Seguro que desa borrar esta actividad?",
                      "¿Borrar actividad?",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                          if (usrAux.BorraActPersonalBool((Actividad_p)grpBoxDatosAct.Tag)) {
                              recarga();
                          } else {
                              MessageBox.Show("La actividad a borrar no existe", "Error borrando",MessageBoxButtons.OK, MessageBoxIcon.Error);
                          }
                }
            }

        }

        
    }
}
