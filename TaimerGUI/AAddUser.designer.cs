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
            this.label3 = new System.Windows.Forms.Label();
            this.tbApell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbCli = new System.Windows.Forms.RadioButton();
            this.rbAdm = new System.Windows.Forms.RadioButton();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.lbErrName = new System.Windows.Forms.Label();
            this.lbErrApell = new System.Windows.Forms.Label();
            this.lbErrEmailEmpty = new System.Windows.Forms.Label();
            this.lbErrEmailBad = new System.Windows.Forms.Label();
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
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 51;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Apellidos";
            // 
            // tbApell
            // 
            this.tbApell.Location = new System.Drawing.Point(44, 202);
            this.tbApell.Name = "tbApell";
            this.tbApell.Size = new System.Drawing.Size(174, 20);
            this.tbApell.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Correo Electronico";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(44, 271);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(174, 20);
            this.tbEmail.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Tipo de Usuario";
            // 
            // rbCli
            // 
            this.rbCli.AutoSize = true;
            this.rbCli.Checked = true;
            this.rbCli.Location = new System.Drawing.Point(50, 341);
            this.rbCli.Name = "rbCli";
            this.rbCli.Size = new System.Drawing.Size(57, 17);
            this.rbCli.TabIndex = 58;
            this.rbCli.TabStop = true;
            this.rbCli.Text = "Cliente";
            this.rbCli.UseVisualStyleBackColor = true;
            // 
            // rbAdm
            // 
            this.rbAdm.AutoSize = true;
            this.rbAdm.Location = new System.Drawing.Point(50, 364);
            this.rbAdm.Name = "rbAdm";
            this.rbAdm.Size = new System.Drawing.Size(88, 17);
            this.rbAdm.TabIndex = 59;
            this.rbAdm.TabStop = true;
            this.rbAdm.Text = "Administrador";
            this.rbAdm.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(678, 548);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 35);
            this.btCancel.TabIndex = 61;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(554, 548);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(105, 35);
            this.btCreate.TabIndex = 60;
            this.btCreate.Text = "Crear";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // lbErrName
            // 
            this.lbErrName.AutoSize = true;
            this.lbErrName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrName.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrName.Location = new System.Drawing.Point(150, 139);
            this.lbErrName.Name = "lbErrName";
            this.lbErrName.Size = new System.Drawing.Size(145, 13);
            this.lbErrName.TabIndex = 62;
            this.lbErrName.Text = "El campo no puede estar vacio";
            this.lbErrName.Visible = false;
            // 
            // lbErrApell
            // 
            this.lbErrApell.AutoSize = true;
            this.lbErrApell.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrApell.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrApell.Location = new System.Drawing.Point(224, 206);
            this.lbErrApell.Name = "lbErrApell";
            this.lbErrApell.Size = new System.Drawing.Size(145, 13);
            this.lbErrApell.TabIndex = 63;
            this.lbErrApell.Text = "El campo no puede estar vacio";
            this.lbErrApell.Visible = false;
            // 
            // lbErrEmailEmpty
            // 
            this.lbErrEmailEmpty.AutoSize = true;
            this.lbErrEmailEmpty.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrEmailEmpty.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrEmailEmpty.Location = new System.Drawing.Point(224, 275);
            this.lbErrEmailEmpty.Name = "lbErrEmailEmpty";
            this.lbErrEmailEmpty.Size = new System.Drawing.Size(145, 13);
            this.lbErrEmailEmpty.TabIndex = 64;
            this.lbErrEmailEmpty.Text = "El campo no puede estar vacio";
            this.lbErrEmailEmpty.Visible = false;
            // 
            // lbErrEmailBad
            // 
            this.lbErrEmailBad.AutoSize = true;
            this.lbErrEmailBad.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrEmailBad.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrEmailBad.Location = new System.Drawing.Point(224, 278);
            this.lbErrEmailBad.Name = "lbErrEmailBad";
            this.lbErrEmailBad.Size = new System.Drawing.Size(168, 13);
            this.lbErrEmailBad.TabIndex = 65;
            this.lbErrEmailBad.Text = "El email introducido no es correcto";
            this.lbErrEmailBad.Visible = false;
            // 
            // AAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
            this.Controls.Add(this.lbErrEmailBad);
            this.Controls.Add(this.lbErrEmailEmpty);
            this.Controls.Add(this.lbErrApell);
            this.Controls.Add(this.lbErrName);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.rbAdm);
            this.Controls.Add(this.rbCli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbApell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AAddUser";
            this.Text = "AAddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbApell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbCli;
        private System.Windows.Forms.RadioButton rbAdm;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Label lbErrName;
        private System.Windows.Forms.Label lbErrApell;
        private System.Windows.Forms.Label lbErrEmailEmpty;
        private System.Windows.Forms.Label lbErrEmailBad;
    }
}