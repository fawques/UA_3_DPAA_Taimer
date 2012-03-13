using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class ClientCrearHor2 : Form {
        ClientCrearHor1 formBack = null;

        public ClientCrearHor2() {
            InitializeComponent();
        }

        public void setBackForm(ClientCrearHor1 form) {
            formBack = form;
        }

        private void button2_Click(object sender, EventArgs e) {
            if (formBack != null) {
                Hide();
                formBack.Show();
                ClientForm pare = (ClientForm)this.MdiParent;
                pare.positionAllChilds();
            }

        }

        private void chkBxAll_CheckedChanged(object sender, EventArgs e) {
            switchCheckAllDays();
        }
        void switchCheckAllDays() {
            foreach (Control c in groubBoxDias.Controls)
            {
                if (c is CheckBox && ((CheckBox)c).Name != "chkBxAll") {
                    ((CheckBox)c).Checked = !((CheckBox)c).Checked;
                }
            }

        }
    }
}
