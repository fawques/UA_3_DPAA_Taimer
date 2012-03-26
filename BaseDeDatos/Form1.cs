using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CAD.CADUser user = new CAD.CADUser();
            user.CrearUserBasic("0000008", "Higinio Mora", "higinio@mora.es", "higiniomola");
        }
    }
}
