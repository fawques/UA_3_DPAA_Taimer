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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iconNotifClient = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxtMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pefilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStUser = new System.Windows.Forms.MenuStrip();
            this.pnlTittle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnUserOption = new System.Windows.Forms.MenuStrip();
            this.martinMolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btMaximize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.pnlResize = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mnStMain = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu.SuspendLayout();
            this.ctxtMenuTray.SuspendLayout();
            this.pnlTittle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnUserOption.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mnStMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 69);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 611);
            this.pnlMenu.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(-1, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ir a la página";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Horarios";
            this.button1.UseVisualStyleBackColor = true;
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
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripCloseSesion_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem2.Text = "Salir";
            this.toolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pefilToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.userToolStripMenuItem.Text = "Martin Mola";
            // 
            // pefilToolStripMenuItem
            // 
            this.pefilToolStripMenuItem.Name = "pefilToolStripMenuItem";
            this.pefilToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.pefilToolStripMenuItem.Text = "Pefil";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // mnStUser
            // 
            this.mnStUser.BackColor = System.Drawing.Color.Transparent;
            this.mnStUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnStUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnStUser.Location = new System.Drawing.Point(0, 0);
            this.mnStUser.Name = "mnStUser";
            this.mnStUser.Size = new System.Drawing.Size(107, 24);
            this.mnStUser.TabIndex = 3;
            this.mnStUser.Text = "menuStrip1";
            // 
            // pnlTittle
            // 
            this.pnlTittle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTittle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTittle.BackgroundImage = global::TaimerGUI.Properties.Resources.pruba11;
            this.pnlTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTittle.Controls.Add(this.panel2);
            this.pnlTittle.Controls.Add(this.label1);
            this.pnlTittle.Controls.Add(this.panel1);
            this.pnlTittle.Controls.Add(this.panel3);
            this.pnlTittle.Location = new System.Drawing.Point(-1, -1);
            this.pnlTittle.Name = "pnlTittle";
            this.pnlTittle.Size = new System.Drawing.Size(1000, 75);
            this.pnlTittle.TabIndex = 4;
            this.pnlTittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTittle_MouseDown);
            this.pnlTittle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTittle_MouseMove);
            this.pnlTittle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTittle_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Taimer";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTittle_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTittle_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTittle_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.mnUserOption);
            this.panel1.Location = new System.Drawing.Point(887, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 175);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::TaimerGUI.Properties.Resources.orange_user_md;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(86, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mnUserOption
            // 
            this.mnUserOption.BackColor = System.Drawing.Color.Transparent;
            this.mnUserOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnUserOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.martinMolaToolStripMenuItem});
            this.mnUserOption.Location = new System.Drawing.Point(0, 0);
            this.mnUserOption.Name = "mnUserOption";
            this.mnUserOption.Size = new System.Drawing.Size(111, 24);
            this.mnUserOption.TabIndex = 3;
            this.mnUserOption.Text = "menuStrip1";
            // 
            // martinMolaToolStripMenuItem
            // 
            this.martinMolaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.martinMolaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.martinMolaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.martinMolaToolStripMenuItem.Name = "martinMolaToolStripMenuItem";
            this.martinMolaToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.martinMolaToolStripMenuItem.Text = "Martin mola";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.toolStripCloseSesion_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btMaximize);
            this.panel3.Controls.Add(this.btClose);
            this.panel3.Controls.Add(this.btMinimize);
            this.panel3.Location = new System.Drawing.Point(900, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 36);
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
            this.btMaximize.Location = new System.Drawing.Point(41, -1);
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
            this.btClose.Location = new System.Drawing.Point(70, -3);
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
            this.btMinimize.Location = new System.Drawing.Point(7, -6);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(31, 27);
            this.btMinimize.TabIndex = 10;
            this.btMinimize.Text = "__";
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // pnlResize
            // 
            this.pnlResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResize.BackColor = System.Drawing.Color.Transparent;
            this.pnlResize.BackgroundImage = global::TaimerGUI.Properties.Resources.resize2;
            this.pnlResize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pnlResize.Location = new System.Drawing.Point(978, 653);
            this.pnlResize.Name = "pnlResize";
            this.pnlResize.Size = new System.Drawing.Size(20, 20);
            this.pnlResize.TabIndex = 6;
            this.pnlResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlResize_MouseDown);
            this.pnlResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlResize_MouseMove);
            this.pnlResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlResize_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mnStMain);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 27);
            this.panel2.TabIndex = 11;
            // 
            // mnStMain
            // 
            this.mnStMain.BackColor = System.Drawing.Color.Transparent;
            this.mnStMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnStMain.Location = new System.Drawing.Point(0, 0);
            this.mnStMain.Name = "mnStMain";
            this.mnStMain.Size = new System.Drawing.Size(274, 24);
            this.mnStMain.TabIndex = 11;
            this.mnStMain.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.archivoToolStripMenuItem.Text = "Taimer";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.editarToolStripMenuItem.Text = "Horarios";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.herramientasToolStripMenuItem.Text = "Asignaturas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // ClientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.pnlTittle);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlResize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "ClientForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ctxtMenuTray.ResumeLayout(false);
            this.pnlTittle.ResumeLayout(false);
            this.pnlTittle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnUserOption.ResumeLayout(false);
            this.mnUserOption.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mnStMain.ResumeLayout(false);
            this.mnStMain.PerformLayout();
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
        private System.Windows.Forms.MenuStrip mnUserOption;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pefilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnStUser;
        private System.Windows.Forms.ToolStripMenuItem martinMolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlResize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip mnStMain;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;


    }
}