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
        private User user_backup;
        public ClientMatriculacionActiv(User usr) {
            InitializeComponent();
            usrAux = usr;
        }

        private void loadMatriculadas() {
            dataGridMatric.Rows.Clear();
            foreach (Actividad_a act in usrAux.ActAcademicas) {
                dataGridMatric.Rows.Add(act.Nombre, act.Descripcion);
                dataGridMatric.Rows[dataGridMatric.Rows.Count - 1].Tag = act;
            }
        }

        private void loadDisponibles() {
            dataGridActuales.Rows.Clear();
            foreach (Actividad_a act in Program.Asignaturas) {
                if (!usrAux.ActAcademicas.Contains(act)) {
                    dataGridActuales.Rows.Add(act.Nombre, act.Descripcion);
                    dataGridActuales.Rows[dataGridActuales.Rows.Count-1].Tag = act;
                }
            }
        }

        private void ClientMatriculacionActiv_Activated(object sender, EventArgs e) {
            user_backup = Program.Usuarios[0];
            usrAux = new User(user_backup);
            this.loadDisponibles();
            this.loadMatriculadas();
            btnConfirm.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e) {
            if (dataGridActuales.SelectedRows.Count > 0) {
                foreach (DataGridViewRow selRow in dataGridActuales.SelectedRows) {
                    try
                    {
                        //Hacer que aqui no haga nada en la bd
                        usrAux.AddActAcademica((Actividad_a)selRow.Tag);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    

                    dataGridActuales.Rows.Remove(selRow);

                    dataGridMatric.Rows.Add(selRow);
                }
                btnConfirm.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (dataGridMatric.SelectedRows.Count > 0) {
                foreach (DataGridViewRow selRow in dataGridMatric.SelectedRows) {
                    try
                    {
                        //Hacer que aqui no haga nada en la bd
                        usrAux.BorraActAcademica((Actividad_a)selRow.Tag);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

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
                          //try {
                              Program.Usuarios[0].UpdateMatricula(usrAux.ActAcademicas);
                          /*} catch (Exception exc) {
                              MessageBox.Show(exc.Message);
                          }*/
                            //Hacer que esto guarde todos los cambios en las matriculadas en la bd
                          //usrAux.Matricular();

                //Miro las filas de las matriculadas y si no estaban ya se las anyado
                /*foreach (DataGridViewRow row in dataGridMatric.Rows) {
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
                }*/
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

        private void txtBoxFiltroAct_TextChanged(object sender, EventArgs e)
        {
            loadDisponibles(txtBoxFiltroAct.Text);
        }

        private void loadDisponibles(string nom)
        {
            nom = nom.ToLower();
            if (usrAux != null)
            {
                dataGridActuales.Rows.Clear();
                foreach (Actividad_a obj in Program.Asignaturas)
                {
                    if (!!usrAux.ActAcademicas.Contains(obj) &&
                        (obj.Nombre.ToLower().Contains(nom) || obj.Descripcion.ToLower().Contains(nom) || obj.NombreCoordinador.ToLower().Contains(nom)))
                    {
                        dataGridActuales.Rows.Add(obj.Nombre, obj.Descripcion);
                        dataGridActuales.Rows[dataGridActuales.Rows.Count - 1].Tag = obj;
                    }
                }
            }
        }

        private void txtBoxFiltroMat_TextChanged(object sender, EventArgs e)
        {
            loadMatriculadas(txtBoxFiltroMat.Text);
        }

        private void loadMatriculadas(string nom)
        {
            nom = nom.ToLower();
            if (usrAux != null)
            {
                dataGridMatric.Rows.Clear();
                foreach (Actividad_a obj in usrAux.ActAcademicas)
                {
                    if (obj.Nombre.ToLower().Contains(nom) || obj.Descripcion.ToLower().Contains(nom) || obj.NombreCoordinador.ToLower().Contains(nom))
                    {
                        dataGridMatric.Rows.Add(obj.Nombre, obj.Descripcion);
                        dataGridMatric.Rows[dataGridMatric.Rows.Count - 1].Tag = obj;
                    }
                }
            }
        }

        


    }
}

