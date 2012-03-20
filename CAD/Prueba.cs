using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAD
{
    public partial class Prueba : Form
    {
        private CADTitulacion tit=new CADTitulacion();
        private CADUser user = new CADUser();
        private CADAdmin admin = new CADAdmin();
        private CADComentario com = new CADComentario();
        private CADHorario hor = new CADHorario();

        public Prueba()
        {            
            InitializeComponent();
        }

        private void bt1Tit_Click(object sender, EventArgs e)
        {
            tit.CrearTitulacion(tb1Tit.Text,tb2Tit.Text);
        }

        private void bt2Tit_Click(object sender, EventArgs e)
        {
            tit.BorrarTitulacion(tb1Tit.Text);            
        }

        private void bt3Tit_Click(object sender, EventArgs e)
        {
            tit.ModificaTitulacion(tb1Tit.Text,tb2Tit.Text);
        }

        private void bt1User_Click(object sender, EventArgs e)
        {
            user.CrearUserBasic(tb2User.Text, tb1User.Text, tb3User.Text, tb4User.Text);
            //admin.CrearAdminBasic(tb2User.Text, tb1User.Text, tb3User.Text, tb4User.Text);
        }

        private void bt2User_Click(object sender, EventArgs e)
        {
            user.BorrarUser(tb2User.Text);
        }

        private void bt3User_Click(object sender, EventArgs e)
        {
            user.ModificaUser(tb2User.Text, tb1User.Text,tb3User.Text,tb4User.Text);
        }

        private void bt4User_Click(object sender, EventArgs e)
        {
            DataSet data=user.GetUsers();            
        }

        private void bt1Com_Click(object sender, EventArgs e)
        {
            com.CrearCommentBasic(Convert.ToInt32(tb1Com.Text), tb2Com.Text,Convert.ToInt32(tb3Com.Text), tb4Com.Text);
            //hor.CrearHorarioBasic(Convert.ToInt32(tb1Com.Text), tb2Com.Text, tb3Com.Text);
        }

        private void bt2Com_Click(object sender, EventArgs e)
        {
            com.BorrarComment(Convert.ToInt32(tb1Com.Text));
        }

        private void bt3Com_Click(object sender, EventArgs e)
        {
            com.ModificaComment(Convert.ToInt32(tb1Com.Text), tb2Com.Text, Convert.ToInt32(tb3Com.Text), tb4Com.Text);
        }

    }
}
