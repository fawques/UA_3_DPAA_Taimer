﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Visible)
            {
                button2.Text = "Hacerse un Horario";
            }
            else
            {
                button2.Text = "Hahahahah tonto";
            }
            label1.Visible = !label1.Visible;
        }
    }
}
