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


        private Actividad_p actividad = null;
        private Actividad_p actividadDefinitiva = null;

        private ClientVerActividades formBackVer = null;
        private ClientCrearActiv formBackCrear = null;
        private bool modificado = false;
        List<Turno> tModificados = new List<Turno>();
        List<Turno> tCreados = new List<Turno>();

        public void setFormPadre(ClientVerActividades f) {
            formBackVer = f;
            formBackCrear = null;
        }
        public void setFormPadre(ClientCrearActiv f) {
            formBackVer = null;
            formBackCrear = f;
        }

        public ClientGestTurno() {
            InitializeComponent();
            comboBoxDia.SelectedIndex = 0;
        }

        public void setActividad(Actividad_p act) {
            actividadDefinitiva = act;
            actividad = new Actividad_p(act);
            loadActividad(actividad);
        }

        public void loadActividad(Actividad_p act) {
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
            bool todoBien = true;

            if (horI < horF) {
                lblErrorDate.Visible = false;
            } else {
                lblErrorDate.Visible = true;
                todoBien = false;
            }
            if (txtBoxLugar.Text == "") {
                lbErrUbi.Visible = true;
                todoBien = false;
            } else {
                lbErrUbi.Visible = false;
            }

            if (todoBien) {
                gVHorasTemp.Rows.Add(comboBoxDia.Text, horI.toString(), horF.toString(), txtBoxLugar.Text);

                Turno turnAux = new Turno(horI, horF, TaimerLibrary.convertToDais(comboBoxDia.Text), txtBoxLugar.Text);
                try {
                    actividad.AddTurno(turnAux);
                    tCreados.Add(turnAux);
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                }

                modificado = true;

                lblErrorDate.Visible = false;
                txtBoxLugar.Text = "";
                comboBoxDia.SelectedIndex = 0;
                lbErrUbi.Visible = false;
                loadActividad(actividad);
            }

        }

        public void reiniciar() {
            gVHorasTemp.Rows.Clear();
            txtBoxLugar.Text = "";
            grpBoxTurno.Visible = false;
            nmUpDwnHorDesde.Value = 0;
            nmUpDwnHorHasta.Value = 0;
            nmUpDwnMinDesde.Value = 0;
            nmUpDwnMinHasta.Value = 0;
            comboBoxDia.SelectedIndex = 0;
        }

        private void btnTerminar_Click(object sender, EventArgs e) {
            if (modificado)
            {
                if (MessageBox.Show("¿Seguro que desea cancelar los cambios?",
                          "¿Cancelar cambios?",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    modificado = false;
                    this.reiniciar();
                    if (formBackVer != null)
                    {
                        this.formBackVer.Show();
                        this.formBackVer.Focus();
                    }
                    else if (formBackCrear != null)
                    {
                        this.formBackCrear.Show();
                        this.formBackCrear.Focus();
                        this.formBackCrear.loadBoxTurnos();
                    }
                }
            }
            else
            {
                this.reiniciar();
                if (formBackVer != null)
                {
                    this.formBackVer.Show();
                    this.formBackVer.Focus();
                }
                else if (formBackCrear != null)
                {
                    this.formBackCrear.Show();
                    this.formBackCrear.Focus();
                    this.formBackCrear.loadBoxTurnos();
                }
            }
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
            if (e.RowIndex >= 0) {
                if (e.ColumnIndex == gVHorasTemp.Columns["Borrar"].Index) {
                    try {
                        actividad.BorraTurno((Turno)gVHorasTemp.Rows[e.RowIndex].Tag);
                        modificado = true;
                    } catch (NotSupportedException exc) {
                        MessageBox.Show(exc.Message);
                    }
                    gVHorasTemp.Rows.RemoveAt(e.RowIndex);
                } else if (gVHorasTemp.Rows[e.RowIndex].Tag is Turno) {
                    loadTurno((Turno)gVHorasTemp.Rows[e.RowIndex].Tag);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            grpBoxTurno.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            Hora horI = new Taimer.Hora((int)nUDHorIniMod.Value, (int)nUDMinIniMod.Value);
            Hora horF = new Taimer.Hora((int)nUDHorFinMod.Value, (int)nUDMinFinMod.Value);
            if (horI < horF) {
                try {
                    ((Turno)grpBoxTurno.Tag).CambiarHoras(horI, horF);
                    ((Turno)grpBoxTurno.Tag).Dia = TaimerLibrary.convertToDais(cmbBoxDiaMod.Text);
                    ((Turno)grpBoxTurno.Tag).Ubicacion = txtBoxLugarMod.Text;

                    tModificados.Add((Turno)grpBoxTurno.Tag);
                    modificado = true;

                    loadActividad(actividad);
                    lblMenorTurno.Visible = false;
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                }
                
            } else {
                lblMenorTurno.Visible = true;
            }
        }

        private void lbErrUbi_Click(object sender, EventArgs e) {

        }

        private void btnConfCambios_Click(object sender, EventArgs e) {
            if (modificado)
            {
                if (MessageBox.Show("¿Seguro que desea guardar los cambios?",
                          "¿Guardar cambios?",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    modificado = false;
                    this.reiniciar();
                    actividadDefinitiva.CopiarDesde(actividad);
                    if (formBackCrear == null) {//si venimos desde ver las asignaturas y NO desde crear
                        try {
                            actividadDefinitiva.Modificar();
                            foreach (Turno item in tCreados)
                            {
                                item.Agregar();
                            }
                            foreach (Turno item in tModificados)
                            {
                                item.Modificar();
                            }
                        } catch (Exception exc) {
                            MessageBox.Show(exc.Message);
                        }
                    }
                    if (formBackVer != null)
                    {
                        this.formBackVer.Show();
                        this.formBackVer.Focus();
                        this.formBackVer.loadGrupBoxData(actividadDefinitiva);
                    }
                    else if (formBackCrear != null)
                    {
                        this.formBackCrear.Show();
                        this.formBackCrear.Focus();
                        this.formBackCrear.loadBoxTurnos();
                    }
                }
            }
            else
            {
                this.reiniciar();
                actividadDefinitiva.CopiarDesde(actividad);
                if (formBackVer != null)
                {
                    this.formBackVer.Show();
                    this.formBackVer.Focus();
                    this.formBackVer.loadGrupBoxData(actividadDefinitiva);
                }
                else if (formBackCrear != null)
                {
                    this.formBackCrear.Show();
                    this.formBackCrear.Focus();
                    this.formBackCrear.loadBoxTurnos();
                }
            }
        }
    }
}
