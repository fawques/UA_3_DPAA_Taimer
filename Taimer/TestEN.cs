// FORMULARIO DE PRUEBAS.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taimer
{
    public partial class TestEN : Form
    {
        User usuario = new User("Usuario", "12345678X", "usuario@user.com", "fechadenacimiento", 3, "Ingeniería de Magisterio Infantil",0);

        //Actividad_a activ1 = new Actividad_a("Actividad Test", "Descripción", 1337, "A saber");

        Actividad_p activ1 = new Actividad_p("Actividad Test", "Descripción", 1337, new User("Usuario", "12345678X", "usuario@user.com", "fechadenacimiento", 3, "Ingeniería de Magisterio Infantil",0));

        public TestEN()
        {
            InitializeComponent();
        }

        private void crear_Click(object sender, EventArgs e)
        {
            //try
            //{
                Hora horaini = new Hora(int.Parse(hini.Text), int.Parse(mini.Text));
                Hora horafin = new Hora(int.Parse(hfin.Text), int.Parse(mfin.Text));

                Turno turno = new Turno(1, horaini, horafin, diacombo.Text, "???", activ1);

                activ1.AddTurno(turno);
                actualizaLista();
            //}
            //catch (Exception ex)
            //{
              //  MessageBox.Show(ex.Message,"Excepción al crear turno",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }

        private void actualizaLista()
        {
            lista.Items.Clear();

            string turnostring;
            foreach(Turno t in activ1.Turnos)
            {
                turnostring = "Cód: " + t.Codigo.ToString() + " -- Día: " + t.Dia + " -- Inicio: " + t.HoraInicio.toString() + " -- Fin: " + t.HoraFin.toString() + " -- Ubic.: " + t.Ubicacion;
                lista.Items.Add(turnostring);
            }
        }

        private void borrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                activ1.BorraTurno(int.Parse(codBorrar.Text));

                actualizaLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción al borrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestEN_Load(object sender, EventArgs e)
        {
            Actividad_a activa1 = new Actividad_a("Actividad A 1", "Descripción", 1337, "A saber", "II");
            Actividad_a activa2 = new Actividad_a("Actividad A 2", "Descripción", 1337, "A saber", "II");
            Actividad_a activa3 = new Actividad_a("Actividad A 3", "Descripción", 1337, "A saber", "II");

            Actividad_p activp1 = new Actividad_p("Actividad P 1", "Descripción", 1337, usuario);
            Actividad_p activp2 = new Actividad_p("Actividad P 2", "Descripción", 1338, usuario);
            Actividad_p activp3 = new Actividad_p("Actividad P 3", "Descripción", 1339, usuario);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            
        }

        private void horasiguales_Click(object sender, EventArgs e)
        {
            try
            {
                Hora hora1 = new Hora(int.Parse(hini.Text), int.Parse(mini.Text));
                Hora hora2 = new Hora(int.Parse(hfin.Text), int.Parse(mfin.Text));

                if (hora1 == hora2)
                    MessageBox.Show("Las horas son iguales");
                else
                    MessageBox.Show("Las horas son distintas");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minutosdiferencia_Click(object sender, EventArgs e)
        {
            try
            {
                Hora hora1 = new Hora(int.Parse(hini.Text), int.Parse(mini.Text));
                Hora hora2 = new Hora(int.Parse(hfin.Text), int.Parse(mfin.Text));

                int diferencia = hora1.MinutosDeDiferencia(hora2);

                MessageBox.Show("Minutos de diferencia: " + diferencia.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = int.Parse(codBorrar.Text);

            try
            {
                Hora horanueva = new Hora(int.Parse(hini.Text), int.Parse(mini.Text));
                activ1.Turnos[indice].HoraInicio = horanueva;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción al cambiar hora de inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ex = null;
            }

            actualizaLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (activ1.EsPersonal())
                MessageBox.Show("Es personal funciona");
            else
                MessageBox.Show("ES PERSONAL NO TIRA NI PATRÁS");
        }

        private void chfin_Click(object sender, EventArgs e)
        {
            int indice = int.Parse(codBorrar.Text);

            try
            {
                Hora horanueva = new Hora(int.Parse(hfin.Text), int.Parse(mfin.Text));
                activ1.Turnos[indice].HoraFin = horanueva;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción al cambiar hora de fin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            actualizaLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indice = int.Parse(codBorrar.Text);

            try
            {
                activ1.Turnos[indice].Codigo = int.Parse(nuevocod.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción al cambiar código", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            actualizaLista();
        }

        private void cambiadiasemana_Click(object sender, EventArgs e)
        {
            int indice = int.Parse(codBorrar.Text);

            try
            {
                activ1.Turnos[indice].DiaString = diacombo.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción al cambiar día de la semana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            actualizaLista();
        }
    }
}
