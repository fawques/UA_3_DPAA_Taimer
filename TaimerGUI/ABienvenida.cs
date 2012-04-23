using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class ABienvenida : Form {
        public ABienvenida() {
            InitializeComponent();
            
        }

        private void ABienvenida_Activated(object sender, EventArgs e)
        {
            lbNumUsers.Text = Program.Usuarios.Count.ToString();
            lbNumAsig.Text = Program.Asignaturas.Count.ToString();
            int horarios = 0;
            int act_p = 0;
            foreach (Taimer.User usuario in Program.Usuarios)
            {
                act_p += usuario.ActPersonales.Count;
                horarios += usuario.Horarios.Count;
            }
            lbNumHorarios.Text = horarios.ToString();
            lbNumActPers.Text = act_p.ToString();
        }

    }
}
