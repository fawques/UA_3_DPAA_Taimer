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
        private List<Actividad_p> listaP;
        private List<Actividad_a> listaA;

        public Form1()
        {
            InitializeComponent();
            // el user será el 1er elemento de la lista de users de Program
            User usertest = new User("Aitor Tilla", "12345678X", "bill_gates@hotmail.com", "password", 1, "Ingeniería de Magisterio",0);

            // los turnos y actividades estarán almacenadas en Program
            Turno t1 = new Turno(new Hora(10, 30), new Hora(12, 30), dias.M, "L04");
            Turno t2 = new Turno(new Hora(11, 30), new Hora(13, 30), dias.L, "L04");
            Turno t3 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.M, "L04");
            Turno t4 = new Turno(new Hora(10, 30), new Hora(12, 30), dias.X, "L04");
            Turno t5 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.X, "L04");
            Turno t6 = new Turno(new Hora(14, 30), new Hora(16, 30), dias.L, "L04");
            Turno t7 = new Turno(new Hora(10, 30), new Hora(14, 30), dias.M, "L04");
            Turno t8 = new Turno(new Hora(11, 30), new Hora(14, 30), dias.V, "L04");
            Turno t9 = new Turno(new Hora(0, 30), new Hora(1, 30), dias.L, "L04");

            Actividad_p actP = new Actividad_p("P1", "descripcion", 6, usertest);
            actP.AddTurno(t1);

            Actividad_p actP2 = new Actividad_p("P2", "descripcion", 6, usertest);
            actP2.AddTurno(t4);
            actP2.AddTurno(t5);
            actP2.AddTurno(t6);

            Actividad_a actA = new Actividad_a("A1", "descripcion2", 7, "Un profesor");
            
            actA.AddTurno(t2);
            actA.AddTurno(t3);

            Actividad_a actA2 = new Actividad_a("A2", "descripcion2", 7, "Otro profesor");
            actA2.AddTurno(t7);
            //actA2.AddTurno(t8);
            actA2.AddTurno(t9);

            // las listas de actividades seleccionadas vendrán de la interfaz, según lo que seleccione el user
            listaP = new List<Actividad_p>();
            listaA = new List<Actividad_a>();
            
            listaA.Add(actA);
            listaP.Add(actP2);
            listaA.Add(actA2);
            listaP.Add(actP);
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            

            string nombre_horario = "Hola";

            // se almacenará en Program --> se llamará a una función que compruebe que esas listas de params no estén repes. Si ya existe, devuelve el que ya existe, si no, devuelve uno nuevo --> tiene que avisar de alguna forma de que es uno antiguo, para que no se llame al BT
            Algoritmo alg = new Algoritmo(listaA, listaP, Program.Usuarios[0]);
            string texto = "";
            string msg;
            int punt;
            Horario h;

            try
            {
                
                // se almacenará en user
                if (radioButton1.Checked)
                {
                    h = alg.generarHorarioBT(nombre_horario,true);
                    msg = "Tiene una puntuación según los días de : ";
                    punt = Algoritmo.puntuarDias(h);
                }
                else
                {
                    h = alg.generarHorarioBT(nombre_horario, false);
                    msg = "Tiene una puntuación según los huecos de : ";
                    punt = Algoritmo.puntuarHorasHueco(h);
                }
                
                foreach (List<Turno> dia in h.ArrayTurnos)
                {
                    foreach (Turno item in dia)
                    {
                        texto += item.Actividad.Nombre + " - " + item.HoraInicio.Hor + ":" + item.HoraInicio.Min + "|";
                    }
                }

                MessageBox.Show("Los turnos son: " + texto);
                
                MessageBox.Show(msg + punt);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show(exc.Message);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre_horario = "Hola";

            // se almacenará en Program --> se llamará a una función que compruebe que esas listas de params no estén repes. Si ya existe, devuelve el que ya existe, si no, devuelve uno nuevo
            Algoritmo alg = new Algoritmo(listaA, listaP,Program.Usuarios[0]);
            string texto = "";
            string msg;
            int punt;
            Horario h;

            try
            {
                h = alg.generarHorarioVoraz(nombre_horario);
                // se almacenará en user
                if (radioButton1.Checked)
                {
                    
                    msg = "Tiene una puntuación según los días de : ";
                    punt = Algoritmo.puntuarDias(h);
                }
                else
                {
                    msg = "Tiene una puntuación según los huecos de : ";
                    punt = Algoritmo.puntuarHorasHueco(h);
                }

                foreach (List<Turno> dia in h.ArrayTurnos)
                {
                    foreach (Turno item in dia)
                    {
                        texto += item.Actividad.Nombre + " - " + item.HoraInicio.Hor + ":" + item.HoraInicio.Min + "|";
                    }
                }

                MessageBox.Show("Los turnos son: " + texto);

                MessageBox.Show(msg + punt);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
