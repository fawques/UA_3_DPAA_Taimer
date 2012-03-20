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
        User usuario = new User("Usuario", "12345678X", "usuario@user.com", "fechadenacimiento", 3, "Ingeniería de Magisterio Infantil");

        //Actividad_a activ1 = new Actividad_a("Actividad Test", "Descripción", 1337, "A saber");

        Actividad_p activ1 = new Actividad_p("Actividad Test", "Descripción", 1337, new User("Usuario", "12345678X", "usuario@user.com", "fechadenacimiento", 3, "Ingeniería de Magisterio Infantil"));

        public TestEN()
        {
            InitializeComponent();
        }

        private void crear_Click(object sender, EventArgs e)
        {
            try
            {
                Hora horaini = new Hora(int.Parse(hini.Text), int.Parse(mini.Text));
                Hora horafin = new Hora(int.Parse(hfin.Text), int.Parse(mfin.Text));

                Turno turno = new Turno(1, horaini, horafin, dias.L, "Aulario 51", activ1);
                turno.CambiarDiaSemana(diacombo.Text);
                activ1.AddTurno(turno);
                actualizaLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Excepción",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void actualizaLista()
        {
            lista.Items.Clear();

            string turnostring;
            foreach(Turno t in activ1.Turnos)
            {
                turnostring = "Cód: " + t.Codigo.ToString() + " -- Día: " + t.Dia + " -- Inicio: " + t.HoraInicio.toString() + " -- Fin: " + t.HoraFin.toString();
                lista.Items.Add(turnostring);
            }
        }

        private void borrar_Click_1(object sender, EventArgs e)
        {
            bool exito = activ1.BorraTurno(int.Parse(codBorrar.Text));

            if (!exito)
                MessageBox.Show("No se pudo borrar el turno.", "Borrar turno", MessageBoxButtons.OK, MessageBoxIcon.Error);

            actualizaLista();
        }

        private void TestEN_Load(object sender, EventArgs e)
        {
            Actividad_a activa1 = new Actividad_a("Actividad A 1", "Descripción", 1337, "A saber");
            Actividad_a activa2 = new Actividad_a("Actividad A 2", "Descripción", 1337, "A saber");
            Actividad_a activa3 = new Actividad_a("Actividad A 3", "Descripción", 1337, "A saber");

            Actividad_p activp1 = new Actividad_p("Actividad P 1", "Descripción", 1337, usuario);
            Actividad_p activp2 = new Actividad_p("Actividad P 2", "Descripción", 1338, usuario);
            Actividad_p activp3 = new Actividad_p("Actividad P 3", "Descripción", 1339, usuario);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tipo: " + activ1.TipoActividad());
        }
    }
}
