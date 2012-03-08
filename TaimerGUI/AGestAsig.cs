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

        AAddAsig childNew = null;
        AGestTurno childGes = null;

        public AGestAsig() {
            InitializeComponent();
        }

        public void setChild(AAddAsig form1, AGestTurno form2) {
            childNew = form1;
            childGes = form2;
        }

        private void btNewUser_Click_1(object sender, EventArgs e) {
            if (childNew != null) {
                Hide();
                childNew.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (childGes != null) {
                Hide();
                childGes.Show();

                AdminForm parent = (AdminForm)this.MdiParent;
                parent.positionChilds();
            }
        }
    }
}
