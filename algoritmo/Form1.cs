using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taimer;

namespace algoritmo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            string texto = "";
            User u = new User("nombre", "dni", "email", "pass", 5, "titulacion");
            Horario h = new Horario("prueba", u);
            if (h.generarHorarioVoraz())
            {
                foreach (List<Turno> dia in h.ArrayTurnos)
                {
                    foreach (Turno item in dia) {
                       // texto += item.Nombre + " ";
                    }
                }

                MessageBox.Show("Los turnos son: " + texto);
                int puntDias = Horario.puntuarDias(h);
                MessageBox.Show("Tiene una puntuación según los huecos de : " + puntDias);
            }
            else
            {
                MessageBox.Show("Ha habido algún error en el proceso");
            }
        }
    }
}
