namespace TaimerGUI {
    partial class AGestUser {
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btNewUser = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.btBuscarUSer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCurso = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTitu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbCurso = new System.Windows.Forms.TextBox();
            this.tbTitu = new System.Windows.Forms.TextBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tbUsers
            // 
            this.tbUsers.AllowUserToOrderColumns = true;
            this.tbUsers.BackgroundColor = System.Drawing.Color.Wheat;
            this.tbUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nombre});
            this.tbUsers.Location = new System.Drawing.Point(93, 132);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Size = new System.Drawing.Size(303, 334);
            this.tbUsers.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 230;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(542, 132);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(136, 29);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Pepe Gotera";
            this.lbUserName.Click += new System.EventHandler(this.lbUserName_Click);
            // 
            // btNewUser
            // 
            this.btNewUser.Location = new System.Drawing.Point(289, 470);
            this.btNewUser.Name = "btNewUser";
            this.btNewUser.Size = new System.Drawing.Size(107, 24);
            this.btNewUser.TabIndex = 3;
            this.btNewUser.Text = "Nuevo Usuario";
            this.btNewUser.UseVisualStyleBackColor = true;
            this.btNewUser.Click += new System.EventHandler(this.btNewUser_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(456, 145);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Correo Electronico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DNI:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(544, 196);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(89, 13);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "lalala@lalala.com";
            this.lbEmail.Click += new System.EventHandler(this.lbEmail_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(544, 234);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(39, 13);
            this.lbUser.TabIndex = 9;
            this.lbUser.Text = "Cliente";
            this.lbUser.Click += new System.EventHandler(this.lbUser_Click);
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(544, 273);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(62, 13);
            this.lbDni.TabIndex = 10;
            this.lbDni.Text = "11111111X";
            this.lbDni.Click += new System.EventHandler(this.lbDni_Click);
            // 
            // btBuscarUSer
            // 
            this.btBuscarUSer.Location = new System.Drawing.Point(321, 104);
            this.btBuscarUSer.Name = "btBuscarUSer";
            this.btBuscarUSer.Size = new System.Drawing.Size(75, 20);
            this.btBuscarUSer.TabIndex = 11;
            this.btBuscarUSer.Text = "Buscar";
            this.btBuscarUSer.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 39);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gestionar Usuarios";
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Location = new System.Drawing.Point(544, 311);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(50, 13);
            this.lbCurso.TabIndex = 14;
            this.lbCurso.Text = "Segundo";
            this.lbCurso.Click += new System.EventHandler(this.lbCurso_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(468, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Curso:";
            // 
            // lbTitu
            // 
            this.lbTitu.AutoSize = true;
            this.lbTitu.Location = new System.Drawing.Point(544, 346);
            this.lbTitu.Name = "lbTitu";
            this.lbTitu.Size = new System.Drawing.Size(59, 13);
            this.lbTitu.TabIndex = 16;
            this.lbTitu.Text = "Informatica";
            this.lbTitu.Click += new System.EventHandler(this.lbTitu_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(451, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Titulación";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(547, 141);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(188, 20);
            this.tbName.TabIndex = 17;
            this.tbName.Visible = false;
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(547, 193);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(131, 20);
            this.tbEmail.TabIndex = 18;
            this.tbEmail.Visible = false;
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(547, 269);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(131, 20);
            this.tbDni.TabIndex = 20;
            this.tbDni.Visible = false;
            this.tbDni.Validated += new System.EventHandler(this.tbDni_Validated);
            // 
            // tbCurso
            // 
            this.tbCurso.Location = new System.Drawing.Point(547, 307);
            this.tbCurso.Name = "tbCurso";
            this.tbCurso.Size = new System.Drawing.Size(131, 20);
            this.tbCurso.TabIndex = 21;
            this.tbCurso.Visible = false;
            this.tbCurso.Validated += new System.EventHandler(this.tbCurso_Validated);
            // 
            // tbTitu
            // 
            this.tbTitu.Location = new System.Drawing.Point(547, 343);
            this.tbTitu.Name = "tbTitu";
            this.tbTitu.Size = new System.Drawing.Size(131, 20);
            this.tbTitu.TabIndex = 22;
            this.tbTitu.Visible = false;
            this.tbTitu.Validated += new System.EventHandler(this.tbTitu_Validated);
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Items.AddRange(new object[] {
            "Cliente",
            "Administrador"});
            this.cbUser.Location = new System.Drawing.Point(547, 231);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(131, 21);
            this.cbUser.TabIndex = 23;
            this.cbUser.Visible = false;
            this.cbUser.Validated += new System.EventHandler(this.cbUser_Validated);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(671, 548);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 35);
            this.btCancel.TabIndex = 61;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(547, 548);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(105, 35);
            this.btConfirm.TabIndex = 60;
            this.btConfirm.Text = "Confirmar";
            this.btConfirm.UseVisualStyleBackColor = true;
            // 
            // AGestUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbTitu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btBuscarUSer);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btNewUser);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbUsers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.tbTitu);
            this.Controls.Add(this.tbCurso);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AGestUser";
            this.Text = "AGestUser";
            ((System.ComponentModel.ISupportInitialize)(this.tbUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView tbUsers;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btNewUser;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Button btBuscarUSer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTitu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbCurso;
        private System.Windows.Forms.TextBox tbTitu;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
    }
}