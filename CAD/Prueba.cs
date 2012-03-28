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
        private CADActividad_p actp = new CADActividad_p();

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
            /*Obtiene el nombre del usuario mediante el DNI introducido*/
            DataSet data = user.GetDatosUser(tb2User.Text);
            if (data == null)
                label1.Text = "No existe";
                
            else
            {
                string name = data.Tables[0].Rows[0].ItemArray[1].ToString();
                label1.Text = "Nombre: "+name;
            }

            /*Ejemplo para mostrar el último código generado
            DataSet code = actp.LastCode();
            string last = code.Tables[0].Rows[0].ItemArray[0].ToString();
            label1.Text = "Último código: " + last;*/
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
