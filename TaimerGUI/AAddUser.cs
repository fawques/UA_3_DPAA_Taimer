using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class AAddUser : Form {

        AGestUser parentForm = null;

        public AAddUser() {
            InitializeComponent();
        }

        public void setParent(AGestUser form) {
            parentForm = form;
        }

        private void button3_Click(object sender, EventArgs e) {
            if (parentForm != null) {
                Hide();
                parentForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CAD.CADUser user= new CAD.CADUser();
            user.CrearUser("0000006",textBox1.Text+" "+textBox2.Text,textBox3.Text,textBox1.Text);

        }
    }
}
