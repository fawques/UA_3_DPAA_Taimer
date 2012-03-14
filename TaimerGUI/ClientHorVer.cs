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
    public partial class ClientHorVer : Form
    {
        Taimer.Horario horario;
        public ClientHorVer()
        {
            InitializeComponent();
            
        }

        private void initPanelHorario(int minHor, int maxHor) {
            
            Hora hora = new Hora(0, 0);
            int posY = 0;
            int horAux = minHor;
            while (horAux <= maxHor) {
                Label lblHora = new Label();
                hora.setTiempo(horAux, 0);
                lblHora.Text = hora.toString();
                lblHora.Location = new Point(10, posY);
                posY += 60;
                horAux++;
                pnlHoras.Controls.Add(lblHora);
            }
        }

        private void ClientHorVer_Load(object sender, EventArgs e) {
            loadHorario();
        }

        public void setHorario(Taimer.Horario hor) {
            horario = hor;

            //TODO:Para pruebas
           
        }

        private void loadHorario() {
            List<Turno> turnos = new List<Turno>();

            Hora horI = new Hora(9,0);
            Hora horF = new Hora(11,0);
            Turno turn = new Turno(horI, horF, 'L', "IB", "poli1");
            turnos.Add(turn);

            horI = new Hora(12, 0);
            horF = new Hora(14, 0);
            turn = new Turno(horI, horF, 'L', "DPAA", "poli1");
            turnos.Add(turn);

            horI = new Hora(14, 0);
            horF = new Hora(15, 0);
            turn = new Turno(horI, horF, 'L', "OTRA", "poli1");
            turnos.Add(turn);

            horI = new Hora(15, 30);
            horF = new Hora(17, 0);
            turn = new Turno(horI, horF, 'L', "OTRAMAS", "poli1");
            turnos.Add(turn);

            horI = new Hora(19, 0);
            horF = new Hora(21, 0);
            turn = new Turno(horI, horF, 'L', "EOI", "poli1");
            turnos.Add(turn);

            int recorteArriba = (9) * 60;
            initPanelHorario(9,21);
            reducirPanelHorarios(9, 21);

            foreach (Turno item in turnos) {
                int posi = item.HoraInicio.Hor * 60 - recorteArriba;
                int duracion = (item.HoraFin.Hor-item.HoraInicio.Hor)*60;//TODO cambiar a la funcion que sabe restar horas
                Button b = new Button();
                b.Height = duracion;
                b.Width = 90;
                b.BackColor = Color.Red;
                b.Text = item.Nombre+Environment.NewLine+item.Ubicacion;
                b.Location = new Point(0, posi);
                b.Click += new EventHandler(asig_Click);
                b.Tag = item.Codigo;
                b.Anchor = AnchorStyles.Left;
                pnlLunes.Controls.Add(b);
            }
            
        }
        private void asig_Click(object sender, EventArgs e) {
            if (sender is Button) {
                //En el tag del boton esta guardado el codigo de la asignatura
                lblNombreAsig.Text = ((Button)sender).Tag.ToString();
            }
            
        }

        private void reducirPanelHorarios(int minHor, int maxHor) {
            int recorteArriba = (minHor) * 60;
            
            int recorteAbajo = (24-maxHor) * 60;

            pnlHoras.Height -= (recorteArriba + recorteAbajo);
        }
    }
}
