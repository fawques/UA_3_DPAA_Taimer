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
    public partial class ClientCrearHor2 : Form {
        ClientCrearHor1 formBack = null;

        public ClientCrearHor2() {
            InitializeComponent();
        }

        public void setBackForm(ClientCrearHor1 form) {
            formBack = form;
        }

        private void button2_Click(object sender, EventArgs e) {
            if (formBack != null) {
                Hide();
                formBack.Show();
                ClientForm pare = (ClientForm)this.MdiParent;
                pare.positionAllChilds();
            }

        }

        private void chkBxAll_CheckedChanged(object sender, EventArgs e) {
            switchCheckAllDays();
        }
        void switchCheckAllDays() {
            foreach (Control c in groubBoxDias.Controls)
            {
                if (c is CheckBox && ((CheckBox)c).Name != "chkBxAll") {
                    ((CheckBox)c).Checked = !((CheckBox)c).Checked;
                }
            }

        }


        private void initPanelHorario(int minHor, int maxHor) {

            Hora hora = new Hora(0, 0);
            int posY = 0;
            int horAux = minHor;
            while (horAux <= maxHor) {
                Label lblHora = new Label();
                hora.setTiempo(horAux, 0);
                lblHora.Text = hora.toString();
                lblHora.Location = new Point(20, posY);
                lblHora.ForeColor = Color.White;
                posY += 60;
                horAux++;
                pnlHoras.Controls.Add(lblHora);
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

        private void loadHorario() {
            /*List<Turno> turnos = new List<Turno>();

            Hora horI = new Hora(10, 0);
            Hora horF = new Hora(11, 0);
            Turno turn = new Turno(horI, horF, 'L', "IB", "poli1");
            turnos.Add(turn);

            horI = new Hora(12, 0);
            horF = new Hora(14, 0);
            turn = new Turno(horI, horF, 'L', "DPAA", "A2 D23");
            turnos.Add(turn);

            horI = new Hora(14, 0);
            horF = new Hora(15, 0);
            turn = new Turno(horI, horF, 'L', "OTRA", "poli1");
            turnos.Add(turn);

            horI = new Hora(15, 30);
            horF = new Hora(17, 0);
            turn = new Turno(horI, horF, 'L', "OTRAMAS", "poli1");
            turnos.Add(turn);

            horI = new Hora(17, 0);
            horF = new Hora(18, 0);
            turn = new Turno(horI, horF, 'L', "EOI", "poli1");
            turnos.Add(turn);

            //Pasar maximos y minimos de horas (solo horas, tampoco vamos a recortar al minuto)
            int minimo = 10;
            int maximo = 18;
            int recorteArriba = (minimo) * 60;
            initPanelHorario(minimo, maximo);
            reducirPanelHorarios(minimo, maximo);

            foreach (Turno item in turnos) {
                int posi = item.HoraInicio.Hor * 60 - recorteArriba;
                int duracion = (item.HoraFin.Hor - item.HoraInicio.Hor) * 60;//TODO cambiar a la funcion que sabe restar horas
                Button b = new Button();
                b.Height = duracion;
                b.Width = 90;
                b.BackColor = Color.Khaki;
                b.Text = item.Nombre + Environment.NewLine + item.Ubicacion;
                b.Location = new Point(0, posi);
                b.Tag = item.Codigo;
                b.Anchor = AnchorStyles.Left;
                b.FlatStyle = FlatStyle.Flat;
                b.Cursor = Cursors.Hand;
                pnlLunes.Controls.Add(b);
            }*/

        }

        private void ClientCrearHor2_Load(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta operación puede tomar varios minutos. ¿Seguro que desea continuar?",
           "¿Crear horario?",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                //Algoritmos guay con una ventana de "Estmos en ello"
               (new ClientCreandoAlgoritmo()).ShowDialog();
               loadHorario();
                
               btnCrear.Visible = false;
               btnGuardar.Visible = true;
            }
           
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            MessageBox.Show("Guardado con exito");
            this.Hide();
        }
    }
}
