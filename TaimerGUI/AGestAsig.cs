using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class AGestAsig : Form {

        AAddAsig childForm = null;

        public AGestAsig() {
            InitializeComponent();
        }

        public void setChild(AAddAsig form) {
            childForm = form;
        }

        private void btNewUser_Click_1(object sender, EventArgs e) {
            if (childForm != null) {
                Hide();
                childForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }
    }
}
