namespace TaimerGUI {
    partial class AdminForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnTop = new System.Windows.Forms.Panel();
            this.btMaximize = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSidePanelEstad = new System.Windows.Forms.Button();
            this.btSidePanelAsig = new System.Windows.Forms.Button();
            this.btSidePanelUser = new System.Windows.Forms.Button();
            this.lbProvisional = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Cornsilk;
            this.pnTop.Controls.Add(this.btMaximize);
            this.pnTop.Controls.Add(this.btMinimize);
            this.pnTop.Controls.Add(this.btClose);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(884, 100);
            this.pnTop.TabIndex = 0;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            this.pnTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseMove);
            this.pnTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseUp);
            // 
            // btMaximize
            // 
            this.btMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximize.Location = new System.Drawing.Point(825, 3);
            this.btMaximize.Name = "btMaximize";
            this.btMaximize.Size = new System.Drawing.Size(25, 25);
            this.btMaximize.TabIndex = 4;
            this.btMaximize.Text = "M";
            this.btMaximize.UseVisualStyleBackColor = true;
            this.btMaximize.Click += new System.EventHandler(this.btMaximize_Click);
            this.btMaximize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btMinimize_MouseClick);
            // 
            // btMinimize
            // 
            this.btMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Location = new System.Drawing.Point(794, 3);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(25, 25);
            this.btMinimize.TabIndex = 3;
            this.btMinimize.Text = "m";
            this.btMinimize.UseVisualStyleBackColor = true;
            this.btMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btMinimize_MouseClick);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(856, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(25, 25);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btMinimize_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSidePanelEstad);
            this.panel1.Controls.Add(this.btSidePanelAsig);
            this.panel1.Controls.Add(this.btSidePanelUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 462);
            this.panel1.TabIndex = 1;
            // 
            // btSidePanelEstad
            // 
            this.btSidePanelEstad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSidePanelEstad.Location = new System.Drawing.Point(0, 300);
            this.btSidePanelEstad.Name = "btSidePanelEstad";
            this.btSidePanelEstad.Size = new System.Drawing.Size(100, 150);
            this.btSidePanelEstad.TabIndex = 2;
            this.btSidePanelEstad.Text = "Ver Estadisticas";
            this.btSidePanelEstad.UseVisualStyleBackColor = true;
            this.btSidePanelEstad.Click += new System.EventHandler(this.btSidePanelEstad_Click);
            // 
            // btSidePanelAsig
            // 
            this.btSidePanelAsig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSidePanelAsig.Location = new System.Drawing.Point(0, 150);
            this.btSidePanelAsig.Name = "btSidePanelAsig";
            this.btSidePanelAsig.Size = new System.Drawing.Size(100, 150);
            this.btSidePanelAsig.TabIndex = 1;
            this.btSidePanelAsig.Text = "Gestionar Asignaturas";
            this.btSidePanelAsig.UseVisualStyleBackColor = true;
            this.btSidePanelAsig.Click += new System.EventHandler(this.btSidePanelAsig_Click);
            // 
            // btSidePanelUser
            // 
            this.btSidePanelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSidePanelUser.Location = new System.Drawing.Point(0, 0);
            this.btSidePanelUser.Name = "btSidePanelUser";
            this.btSidePanelUser.Size = new System.Drawing.Size(100, 150);
            this.btSidePanelUser.TabIndex = 0;
            this.btSidePanelUser.Text = "Gestionar Usuarios";
            this.btSidePanelUser.UseVisualStyleBackColor = true;
            this.btSidePanelUser.Click += new System.EventHandler(this.btSidePanelUser_Click);
            // 
            // lbProvisional
            // 
            this.lbProvisional.AutoSize = true;
            this.lbProvisional.Location = new System.Drawing.Point(377, 282);
            this.lbProvisional.Name = "lbProvisional";
            this.lbProvisional.Size = new System.Drawing.Size(14, 13);
            this.lbProvisional.TabIndex = 2;
            this.lbProvisional.Text = "S";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.lbProvisional);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMaximize;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSidePanelEstad;
        private System.Windows.Forms.Button btSidePanelAsig;
        private System.Windows.Forms.Button btSidePanelUser;
        private System.Windows.Forms.Label lbProvisional;
    }
}