using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taimer;

namespace TaimerGUI
{
    public partial class ClientMatriculacionActiv : Form
    {
        private User usrAux;
        public ClientMatriculacionActiv(User usr)
        {
            InitializeComponent();
            usrAux = usr;
        }

        private void loadMatriculadas() {

        }

        private void loadDisponibles() {
        }
    }
}
