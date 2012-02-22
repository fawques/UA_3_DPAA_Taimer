using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaimerGUI {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e) {
            
            GraphicsPath shape = RoundedRectangle.Create(0, 0, 400, 400, 20);
            this.Region = new System.Drawing.Region(shape); ;
            
        }

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams {
            get {
                CreateParams p = base.CreateParams;
                p.ClassStyle |= CS_DROPSHADOW;
                return p;
            }
        }

        bool beingDragged;
        Point mouseOffset;
        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            beingDragged = true;
            mouseOffset.X = e.X;
            mouseOffset.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if (this.beingDragged) {
                Point currentScreenPos = PointToScreen(e.Location);
                Point p = new Point(currentScreenPos.X - this.mouseOffset.X, currentScreenPos.Y - this.mouseOffset.Y);
                this.Location = p;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e) {
            this.beingDragged = false;
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            beingDragged = false;
        }
    }
}
