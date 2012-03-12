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
            Horario h = new Horario("prueba", 1);
            if (h.generarHorarioVoraz())
            {
                foreach (ArrayList dia in h.getTurnos())
                {
                    foreach (Turno item in dia)
                    {
                        texto += item.getNom() + " ";
                    }
                }

                MessageBox.Show("Los turnos son: " + texto);
                int puntDias = Horario.puntuarHorasHueco(h);
                MessageBox.Show("Tiene una puntuación según los huecos de : " + puntDias);
            }
            else
            {
                MessageBox.Show("Ha habido algún error en el proceso");
            }
        }
    }
}
