using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class AGestUser : Form {

        AAddUser childForm = null;

        public AGestUser() {
            InitializeComponent();
        }

        public void setChild(AAddUser form) {
            childForm = form;
        }

        private void btNewUser_Click(object sender, EventArgs e) {
            if (childForm != null) {
                Hide();
                childForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }
    }
}
