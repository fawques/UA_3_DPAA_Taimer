using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taimer;

namespace TaimerGUI
{
    public partial class AGestTurn : Form
    {

        AAddAsig parentAdd = null;
        AGestAsig parentGest = null;
        Taimer.Actividad_a currentAct = null;
        Taimer.Actividad_a currentActCopy = null;
        List<Taimer.Turno> tModificados = new List<Taimer.Turno>();
        List<Taimer.Turno> tCreados = new List<Taimer.Turno>();
        List<Taimer.Turno> tBorrados = new List<Taimer.Turno>();

        public AGestTurn()
        {
            InitializeComponent();
        }

        public void setParent(AAddAsig form)
        {
            parentGest = null;
            parentAdd = form;
        }

        public void setParent(AGestAsig form)
        {
            parentGest = form;
            parentAdd = null;
        }

        public void loadAsig(Taimer.Actividad_a asig)
        {
            currentAct = asig;
            currentActCopy = new Taimer.Actividad_a(asig);

            dgTurnos.Rows.Clear();
            grpBoxTurno.Visible = false;

            if (currentAct is Taimer.Actividad_a)
            {
                dgTurnos.Rows.Clear();
                foreach (Taimer.Turno turn in currentAct.Turnos)
                {
                    dgTurnos.Rows.Add(turn.DiaString, turn.HoraInicio.toString(), turn.HoraFin.toString(), turn.Ubicacion);
                    dgTurnos.Rows[dgTurnos.Rows.Count - 1].Tag = turn;
                }
            }
        }

        private bool parentNotNull()
        {
            return parentAdd != null && parentGest != null;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            bool valid = true;

            if (tbUbi.Text == "")
            {
                lbErrUbi.Visible = true;
                valid = false;
            }
            else
            {
                lbErrUbi.Visible = false;
            }

            Taimer.Hora horI = new Taimer.Hora((int)udHoraIni.Value, (int)udMinIni.Value);
            Taimer.Hora horF = new Taimer.Hora((int)udHoraFin.Value, (int)udMinFin.Value);

            if (horI >= horF)
            {
                lbErrHora.Visible = true;
                valid = false;
            }
            else
            {
                lbErrHora.Visible = false;
            }

            if (valid)
            {

                Taimer.Turno turn = new Taimer.Turno(horI, horF, cbDia.Text, tbUbi.Text);
                // Lo añado a la tabla
                dgTurnos.Rows.Add(turn.DiaString, turn.HoraInicio.toString(), turn.HoraFin.toString(), turn.Ubicacion, "");
                dgTurnos.Rows[dgTurnos.RowCount - 1].Tag = turn;

                currentAct.AddTurno(turn);
                tCreados.Add(turn);

                tbUbi.Text = "";
                cbDia.SelectedIndex = 0;
                udHoraIni.Value = 0;
                udHoraFin.Value = 0;
                udMinFin.Value = 0;
                udMinIni.Value = 0;
            }
        }

        private void dgTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgTurnos.Rows.Count)
            {
                if (e.ColumnIndex == dgTurnos.Columns["Borrar"].Index)
                {
                    try
                    {
                        Taimer.Turno turno = (Taimer.Turno)dgTurnos.Rows[e.RowIndex].Tag;
                        currentAct.BorraTurno(turno);
                        tBorrados.Add(turno);

                    }
                    catch (NotSupportedException exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    catch (MissingMemberException)
                    {

                    }
                    dgTurnos.Rows.RemoveAt(e.RowIndex);
                }
                else
                {

                    Taimer.Turno turn = (Taimer.Turno)dgTurnos.Rows[e.RowIndex].Tag;

                    if (turn is Taimer.Turno)
                    {
                        grpBoxTurno.Tag = turn;
                        txtBoxLugarMod.Text = turn.Ubicacion;
                        cmbBoxDiaMod.SelectedIndex = Taimer.TaimerLibrary.convertToInt(turn.Dia);
                        nUDHorIniMod.Value = turn.HoraInicio.Hor;
                        nUDMinIniMod.Value = turn.HoraInicio.Min;
                        nUDHorFinMod.Value = turn.HoraFin.Hor;
                        nUDMinFinMod.Value = turn.HoraFin.Min;
                        grpBoxTurno.Visible = true;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(
                    "¿Esta seguro de que desea descartar los cambios?",
                    "Descartar cambios",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                grpBoxTurno.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Taimer.Hora horI = new Taimer.Hora((int)nUDHorIniMod.Value, (int)nUDMinIniMod.Value);
            Taimer.Hora horF = new Taimer.Hora((int)nUDHorFinMod.Value, (int)nUDMinFinMod.Value);

            Hora backup_horI = new Taimer.Hora(((Turno)grpBoxTurno.Tag).HoraInicio);
            Hora backup_horF = new Taimer.Hora(((Turno)grpBoxTurno.Tag).HoraFin);

            if (horI < horF)
            {
                Taimer.Turno turno = (Taimer.Turno)grpBoxTurno.Tag;
                try
                {
                    turno.CambiarHorasNoSuperpone(horI, horF);
                    turno.Dia = Taimer.TaimerLibrary.convertToDais(cmbBoxDiaMod.Text);
                    turno.Ubicacion = txtBoxLugarMod.Text;
                    loadAsig(currentAct);
                    if (!tModificados.Contains(turno))
                        tModificados.Add(turno);
                    
                    lbErrHoraMod.Visible = false;

                }
                catch (NotSupportedException exc)
                {
                    ((Turno)grpBoxTurno.Tag).HoraInicio = backup_horI;
                    ((Turno)grpBoxTurno.Tag).HoraFin = backup_horF;
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                lbErrHoraMod.Visible = true;
            }
        }

        private void btCreate_Click(object sender, EventArgs e)
        {

            if (parentGest != null)
            {

                try
                {
                    currentAct.Modificar();
                    foreach (Taimer.Turno item in tBorrados)
                    {
                        item.Borrar();
                    }
                    foreach (Taimer.Turno item in tCreados)
                    {
                        item.Agregar();
                    }
                    foreach (Taimer.Turno item in tModificados)
                    {
                        item.Modificar();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

                parentGest.changeCurrent(currentAct);

                Hide();
                parentGest.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
            else if (parentAdd != null)
            {

                Hide();
                parentAdd.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "¿Esta seguro de que desea descartar los cambios?",
                    "Descartar cambios",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {

                if (parentGest != null)
                {
                    dgTurnos.Rows.Clear();
                    // Reestablezco la asignatura
                    currentAct.CopiarDesde(currentActCopy);

                    Hide();
                    parentGest.Show();

                    AdminForm parent = (AdminForm)this.MdiParent;
                    parent.positionChilds();
                }
                else if (parentAdd != null)
                {
                    // Vacio la tabla
                    dgTurnos.Rows.Clear();
                    currentAct.CopiarDesde(currentActCopy);

                    Hide();
                    parentAdd.Show();

                    AdminForm parent = (AdminForm)this.MdiParent;
                    parent.positionChilds();
                }
            }
        }
    }
}
