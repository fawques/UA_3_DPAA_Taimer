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
            User usertest = new User("Aitor Tilla", "12345678X", "bill_gates@hotmail.com", "password", 1, "Ingeniería de Magisterio");

            // los turnos y actividades estarán almacenadas en Program
            Turno.id = 1;
            Turno t1 = new Turno(new Hora(10, 30), new Hora(12, 30), dias.L, "L04");
            Turno.id++;
            Turno t2 = new Turno(new Hora(11, 30), new Hora(13, 30), dias.L, "L04");
            Turno.id++;
            Turno t3 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.M, "L04");
            Turno.id++;
            Turno t4 = new Turno(new Hora(10, 30), new Hora(12, 30), dias.X, "L04");
            Turno.id++;
            Turno t5 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.V, "L04");
            Turno.id++;
            Turno t6 = new Turno(new Hora(14, 30), new Hora(16, 30), dias.L, "L04");
            Turno.id++;
            Turno t7 = new Turno(new Hora(10, 30), new Hora(14, 30), dias.M, "L04");
            Turno.id++;
            Turno t8 = new Turno(new Hora(11, 30), new Hora(14, 30), dias.V, "L04");
            Turno.id++;
            Turno t9 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.V, "L04");
            Turno.id++;

            //Actividad_p actP = new Actividad_p("P1", "descripcion", 6, usertest);
           // actP.AddTurno(t1);

            Actividad_p actP2 = new Actividad_p("P2", "descripcion", 6, usertest);
            actP2.AddTurno(t4);
            actP2.AddTurno(t5);
            actP2.AddTurno(t6);

            Actividad_a actA = new Actividad_a("A1", "descripcion2", 7, "Un profesor");
            
            actA.AddTurno(t2);
            actA.AddTurno(t3);

            Actividad_a actA2 = new Actividad_a("A2", "descripcion2", 7, "Otro profesor");
            actA2.AddTurno(t7);
            actA2.AddTurno(t8);
            actA2.AddTurno(t9);

            // las listas de actividades seleccionadas vendrán de la interfaz, según lo que seleccione el user
            listaP = new List<Actividad_p>();
            listaA = new List<Actividad_a>();
            //listaP.Add(actP);
            listaP.Add(actP2);
            listaA.Add(actA);
            listaA.Add(actA2);
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            

            string nombre_horario = "Hola";

            // se almacenará en Program
            Algoritmo alg = new Algoritmo(listaA, listaP);
            string texto = "";

            try
            {
                // se almacenará en user
                Horario h = alg.generarHorarioBT(nombre_horario);
                foreach (List<Turno> dia in h.ArrayTurnos)
                {
                    foreach (Turno item in dia)
                    {
                         texto += item.Codigo + " ";
                    }
                }

                MessageBox.Show("Los turnos son: " + texto);
                int puntDias = Algoritmo.puntuarDias(h);
                MessageBox.Show("Tiene una puntuación según los huecos de : " + puntDias);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show(exc.Message);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre_horario = "Hola";

            // se almacenará en Program
            Algoritmo alg = new Algoritmo(listaA, listaP);
            string texto = "";

            try
            {
                // se almacenará en user
                Horario h = alg.generarHorarioVoraz(nombre_horario);
                foreach (List<Turno> dia in h.ArrayTurnos)
                {
                    foreach (Turno item in dia)
                    {
                        texto += item.Codigo + " ";
                    }
                }

                MessageBox.Show("Los turnos son: " + texto);
                int puntDias = Algoritmo.puntuarDias(h);
                MessageBox.Show("Tiene una puntuación según los huecos de : " + puntDias);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
