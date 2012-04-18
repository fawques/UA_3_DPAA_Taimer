using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taimer;

namespace TaimerGUI {
    public partial class ClientHorVer : Form {
        Taimer.Horario horario = null;
        public ClientHorVer() {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public void initPanelHorario(int minHor, int maxHor) {

            pnlHoras.Controls.Clear();
            Hora hora = new Hora(0, 0);
            int posY = 0;
            int horAux = minHor;
            while (horAux <= maxHor) {
                Label lblHora = new Label();
                if (horAux >= 24) {
                    lblHora.Text = "24:00";
                } else {
                    hora.setTiempo(horAux, 0);
                    lblHora.Text = hora.toString();
                }
                lblHora.Location = new Point(20, posY);
                lblHora.ForeColor = Color.White;
                posY += 60;
                horAux++;
                pnlHoras.Controls.Add(lblHora);
            }

            pnlHoras.Height = 1460;
            pnlLunes.Height = 1460;
            pnlMartes.Height = 1460;
            pnlMiercoles.Height = 1460;
            pnlJueves.Height = 1460;
            pnlViernes.Height = 1460;
            pnlSabado.Height = 1460;
            pnlDomingo.Height = 1460;
        }

        private void ClientHorVer_Load(object sender, EventArgs e) {

        }

        public void setHorario(Taimer.Horario hor) {
            horario = hor;
            lblNombreHora.Text = hor.Nombre;
            loadHorario();
        }

        public void loadHorario() {
            lblNombreAsig.Text = "";
            lblDescripAsig.Text = "";
            lblHorIni.Text = "";
            lblHorFin.Text = "";
            pnlLunes.Controls.Clear();
            pnlMartes.Controls.Clear();
            pnlMiercoles.Controls.Clear();
            pnlJueves.Controls.Clear();
            pnlViernes.Controls.Clear();
            pnlSabado.Controls.Clear();
            pnlDomingo.Controls.Clear();
            if (horario != null) {
                //Pasar maximos y minimos de horas (solo horas, tampoco vamos a recortar al minuto)
                int minimo = 0;
                int maximo = 23;
                try {
                    minimo = horario.minHora().Hor;
                    maximo = horario.maxHora().Hor;
                    if (horario.maxHora().Hor < 23 && horario.maxHora().Min > 0) {
                        maximo++;
                    }
                } catch (Exception) {
                    //MessageBox.Show(exc.Message);
                }
                int recorteArriba = (minimo) * 60;
                if (horario.maxHora().Hor == 23) {
                    initPanelHorario(minimo, 24);
                } else {
                    initPanelHorario(minimo, maximo);
                }
                if (!(horario.maxHora().Hor == 23 && horario.maxHora().Min > 0)) {
                    reducirPanelHorarios(minimo, maximo);
                }

                for (int i = 0; i < horario.ArrayTurnos.Length; i++) {
                    foreach (Turno item in horario.ArrayTurnos[i]) {
                        int posi = (item.HoraInicio.Hor * 60 + item.HoraInicio.Min) - recorteArriba;
                        int duracion = (item.HoraFin.Hor - item.HoraInicio.Hor) * 60 + item.HoraFin.Min;
                        Button b = new Button();
                        b.Height = duracion;
                        b.Width = 90;
                        b.BackColor = Color.Khaki;

                        b.Text = item.Actividad.Nombre + Environment.NewLine + item.Ubicacion;
                        b.Location = new Point(0, posi);
                        b.Click += new EventHandler(asig_Click);

                        b.Tag = item;
                        b.Anchor = AnchorStyles.Left;
                        b.FlatStyle = FlatStyle.Flat;
                        b.Cursor = Cursors.Hand;

                        addActividad(b);
                    }
                }
            } else {
                MessageBox.Show("No hay horario que cargar");
            }

        }

        private void addActividad(Button b) {
            if (b.Tag is Turno) {
                Turno auxt = (Turno)b.Tag;
                switch (auxt.Dia) {
                    case dias.L:
                        pnlLunes.Controls.Add(b);
                        break;
                    case dias.M:
                        pnlMartes.Controls.Add(b);
                        break;
                    case dias.X:
                        pnlMiercoles.Controls.Add(b);
                        break;
                    case dias.J:
                        pnlJueves.Controls.Add(b);
                        break;
                    case dias.V:
                        pnlViernes.Controls.Add(b);
                        break;
                    case dias.S:
                        pnlSabado.Controls.Add(b);
                        break;
                    case dias.D:
                        pnlDomingo.Controls.Add(b);
                        break;
                }
            }
        }

        private void asig_Click(object sender, EventArgs e) {
            if (sender is Button) {
                //En el tag del boton esta guardado el codigo de la asignatura
                Turno trn = (Turno)((Button)sender).Tag;

                if (trn != null) {

                    lblNombreAsig.Text = trn.Actividad.Nombre;
                    lblDescripAsig.Text = trn.Actividad.Descripcion;
                    lblHorIni.Text = trn.HoraInicio.toString();
                    lblHorFin.Text = trn.HoraFin.toString();
                    lblUbica.Text = trn.Ubicacion;
                }
            }

        }

        //Para redimensionar los panales de los dias con minimos y maximos
        private void reducirPanelHorarios(int minHor, int maxHor) {
            int recorteArriba = (minHor) * 60;

            int recorteAbajo = (24 - maxHor) * 60;

            pnlHoras.Height -= (recorteArriba + recorteAbajo);
            pnlLunes.Height -= (recorteArriba + recorteAbajo);
            pnlMartes.Height -= (recorteArriba + recorteAbajo);
            pnlMiercoles.Height -= (recorteArriba + recorteAbajo);
            pnlJueves.Height -= (recorteArriba + recorteAbajo);
            pnlViernes.Height -= (recorteArriba + recorteAbajo);
            pnlSabado.Height -= (recorteArriba + recorteAbajo);
            pnlDomingo.Height -= (recorteArriba + recorteAbajo);

        }

        private void label1_Click(object sender, EventArgs e) {
            txtBoxNombreHor.Text = lblNombreHora.Text;
            txtBoxNombreHor.Visible = true;
            lblNombreHora.Visible = false;
            txtBoxNombreHor.Focus();
        }

        private void txtBoxNombreHor_Leave(object sender, EventArgs e) {

            if (lblNombreHora.Text != txtBoxNombreHor.Text && !lblNombreHora.Visible) {
                if (MessageBox.Show("¿Seguro que desa cambiar el nombre?",
                   "¿Cambiar nombre?",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                    lblNombreHora.Text = txtBoxNombreHor.Text;
                    horario.Nombre = txtBoxNombreHor.Text;
                    try {
                        horario.Modificar();
                    } catch (Exception exc) {
                        MessageBox.Show(exc.Message);
                    }
                    ((ClientForm)this.MdiParent).loadLastHorarios();
                }


            }
            
            lblNombreHora.Visible = true;
            txtBoxNombreHor.Visible = false;
        }



        private void txtBoxNombreHor_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {//si se presiona la tecla enter
                txtBoxNombreHor_Leave(sender, e);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Seguro que desa borrar el horario actual?",
                   "¿Borrar horario?",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                       if (((ClientForm)this.MdiParent).getUsuario().BorraHorarioBool(horario)) {
                           MessageBox.Show("Borrado correctamente");
                           ((ClientForm)this.MdiParent).loadLastHorarios();
                           ((ClientForm)this.MdiParent).verHorarios_Click(null, null);
                       } else {
                           MessageBox.Show("Error borrando", "No se ha podido borrar el horario.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }
            }
           
        }

        private void pnlHorario_MouseHover(object sender, EventArgs e) {

        }

        private void pnlHorario_MouseEnter(object sender, EventArgs e) {
            ((Panel)sender).Focus();
        }


    }
}
