using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taimer;

namespace TaimerGUI {
    public partial class ClientGestTurno : Form {

        private ClientVerActividades formBack;
        private Actividad_p actividad = null;

        public ClientGestTurno() {
            InitializeComponent();

        }
        public void setFormBack(ClientVerActividades f) {
            formBack = f;
        }

        public void loadActividad(Actividad_p act) {
            actividad = act;
            this.reiniciar();
            if (actividad is Actividad_p) {
                gVHorasTemp.Rows.Clear();
                foreach (Turno turn in actividad.Turnos) {
                    gVHorasTemp.Rows.Add(turn.DiaString, turn.HoraInicio.toString(), turn.HoraFin.toString(), turn.Ubicacion);
                    gVHorasTemp.Rows[gVHorasTemp.Rows.Count - 1].Tag = turn;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {

            Taimer.Hora horI = new Taimer.Hora((int)nmUpDwnHorDesde.Value, (int)nmUpDwnMinDesde.Value);
            Taimer.Hora horF = new Taimer.Hora((int)nmUpDwnHorHasta.Value, (int)nmUpDwnMinHasta.Value);
                

            if (horI < horF && txtBoxLugar.Text != "") {
                gVHorasTemp.Rows.Add(comboBoxDia.Text, horI.toString(), horF.toString(), txtBoxLugar.Text);
                
                Turno turnAux = new Turno(horI, horF, TaimerLibrary.convertToDais(comboBoxDia.Text), txtBoxLugar.Text);
                try {
                    actividad.AddTurno(turnAux);
                } catch (NotSupportedException exc) {
                    MessageBox.Show(exc.Message);
                }

                lblErrorDate.Visible = false;
                txtBoxLugar.Text = "";
                lbErrUbi.Visible = false;
                loadActividad(actividad);
            } else if (txtBoxLugar.Text == ""){
                lblErrorDate.Visible = false;
                lbErrUbi.Visible = true;
            }else{
                lbErrUbi.Visible = false;
                lblErrorDate.Visible = true;
            }

        }

        public void reiniciar() {
            gVHorasTemp.Rows.Clear();
            grpBoxTurno.Visible = false;
        }

        private void btnTerminar_Click(object sender, EventArgs e) {
            this.reiniciar();
            this.formBack.Show();
            this.formBack.Focus();
            this.formBack.loadGrupBoxData(actividad);
        }

        public void loadTurno(Turno turn) {
            if (turn is Turno) {
                grpBoxTurno.Tag = turn;
                txtBoxLugarMod.Text = turn.Ubicacion;
                cmbBoxDiaMod.SelectedIndex = TaimerLibrary.convertToInt(turn.Dia);
                nUDHorIniMod.Value = turn.HoraInicio.Hor;
                nUDMinIniMod.Value = turn.HoraInicio.Min;
                nUDHorFinMod.Value = turn.HoraFin.Hor;
                nUDMinFinMod.Value = turn.HoraFin.Min;
                grpBoxTurno.Visible = true;
            }
        }

        private void gVHorasTemp_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == gVHorasTemp.Columns["Borrar"].Index) {
                try {
                    actividad.BorraTurno((Turno)gVHorasTemp.Rows[e.RowIndex].Tag);
                } catch (NotSupportedException exc) {
                    MessageBox.Show(exc.Message);
                }
                gVHorasTemp.Rows.RemoveAt(e.RowIndex);
            } else if (gVHorasTemp.Rows[e.RowIndex].Tag is Turno) {
                loadTurno((Turno)gVHorasTemp.Rows[e.RowIndex].Tag);
            }  
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            grpBoxTurno.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            Hora horI = new Taimer.Hora((int)nUDHorIniMod.Value, (int)nUDMinIniMod.Value);
            Hora horF = new Taimer.Hora((int)nUDHorFinMod.Value, (int)nUDMinFinMod.Value);
            try {
                ((Turno)grpBoxTurno.Tag).HoraInicio = horI;
                ((Turno)grpBoxTurno.Tag).HoraFin = horF;
                ((Turno)grpBoxTurno.Tag).Dia = TaimerLibrary.convertToDais(cmbBoxDiaMod.Text);
            } catch (NotSupportedException exc) {
                MessageBox.Show(exc.Message);
            }
            ((Turno)grpBoxTurno.Tag).Ubicacion = txtBoxLugarMod.Text;
            
            loadActividad(actividad);
        }

        private void lbErrUbi_Click(object sender, EventArgs e)
        {

        }
    }
}
