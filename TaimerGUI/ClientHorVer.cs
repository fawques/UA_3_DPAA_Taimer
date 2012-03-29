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
        Taimer.Horario horario = null;
        public ClientHorVer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public void initPanelHorario(int minHor, int maxHor) {
            
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
            loadHorario();
        }

        public void loadHorario() {
            if (horario != null) {
                int minimo = horario.minHora().Hor;
                int maximo = horario.maxHora().Hor;
                int recorteArriba = (minimo) * 60;
                initPanelHorario(minimo, maximo);
                reducirPanelHorarios(minimo, maximo);

                for (int i = 0; i < horario.ArrayTurnos.Length; i++) {
                    foreach (Turno item in horario.ArrayTurnos[i]) {
                        int posi = item.HoraInicio.Hor * 60 - recorteArriba;
                        int duracion = (item.HoraFin.Hor - item.HoraInicio.Hor) * 60;//TODO cambiar a la funcion que sabe restar horas
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
                }
            }
            
        }

        //Para redimensionar los panales de los dias con minimos y maximos
        private void reducirPanelHorarios(int minHor, int maxHor) {
            int recorteArriba = (minHor) * 60;
            
            int recorteAbajo = (24-maxHor) * 60;

            pnlHoras.Height -= (recorteArriba + recorteAbajo);
            pnlLunes.Height -= (recorteArriba + recorteAbajo);
            pnlMartes.Height -= (recorteArriba + recorteAbajo);
            pnlMiercoles.Height -= (recorteArriba + recorteAbajo);
            pnlJueves.Height -= (recorteArriba + recorteAbajo);
            pnlViernes.Height -= (recorteArriba + recorteAbajo);
            pnlSabado.Height -= (recorteArriba + recorteAbajo);
            pnlDomingo.Height -= (recorteArriba + recorteAbajo);

        }

        /*protected override void WndProc(ref Message m)
            {
              const int WM_SYSCOMMAND = 0x0112;
              const int SC_MOVE = 0xF010;
              //ShowScrollBar(this.Handle, (int)ScrollBarDirection.SB_BOTH, false);
              switch (m.Msg)
              {
                case WM_SYSCOMMAND:
                  int command = m.WParam.ToInt32() & 0xfff0;
                  if (command == SC_MOVE)
                    return;
                  break;
               }
               base.WndProc(ref m);
             }*/
            

    }
}
