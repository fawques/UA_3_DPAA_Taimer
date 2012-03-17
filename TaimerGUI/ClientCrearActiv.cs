using System;
using Taimer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI
{
    public partial class ClientCrearActiv : Form
    {
        Taimer.Actividad_p actividad;
        public ClientCrearActiv()
        {
            InitializeComponent();
            comboBoxDia.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void ClientCrearActiv_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Taimer.Hora horI = new Taimer.Hora((int)nmUpDwnHorDesde.Value, (int)nmUpDwnMinDesde.Value);
            Taimer.Hora horF = new Taimer.Hora((int)nmUpDwnHorHasta.Value, (int)nmUpDwnMinHasta.Value);

            if (horI < horF) {
                gVHorasTemp.Rows.Add(comboBoxDia.Text, horI.toString(), horF.toString());
                lblErrorDate.Text = "";
            } else {
                lblErrorDate.Text = "Las hora de inicio debe ser menor que la de fin.";
            }
        }

        private void gVHorasTemp_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == gVHorasTemp.Columns["Borrar"].Index) {
                gVHorasTemp.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void bttnCrearActiv_Click(object sender, EventArgs e) {
            //TODO Crear la actividad
            if (MessageBox.Show("¿Seguro que desea crearla?",
            "¿Crear actividad?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                actividad = new Taimer.Actividad_p(tBNombre.Text, rTBDescripcion.Text, -1, "");
                
                foreach (DataGridViewRow filas in gVHorasTemp.Rows){
                    Hora horI = new Hora(filas.Cells["horaInicio"].Value.ToString());
                    Hora horF = new Hora(filas.Cells["horaFin"].Value.ToString());
                    Profesor prof = new Profesor("001", "Iginio Mora", "11111111I", "tic");
                    char d = comboBoxDia.Text[0];
                    Turno turn = new Turno(horI, horF, 'D', "IB", "poli1");
                    actividad.AddTurno(turn);
                }
                this.Hide();
            }
            
        }

    }
}
