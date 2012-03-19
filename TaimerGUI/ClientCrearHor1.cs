using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI
{
    public partial class ClientCrearHor1 : Form
    {
        ClientCrearHor2 formContinue = null;

        public ClientCrearHor1()
        {
            InitializeComponent();
            
        }

        public void setContinueForm(ClientCrearHor2 form)
        {
            formContinue = form;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblNombre.Text != "")
            {
                if (formContinue != null)
                {
                    formContinue.Show();
                    formContinue.Focus();
                    ClientForm pare = (ClientForm)this.MdiParent;
                    pare.positionAllChilds();
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
        }
    }
}
