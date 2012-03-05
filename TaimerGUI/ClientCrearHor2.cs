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
    public partial class ClientCrearHor2 : Form
    {
        ClientCrearHor1 formBack = null;

        public ClientCrearHor2()
        {
            InitializeComponent();
        }

        public void setBackForm(ClientCrearHor1 form)
        {
            formBack = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formBack != null)
            {
                Hide();
                formBack.Show();
                ClientForm pare = (ClientForm)this.MdiParent;
                pare.positionAllChilds();
            }
            
        }
    }
}
