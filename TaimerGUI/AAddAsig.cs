using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class AAddAsig : Form {

        AGestAsig parentForm = null;
        AAddTurn childForm = null;

        public AAddAsig() {
            InitializeComponent();
        }

        public void setParent(AGestAsig form) {
            parentForm = form;
        }

        public void setChild(AAddTurn form) {
            childForm = form;
        }

        private void button3_Click(object sender, EventArgs e) {
            if (parentForm != null) {
                Hide();
                parentForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (childForm != null) {
                Hide();
                childForm.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }
    }
}
