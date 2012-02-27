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
            if (formContinue != null)
            {
                Hide();
                formContinue.Show();
                ClientForm pare = (ClientForm)this.MdiParent;
                pare.positionAllChilds();
            }
        }
    }
}
