using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TaimerGUI {
    public partial class ClientCreandoAlgoritmo : Form {
        public ClientCreandoAlgoritmo() {
            InitializeComponent();
        }

        private void ClientCreandoAlgoritmo_Load(object sender, EventArgs e) {
            
        }

        private void ClientCreandoAlgoritmo_Activated(object sender, EventArgs e) {
            this.Refresh();
            Thread.Sleep(2000);
            //this.Close();
        }

        private void ClientCreandoAlgoritmo_Shown(object sender, EventArgs e) {
            
        }
    }
}
