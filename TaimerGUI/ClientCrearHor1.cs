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
    public partial class ClientCrearHor1 : Form
    {
        ClientCrearHor2 formContinue = null;
        User usrAux = null;

        public ClientCrearHor1(User usr)
        {
            InitializeComponent();
            usrAux = usr;
        }

        public void setContinueForm(ClientCrearHor2 form)
        {
            formContinue = form;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblNombre.Text != "")
            {
                if (dataGridActHor.Rows.Count > 0) {
                    if (formContinue != null) {
                        formContinue.Show();
                        formContinue.Focus();
                    }
                } else {
                    lblErrorActiv.Visible = true;
                }
            }
            else
            {
                tBxNombre_Leave(null, null);
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            
            tBxNombre.Text = lblNombre.Text;
            lblNombre.Visible = false;
            tBxNombre.Visible = true;
            tBxNombre.Focus();
            tBxNombre.SelectionStart = 0;
            tBxNombre.SelectionLength = lblNombre.Text.Length;
        }

        private void tBxNombre_Leave(object sender, EventArgs e)
        {
            if (tBxNombre.Text != "")
            {
                tBxNombre.Visible = false;
                lblNombre.Visible = true;
                lblErrorNombre.Visible = false;
            }
            else
            {
                tBxNombre.Focus();
                lblErrorNombre.Visible = true;
            }
            lblNombre.Text = tBxNombre.Text;
        }

        private void ClientCrearHor1_Load(object sender, EventArgs e)
        {
            tBxNombre.Focus();
            loadActividadesMatriculadas();
        }

        public void reiniciar() {
            tBxNombre.Text = "";
            lblNombre.Text = "";
            lblErrorNombre.Visible = false;
            tBxNombre.Visible = true;
            lblNombre.Visible = false;
            dataGridMyAct.Rows.Clear();
            dataGridActHor.Rows.Clear();
            loadActividadesMatriculadas();
        }

        private void button1_Click(object sender, EventArgs e) {

            if (dataGridMyAct.SelectedRows.Count > 0) {
                foreach (DataGridViewRow selRow in dataGridMyAct.SelectedRows) {
                    dataGridMyAct.Rows.Remove(selRow);
                    
                    dataGridActHor.Rows.Add(selRow);
                }

                lblErrorActiv.Visible = false;
            }
        }
        /* Cargar actividades*/
        private void loadActividadesMatriculadas() {
            dataGridMyAct.Rows.Clear();
            foreach (Actividad obj in usrAux.ActPersonales) {
                dataGridMyAct.Rows.Add(obj.Nombre, obj.Descripcion);
                dataGridMyAct.Rows[dataGridMyAct.Rows.Count - 1].Tag = obj;
            }
            dataGridActHor.Rows.Clear();
            foreach (Actividad obj in usrAux.ActAcademicas) {
                dataGridMyAct.Rows.Add(obj.Nombre, obj.Descripcion);
                dataGridMyAct.Rows[dataGridMyAct.Rows.Count - 1].Tag = obj;
            }
        }
        /*Cargar actividades con filtro de nombre*/
        private void loadActividadesMatriculadas(string nom) {
            dataGridMyAct.Rows.Clear();
            foreach (Actividad obj in usrAux.ActPersonales) {
                if (obj.Nombre.ToLower().Contains(nom) && !isInGrid(obj.Codigo.ToString(), dataGridActHor)) {
                    dataGridMyAct.Rows.Add(obj.Nombre, obj.Descripcion);
                    dataGridMyAct.Rows[dataGridMyAct.Rows.Count - 1].Tag = obj;
                }
            }
            foreach (Actividad obj in usrAux.ActAcademicas) {
                if (obj.Nombre.ToLower().Contains(nom) && !isInGrid(obj.Codigo.ToString(), dataGridActHor)) {
                    dataGridMyAct.Rows.Add(obj.Nombre, obj.Descripcion);
                    dataGridMyAct.Rows[dataGridMyAct.Rows.Count - 1].Tag = obj;
                }
            }
        }

        private void ClientCrearHor1_Activated(object sender, EventArgs e) {
            
        }

        private void btnLeft_Click(object sender, EventArgs e) {
            if (dataGridActHor.SelectedRows.Count > 0) {
                foreach (DataGridViewRow selRow in dataGridActHor.SelectedRows) {
                    dataGridActHor.Rows.Remove(selRow);
                    dataGridMyAct.Rows.Add(selRow);
                }
            }
        }

        private bool isInGrid(string cod, DataGridView dtv) {

            foreach (DataGridViewRow selRow in dtv.Rows) {
                if (selRow.Cells[0].Value.ToString() == cod){
                    return true;
                }
            }

            return false;
        }

        private void txtBoxFiltrMy_TextChanged(object sender, EventArgs e) {
            loadActividadesMatriculadas(txtBoxFiltrMy.Text.ToLower());
        }

        public List<Actividad_p> getActividadesP(){
            List<Actividad_p> aux = new List<Actividad_p>();
            foreach (DataGridViewRow row in dataGridActHor.Rows) {

                if (row.Tag is Actividad_p) {
                    aux.Add((Actividad_p)row.Tag);
                }
            }
            return aux;
        }

        public List<Actividad_a> getActividadesA() {
            List<Actividad_a> aux = new List<Actividad_a>();
            foreach (DataGridViewRow row in dataGridActHor.Rows) {
                if (row.Tag is Actividad_a) {
                    aux.Add((Actividad_a)row.Tag);
                }
            }
            return aux;
        }


        public string getNameHorario() {
            if (lblNombre.Visible) {
                return lblNombre.Text;
            } else {
                return tBxNombre.Text;
            }
        }

        private void dataGridMyAct_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
               // dataGridMyAct.Rows[e.RowIndex].HeaderCell.
            }
        }

    }
}
