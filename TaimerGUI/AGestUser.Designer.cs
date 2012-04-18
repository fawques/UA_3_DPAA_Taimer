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
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btNewUser = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCurso = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTitu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTitu = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbErrEmail = new System.Windows.Forms.Label();
            this.lbErrEmailBad = new System.Windows.Forms.Label();
            this.lbErrName = new System.Windows.Forms.Label();
            this.lbErrTitulacion = new System.Windows.Forms.Label();
            this.udCurso = new System.Windows.Forms.NumericUpDown();
            this.lbErrPass = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToOrderColumns = true;
            this.dgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsers.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Dni,
            this.Eliminar});
            this.dgUsers.Location = new System.Drawing.Point(93, 132);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.Size = new System.Drawing.Size(303, 334);
            this.dgUsers.TabIndex = 2;
            this.dgUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsers_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(542, 132);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(136, 29);
            this.lbUserName.TabIndex = 4;
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
            this.label1.Location = new System.Drawing.Point(407, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Correo Electronico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DNI:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(544, 207);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(89, 13);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "lalala@lalala.com";
            this.lbEmail.Click += new System.EventHandler(this.lbEmail_Click);
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(544, 321);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(62, 13);
            this.lbDni.TabIndex = 10;
            this.lbDni.Text = "11111111X";
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
            this.lbCurso.Location = new System.Drawing.Point(544, 375);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(50, 13);
            this.lbCurso.TabIndex = 7;
            this.lbCurso.Text = "Segundo";
            this.lbCurso.Click += new System.EventHandler(this.lbCurso_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(468, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Curso:";
            // 
            // lbTitu
            // 
            this.lbTitu.AutoSize = true;
            this.lbTitu.Location = new System.Drawing.Point(544, 427);
            this.lbTitu.Name = "lbTitu";
            this.lbTitu.Size = new System.Drawing.Size(59, 13);
            this.lbTitu.TabIndex = 8;
            this.lbTitu.Text = "Informatica";
            this.lbTitu.Click += new System.EventHandler(this.lbTitu_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(451, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Titulación:";
            // 
            // tbName
            // 
            this.tbName.AcceptsReturn = true;
            this.tbName.AcceptsTab = true;
            this.tbName.Location = new System.Drawing.Point(547, 141);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(188, 20);
            this.tbName.TabIndex = 4;
            this.tbName.Visible = false;
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(547, 204);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(131, 20);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.Visible = false;
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // tbTitu
            // 
            this.tbTitu.Location = new System.Drawing.Point(547, 424);
            this.tbTitu.Name = "tbTitu";
            this.tbTitu.Size = new System.Drawing.Size(131, 20);
            this.tbTitu.TabIndex = 8;
            this.tbTitu.Visible = false;
            this.tbTitu.Validated += new System.EventHandler(this.tbTitu_Validated);
            // 
            // btCancel
            // 
            this.btCancel.Enabled = false;
            this.btCancel.Location = new System.Drawing.Point(646, 548);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(137, 35);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Descartar Cambios";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Enabled = false;
            this.btConfirm.Location = new System.Drawing.Point(496, 548);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(137, 35);
            this.btConfirm.TabIndex = 9;
            this.btConfirm.Text = "Confirmar Cambios";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Filtrar";
            // 
            // lbErrEmail
            // 
            this.lbErrEmail.AutoSize = true;
            this.lbErrEmail.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrEmail.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrEmail.Location = new System.Drawing.Point(544, 227);
            this.lbErrEmail.Name = "lbErrEmail";
            this.lbErrEmail.Size = new System.Drawing.Size(145, 13);
            this.lbErrEmail.TabIndex = 78;
            this.lbErrEmail.Text = "El campo no puede estar vacio";
            this.lbErrEmail.Visible = false;
            // 
            // lbErrEmailBad
            // 
            this.lbErrEmailBad.AutoSize = true;
            this.lbErrEmailBad.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrEmailBad.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrEmailBad.Location = new System.Drawing.Point(544, 227);
            this.lbErrEmailBad.Name = "lbErrEmailBad";
            this.lbErrEmailBad.Size = new System.Drawing.Size(168, 13);
            this.lbErrEmailBad.TabIndex = 77;
            this.lbErrEmailBad.Text = "El email introducido no es correcto";
            this.lbErrEmailBad.Visible = false;
            // 
            // lbErrName
            // 
            this.lbErrName.AutoSize = true;
            this.lbErrName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrName.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrName.Location = new System.Drawing.Point(544, 164);
            this.lbErrName.Name = "lbErrName";
            this.lbErrName.Size = new System.Drawing.Size(145, 13);
            this.lbErrName.TabIndex = 79;
            this.lbErrName.Text = "El campo no puede estar vacio";
            this.lbErrName.Visible = false;
            // 
            // lbErrTitulacion
            // 
            this.lbErrTitulacion.AutoSize = true;
            this.lbErrTitulacion.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrTitulacion.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrTitulacion.Location = new System.Drawing.Point(544, 447);
            this.lbErrTitulacion.Name = "lbErrTitulacion";
            this.lbErrTitulacion.Size = new System.Drawing.Size(145, 13);
            this.lbErrTitulacion.TabIndex = 82;
            this.lbErrTitulacion.Text = "El campo no puede estar vacio";
            this.lbErrTitulacion.Visible = false;
            // 
            // udCurso
            // 
            this.udCurso.Location = new System.Drawing.Point(547, 373);
            this.udCurso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCurso.Name = "udCurso";
            this.udCurso.Size = new System.Drawing.Size(120, 20);
            this.udCurso.TabIndex = 7;
            this.udCurso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCurso.Visible = false;
            this.udCurso.Validated += new System.EventHandler(this.tbCurso_Validated);
            // 
            // lbErrPass
            // 
            this.lbErrPass.AutoSize = true;
            this.lbErrPass.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrPass.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrPass.Location = new System.Drawing.Point(544, 283);
            this.lbErrPass.Name = "lbErrPass";
            this.lbErrPass.Size = new System.Drawing.Size(145, 13);
            this.lbErrPass.TabIndex = 88;
            this.lbErrPass.Text = "El campo no puede estar vacio";
            this.lbErrPass.Visible = false;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(544, 263);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(37, 13);
            this.lbPass.TabIndex = 6;
            this.lbPass.Text = "patata";
            this.lbPass.Click += new System.EventHandler(this.lbPass_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Contraseña:";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(547, 260);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(131, 20);
            this.tbPass.TabIndex = 6;
            this.tbPass.Visible = false;
            this.tbPass.Validated += new System.EventHandler(this.tbPass_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Modificar datos de usuarios, así como la creación de usuarios nuevos";
            // 
            // AGestUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbErrPass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lbErrTitulacion);
            this.Controls.Add(this.lbErrName);
            this.Controls.Add(this.lbErrEmail);
            this.Controls.Add(this.lbErrEmailBad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbTitu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btNewUser);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.dgUsers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbTitu);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.udCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AGestUser";
            this.Text = "AGestUser";
            this.Load += new System.EventHandler(this.AGestUser_Load);
            this.Enter += new System.EventHandler(this.AGestUser_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btNewUser;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTitu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTitu;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbErrEmail;
        private System.Windows.Forms.Label lbErrEmailBad;
        private System.Windows.Forms.Label lbErrName;
        private System.Windows.Forms.Label lbErrTitulacion;
        private System.Windows.Forms.NumericUpDown udCurso;
        private System.Windows.Forms.Label lbErrPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label4;
    }
}