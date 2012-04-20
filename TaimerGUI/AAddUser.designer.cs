namespace TaimerGUI {
    partial class AAddUser {
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.lbErrName = new System.Windows.Forms.Label();
            this.lbErrEmailBad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTitu = new System.Windows.Forms.TextBox();
            this.lbErrTitu = new System.Windows.Forms.Label();
            this.lbErrEmail = new System.Windows.Forms.Label();
            this.lbErrDni = new System.Windows.Forms.Label();
            this.udCurso = new System.Windows.Forms.NumericUpDown();
            this.lbErrDniBad = new System.Windows.Forms.Label();
            this.lbErrPass = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nombre";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(44, 136);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(324, 20);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 50;
            this.label1.Text = "Crear Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "DNI";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(44, 213);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(174, 20);
            this.tbDni.TabIndex = 2;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(678, 548);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 35);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(554, 548);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(105, 35);
            this.btCreate.TabIndex = 7;
            this.btCreate.Text = "Crear";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // lbErrName
            // 
            this.lbErrName.AutoSize = true;
            this.lbErrName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrName.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrName.Location = new System.Drawing.Point(374, 140);
            this.lbErrName.Name = "lbErrName";
            this.lbErrName.Size = new System.Drawing.Size(145, 13);
            this.lbErrName.TabIndex = 62;
            this.lbErrName.Text = "El campo no puede estar vacio";
            this.lbErrName.Visible = false;
            // 
            // lbErrEmailBad
            // 
            this.lbErrEmailBad.AutoSize = true;
            this.lbErrEmailBad.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrEmailBad.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrEmailBad.Location = new System.Drawing.Point(224, 299);
            this.lbErrEmailBad.Name = "lbErrEmailBad";
            this.lbErrEmailBad.Size = new System.Drawing.Size(168, 13);
            this.lbErrEmailBad.TabIndex = 65;
            this.lbErrEmailBad.Text = "El email introducido no es correcto";
            this.lbErrEmailBad.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Correo Electronico";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(44, 295);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(174, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Curso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "Titulación";
            // 
            // tbTitu
            // 
            this.tbTitu.Location = new System.Drawing.Point(170, 446);
            this.tbTitu.Name = "tbTitu";
            this.tbTitu.Size = new System.Drawing.Size(174, 20);
            this.tbTitu.TabIndex = 6;
            // 
            // lbErrTitu
            // 
            this.lbErrTitu.AutoSize = true;
            this.lbErrTitu.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrTitu.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrTitu.Location = new System.Drawing.Point(350, 450);
            this.lbErrTitu.Name = "lbErrTitu";
            this.lbErrTitu.Size = new System.Drawing.Size(145, 13);
            this.lbErrTitu.TabIndex = 74;
            this.lbErrTitu.Text = "El campo no puede estar vacio";
            this.lbErrTitu.Visible = false;
            // 
            // lbErrEmail
            // 
            this.lbErrEmail.AutoSize = true;
            this.lbErrEmail.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrEmail.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrEmail.Location = new System.Drawing.Point(224, 299);
            this.lbErrEmail.Name = "lbErrEmail";
            this.lbErrEmail.Size = new System.Drawing.Size(145, 13);
            this.lbErrEmail.TabIndex = 76;
            this.lbErrEmail.Text = "El campo no puede estar vacio";
            this.lbErrEmail.Visible = false;
            // 
            // lbErrDni
            // 
            this.lbErrDni.AutoSize = true;
            this.lbErrDni.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrDni.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrDni.Location = new System.Drawing.Point(223, 217);
            this.lbErrDni.Name = "lbErrDni";
            this.lbErrDni.Size = new System.Drawing.Size(145, 13);
            this.lbErrDni.TabIndex = 77;
            this.lbErrDni.Text = "El campo no puede estar vacio";
            this.lbErrDni.Visible = false;
            // 
            // udCurso
            // 
            this.udCurso.Location = new System.Drawing.Point(44, 447);
            this.udCurso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCurso.Name = "udCurso";
            this.udCurso.Size = new System.Drawing.Size(120, 20);
            this.udCurso.TabIndex = 5;
            this.udCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udCurso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbErrDniBad
            // 
            this.lbErrDniBad.AutoSize = true;
            this.lbErrDniBad.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrDniBad.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrDniBad.Location = new System.Drawing.Point(224, 217);
            this.lbErrDniBad.Name = "lbErrDniBad";
            this.lbErrDniBad.Size = new System.Drawing.Size(159, 13);
            this.lbErrDniBad.TabIndex = 79;
            this.lbErrDniBad.Text = "El DNI introducido no es correcto";
            this.lbErrDniBad.Visible = false;
            // 
            // lbErrPass
            // 
            this.lbErrPass.AutoSize = true;
            this.lbErrPass.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrPass.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrPass.Location = new System.Drawing.Point(224, 373);
            this.lbErrPass.Name = "lbErrPass";
            this.lbErrPass.Size = new System.Drawing.Size(145, 13);
            this.lbErrPass.TabIndex = 82;
            this.lbErrPass.Text = "El campo no puede estar vacio";
            this.lbErrPass.Visible = false;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(41, 341);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(61, 13);
            this.lbPass.TabIndex = 81;
            this.lbPass.Text = "Contraseña";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(44, 369);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(174, 20);
            this.tbPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(106, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 14);
            this.label3.TabIndex = 83;
            this.label3.Text = "Creación de un usuario nuevo";
            // 
            // AAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbErrPass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lbErrDniBad);
            this.Controls.Add(this.udCurso);
            this.Controls.Add(this.lbErrDni);
            this.Controls.Add(this.lbErrEmail);
            this.Controls.Add(this.lbErrTitu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbTitu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbErrEmailBad);
            this.Controls.Add(this.lbErrName);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AAddUser";
            this.Text = "AAddUser";
            ((System.ComponentModel.ISupportInitialize)(this.udCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Label lbErrName;
        private System.Windows.Forms.Label lbErrEmailBad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTitu;
        private System.Windows.Forms.Label lbErrTitu;
        private System.Windows.Forms.Label lbErrEmail;
        private System.Windows.Forms.Label lbErrDni;
        private System.Windows.Forms.NumericUpDown udCurso;
        private System.Windows.Forms.Label lbErrDniBad;
        private System.Windows.Forms.Label lbErrPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label3;
    }
}