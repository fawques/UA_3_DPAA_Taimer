using System;
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
            Taimer.User.CheckLoginUser(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CAD.Prueba formp = new CAD.Prueba();
            formp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CAD.CADTurno turnoCAD = new CAD.CADTurno();             
            List<Taimer.Turno> turnos;

           // turnos = Taimer.Turno.TurnosToList(turnoCAD.GetTurnosByAct(Convert.ToInt16(textBox3.Text)));

           // foreach (Taimer.Turno turn in turnos)
             //   MessageBox.Show(""+turn.Codigo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CAD.CADTurno turnoCAD = new CAD.CADTurno();
            List<Taimer.Turno> turnos;
            DataSet data=turnoCAD.GetTurnosByHorario(Convert.ToInt16(textBox4.Text),textBox5.Text);
            turnos = Taimer.Turno.CodesToList(data);

            MessageBox.Show("El horario " + textBox4.Text + "," + textBox5.Text + " tiene " + turnos.Count + " turnos");
        }
    }
}
