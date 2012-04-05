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
    public partial class ClientHorHome : Form
    {
        private User usrAux = null;
        private ClientHorVer verHorForm = null;
        public ClientHorHome(User usr, ClientHorVer f)
        {
            InitializeComponent();
            usrAux = usr;
            verHorForm = f;
        }

        private void button1_Click(object sender, EventArgs e) {
            
        }

        private void ClientHorHome_Activated(object sender, EventArgs e) {
            this.loadHorarios();
        }
        public void loadHorarios() {
            if (usrAux != null) {
                dataGridHorarios.Rows.Clear();
                foreach (Horario hor in usrAux.Horarios) {
                    dataGridHorarios.Rows.Add(hor.ID,hor.Nombre);
                    dataGridHorarios.Rows[dataGridHorarios.Rows.Count - 1].Tag = hor;
                }
            }
        }
        public void loadHorarios(string patron) {
            if (usrAux != null) {
                dataGridHorarios.Rows.Clear();
                foreach (Horario hor in usrAux.Horarios) {
                    if (hor.Nombre.Contains(patron) || hor.ID.ToString().Contains(patron)){
                        dataGridHorarios.Rows.Add(hor.ID, hor.Nombre);
                        dataGridHorarios.Rows[dataGridHorarios.Rows.Count - 1].Tag = hor;
                    }
                }
            }
        }

        private void dataGridHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                if (e.ColumnIndex == dataGridHorarios.Columns["Borrar"].Index) {
                    try {
                        usrAux.BorraHorario((Horario)dataGridHorarios.Rows[e.RowIndex].Tag);
                    } catch (NotSupportedException exc) {
                        MessageBox.Show(exc.Message);
                    }
                    dataGridHorarios.Rows.RemoveAt(e.RowIndex);
                    ((ClientForm)this.MdiParent).loadLastHorarios();
                } else if (e.ColumnIndex == dataGridHorarios.Columns["Ver"].Index) {
                    if (dataGridHorarios.Rows[e.RowIndex].Tag is Horario) {
                        verHorForm.setHorario((Horario)dataGridHorarios.Rows[e.RowIndex].Tag);
                        verHorForm.Show();
                        verHorForm.Focus();
                    } else {
                        MessageBox.Show("Horario no valido", "El horario seleccionado no es valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtBoxFilter_TextChanged(object sender, EventArgs e) {
            this.loadHorarios(txtBoxFilter.Text);
        }
    }
}
