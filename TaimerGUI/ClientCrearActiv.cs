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
        private User usrAux;
        public ClientCrearActiv(User usr)
        {
            InitializeComponent();
            comboBoxDia.SelectedIndex = 0;
            usrAux = usr;
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
                gVHorasTemp.Rows.Add(comboBoxDia.Text, horI.toString(), horF.toString(),txtBoxLugar.Text);
                lblErrorDate.Text = "";
                txtBoxLugar.Text = "";
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

            if (validarTodo()) {
                if (MessageBox.Show("¿Seguro que desea crearla?",
                "¿Crear actividad?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                    Actividad_p actividad = new Taimer.Actividad_p(tBNombre.Text, rTBDescripcion.Text, -1, null);

                    foreach (DataGridViewRow filas in gVHorasTemp.Rows) {
                        Hora horI = new Hora(filas.Cells["horaInicio"].Value.ToString());
                        Hora horF = new Hora(filas.Cells["horaFin"].Value.ToString());
                        string d = comboBoxDia.Text;
                        Turno turn = new Turno(horI, horF, convertToDais(d), filas.Cells["lugar"].Value.ToString());
                        actividad.AddTurno(turn);
                    }
                    usrAux.AddActPersonal(actividad);
                    ((ClientForm)this.MdiParent).loadLastActividades();
                    ((ClientForm)this.MdiParent).verActividad_Click(null,null);
                }
            }
            
        }

        private dias convertToDais(string d) {

            switch (d) {
                case "Lunes":
                    return dias.L;
                    break;
                case "Martes":
                    return dias.M;
                    break;
                case "Miercoles":
                    return dias.X;
                    break;
                case "Jueves":
                    return dias.J;
                    break;
                case "Viernes":
                    return dias.V;
                    break;
                case "Sabado":
                    return dias.S;
                    break;
                case "Domingo":
                    return dias.D;
                    break;
                default:
                    return dias.L;
                    break;
            }
        }

        private bool validarTodo() {
            bool correcto = true;
            if (tBNombre.Text == "") {
                lblErrorNombre.Visible = true;
                correcto = false;
            } else {
                lblErrorNombre.Visible = false;
            }

            return correcto;
        }

    }
}
