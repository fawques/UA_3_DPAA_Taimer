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
        public Actividad_a activ = new Actividad_a("Nombre", "Descripción", 1337, "A saber");

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

                Turno turno = new Turno(1, horaini, horafin, dias.L, "Aulario 51", activ);
                turno.CambiarDiaSemana(diacombo.Text);
                activ.AddTurno(turno);
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
            foreach(Turno t in activ.Turnos)
            {
                turnostring = "Cód: " + t.Codigo.ToString() + " -- Día: " + t.Dia + " -- Inicio: " + t.HoraInicio.toString() + " -- Fin: " + t.HoraFin.toString();
                lista.Items.Add(turnostring);
            }
        }

        private void borrar_Click_1(object sender, EventArgs e)
        {
            bool exito = activ.BorraTurno(int.Parse(codBorrar.Text));

            if (!exito)
                MessageBox.Show("No se pudo borrar el turno.", "Borrar turno", MessageBoxButtons.OK, MessageBoxIcon.Error);

            actualizaLista();
        }
    }
}
