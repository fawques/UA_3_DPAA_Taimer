﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Taimer.User user = new Taimer.User();
            user.CheckLogin(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CAD.Prueba formp = new CAD.Prueba();
            formp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CAD.CADTurno turnoCAD = new CAD.CADTurno();
            Taimer.Turno aux=new Taimer.Turno();
            List<Taimer.Turno> turnos;

            turnos = aux.TurnosToList(turnoCAD.GetTurnosByAct(Convert.ToInt16(textBox3.Text)));

            foreach (Taimer.Turno turn in turnos)
                MessageBox.Show(""+turn.Codigo);
        }
    }
}
