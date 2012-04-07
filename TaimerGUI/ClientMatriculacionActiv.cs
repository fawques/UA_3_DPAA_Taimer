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
    public partial class ClientMatriculacionActiv : Form {
        private User usrAux;
        public ClientMatriculacionActiv(User usr) {
            InitializeComponent();
            usrAux = usr;
        }

        private void loadMatriculadas() {
            dataGridMatric.Rows.Clear();
            foreach (Actividad_a act in Program.Usuarios[0].ActAcademicas) {
                dataGridMatric.Rows.Add(act.Codigo.ToString(), act.Nombre, act.Descripcion);
                dataGridMatric.Rows[dataGridMatric.Rows.Count - 1].Tag = act;
            }
        }

        private void loadDisponibles() {
            dataGridActuales.Rows.Clear();
            foreach (Actividad_a act in Program.Asignaturas) {
                if (!Program.Usuarios[0].ActAcademicas.Contains(act)) {
                    dataGridActuales.Rows.Add(act.Codigo.ToString(), act.Nombre, act.Descripcion);
                    dataGridActuales.Rows[dataGridActuales.Rows.Count-1].Tag = act;
                }
            }
        }

        private void ClientMatriculacionActiv_Activated(object sender, EventArgs e) {
            this.loadDisponibles();
            this.loadMatriculadas();
            btnConfirm.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (dataGridActuales.SelectedRows.Count > 0) {
                foreach (DataGridViewRow selRow in dataGridActuales.SelectedRows) {
                    dataGridActuales.Rows.Remove(selRow);

                    dataGridMatric.Rows.Add(selRow);
                }
                btnConfirm.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (dataGridMatric.SelectedRows.Count > 0) {
                foreach (DataGridViewRow selRow in dataGridMatric.SelectedRows) {
                    dataGridMatric.Rows.Remove(selRow);

                    dataGridActuales.Rows.Add(selRow);
                }
                btnConfirm.Enabled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Seguro que desa guardar los cambios en matriculación?",
                      "¿Guardar cambios?",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button2) == DialogResult.Yes) {

                //Miro las filas de las matriculadas y si no estaban ya se las anyado
                foreach (DataGridViewRow row in dataGridMatric.Rows) {
                    if (row.Tag is Actividad_a) {
                        if (!Program.Usuarios[0].ActAcademicas.Contains((Actividad_a)row.Tag)) {
                            try {
                                Program.Usuarios[0].AddActAcademica((Actividad_a)row.Tag);
                            } catch (Exception ex) {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                //Miro las filas de las disponibles y si estaban en el usuario las borro
                foreach (DataGridViewRow row in dataGridActuales.Rows) {
                    if (row.Tag is Actividad_a) {
                        if (Program.Usuarios[0].ActAcademicas.Contains((Actividad_a)row.Tag)) {
                            try {
                                Program.Usuarios[0].BorraActAcademica((Actividad_a)row.Tag);
                            } catch (Exception ex) {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                ((ClientForm)this.MdiParent).verActividades_Click(null, null);
            }
                         
        }

        private void btnDescart_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Seguro que desa descartar los cambios en matriculación?",
                      "¿Descartar cambios?",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                ((ClientForm)this.MdiParent).verActividades_Click(null, null);
            }
        }
    }
}
