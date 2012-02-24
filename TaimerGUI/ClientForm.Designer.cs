namespace TaimerGUI {
    partial class ClientForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTittle = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btMaximize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.iconNotifClient = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxtMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pefilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu.SuspendLayout();
            this.pnlTittle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ctxtMenuTray.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Location = new System.Drawing.Point(1, 75);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(165, 581);
            this.pnlMenu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Horarios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlTittle
            // 
            this.pnlTittle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTittle.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlTittle.Controls.Add(this.panel1);
            this.pnlTittle.Controls.Add(this.panel3);
            this.pnlTittle.Location = new System.Drawing.Point(1, 1);
            this.pnlTittle.Name = "pnlTittle";
            this.pnlTittle.Size = new System.Drawing.Size(935, 76);
            this.pnlTittle.TabIndex = 4;
            this.pnlTittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTittle_MouseDown);
            this.pnlTittle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTittle_MouseMove);
            this.pnlTittle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTittle_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btMaximize);
            this.panel3.Controls.Add(this.btClose);
            this.panel3.Controls.Add(this.btMinimize);
            this.panel3.Location = new System.Drawing.Point(825, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 36);
            this.panel3.TabIndex = 7;
            // 
            // btMaximize
            // 
            this.btMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btMaximize.FlatAppearance.BorderSize = 0;
            this.btMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximize.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMaximize.ForeColor = System.Drawing.Color.Maroon;
            this.btMaximize.Location = new System.Drawing.Point(43, 0);
            this.btMaximize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btMaximize.Name = "btMaximize";
            this.btMaximize.Size = new System.Drawing.Size(31, 27);
            this.btMaximize.TabIndex = 11;
            this.btMaximize.Text = "O";
            this.btMaximize.UseVisualStyleBackColor = false;
            this.btMaximize.Click += new System.EventHandler(this.btMaximize_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.Maroon;
            this.btClose.Location = new System.Drawing.Point(80, -3);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(31, 27);
            this.btClose.TabIndex = 9;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimize.ForeColor = System.Drawing.Color.Maroon;
            this.btMinimize.Location = new System.Drawing.Point(4, -4);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(31, 27);
            this.btMinimize.TabIndex = 10;
            this.btMinimize.Text = "__";
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // iconNotifClient
            // 
            this.iconNotifClient.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.iconNotifClient.BalloonTipText = "Taimer horario";
            this.iconNotifClient.ContextMenuStrip = this.ctxtMenuTray;
            this.iconNotifClient.Icon = ((System.Drawing.Icon)(resources.GetObject("iconNotifClient.Icon")));
            this.iconNotifClient.Text = "notifyIcon1";
            this.iconNotifClient.Visible = true;
            this.iconNotifClient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.iconNotifClient_MouseDoubleClick);
            // 
            // ctxtMenuTray
            // 
            this.ctxtMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.ctxtMenuTray.Name = "ctxtMenuTray";
            this.ctxtMenuTray.Size = new System.Drawing.Size(143, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem1.Text = "Cerrar sesion";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem2.Text = "Salir";
            this.toolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(825, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 175);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::TaimerGUI.Properties.Resources.orange_user_md;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(85, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(107, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pefilToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.userToolStripMenuItem.Text = "Martin Mola";
            // 
            // pefilToolStripMenuItem
            // 
            this.pefilToolStripMenuItem.Name = "pefilToolStripMenuItem";
            this.pefilToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pefilToolStripMenuItem.Text = "Pefil";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(938, 657);
            this.Controls.Add(this.pnlTittle);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "ClientForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTittle.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ctxtMenuTray.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlTittle;
        private System.Windows.Forms.NotifyIcon iconNotifClient;
        private System.Windows.Forms.ContextMenuStrip ctxtMenuTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMaximize;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pefilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;


    }
}