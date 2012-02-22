namespace TaimerGUI {
    partial class LoginForm {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pnSystemButtons = new System.Windows.Forms.Panel();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLoginContents = new System.Windows.Forms.Panel();
            this.llIrAWeb = new System.Windows.Forms.LinkLabel();
            this.llRecordarDatos = new System.Windows.Forms.LinkLabel();
            this.cbLoginRemeberData = new System.Windows.Forms.CheckBox();
            this.lbLoginBadUserPass = new System.Windows.Forms.Label();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.tbLoginUser = new System.Windows.Forms.TextBox();
            this.lbLoginPassword = new System.Windows.Forms.Label();
            this.lbLoginUser = new System.Windows.Forms.Label();
            this.btLoginEntrar = new System.Windows.Forms.Button();
            this.pnLogo.SuspendLayout();
            this.pnSystemButtons.SuspendLayout();
            this.pnLoginContents.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnLogo.Controls.Add(this.pnSystemButtons);
            this.pnLogo.Controls.Add(this.label1);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(500, 119);
            this.pnLogo.TabIndex = 0;
            this.pnLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pnLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pnLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pnSystemButtons
            // 
            this.pnSystemButtons.Controls.Add(this.btMinimize);
            this.pnSystemButtons.Controls.Add(this.btClose);
            this.pnSystemButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSystemButtons.Location = new System.Drawing.Point(425, 0);
            this.pnSystemButtons.Name = "pnSystemButtons";
            this.pnSystemButtons.Size = new System.Drawing.Size(75, 119);
            this.pnSystemButtons.TabIndex = 8;
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
            this.btMinimize.Location = new System.Drawing.Point(22, 0);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(31, 27);
            this.btMinimize.TabIndex = 7;
            this.btMinimize.Text = "__";
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            this.btMinimize.MouseEnter += new System.EventHandler(this.btMinimize_MouseEnter);
            this.btMinimize.MouseLeave += new System.EventHandler(this.btMinimize_MouseLeave);
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
            this.btClose.Location = new System.Drawing.Point(44, 3);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(31, 27);
            this.btClose.TabIndex = 8;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseEnter += new System.EventHandler(this.btClose_MouseEnter);
            this.btClose.MouseLeave += new System.EventHandler(this.btClose_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taimer";
            // 
            // pnLoginContents
            // 
            this.pnLoginContents.BackColor = System.Drawing.Color.Transparent;
            this.pnLoginContents.Controls.Add(this.llIrAWeb);
            this.pnLoginContents.Controls.Add(this.llRecordarDatos);
            this.pnLoginContents.Controls.Add(this.cbLoginRemeberData);
            this.pnLoginContents.Controls.Add(this.lbLoginBadUserPass);
            this.pnLoginContents.Controls.Add(this.tbLoginPassword);
            this.pnLoginContents.Controls.Add(this.tbLoginUser);
            this.pnLoginContents.Controls.Add(this.lbLoginPassword);
            this.pnLoginContents.Controls.Add(this.lbLoginUser);
            this.pnLoginContents.Controls.Add(this.btLoginEntrar);
            this.pnLoginContents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLoginContents.Location = new System.Drawing.Point(0, 106);
            this.pnLoginContents.Name = "pnLoginContents";
            this.pnLoginContents.Size = new System.Drawing.Size(500, 194);
            this.pnLoginContents.TabIndex = 1;
            // 
            // llIrAWeb
            // 
            this.llIrAWeb.AutoSize = true;
            this.llIrAWeb.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llIrAWeb.LinkColor = System.Drawing.Color.Maroon;
            this.llIrAWeb.Location = new System.Drawing.Point(276, 157);
            this.llIrAWeb.Name = "llIrAWeb";
            this.llIrAWeb.Size = new System.Drawing.Size(55, 13);
            this.llIrAWeb.TabIndex = 6;
            this.llIrAWeb.TabStop = true;
            this.llIrAWeb.Text = "Ir a la web";
            // 
            // llRecordarDatos
            // 
            this.llRecordarDatos.AutoSize = true;
            this.llRecordarDatos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRecordarDatos.LinkColor = System.Drawing.Color.Maroon;
            this.llRecordarDatos.Location = new System.Drawing.Point(218, 144);
            this.llRecordarDatos.Name = "llRecordarDatos";
            this.llRecordarDatos.Size = new System.Drawing.Size(113, 13);
            this.llRecordarDatos.TabIndex = 5;
            this.llRecordarDatos.TabStop = true;
            this.llRecordarDatos.Text = "No recuerdo mis datos";
            // 
            // cbLoginRemeberData
            // 
            this.cbLoginRemeberData.AutoSize = true;
            this.cbLoginRemeberData.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoginRemeberData.ForeColor = System.Drawing.Color.Maroon;
            this.cbLoginRemeberData.Location = new System.Drawing.Point(148, 83);
            this.cbLoginRemeberData.Name = "cbLoginRemeberData";
            this.cbLoginRemeberData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbLoginRemeberData.Size = new System.Drawing.Size(86, 17);
            this.cbLoginRemeberData.TabIndex = 3;
            this.cbLoginRemeberData.Text = "Recuerdame";
            this.cbLoginRemeberData.UseVisualStyleBackColor = true;
            // 
            // lbLoginBadUserPass
            // 
            this.lbLoginBadUserPass.AutoSize = true;
            this.lbLoginBadUserPass.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginBadUserPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLoginBadUserPass.Location = new System.Drawing.Point(119, 103);
            this.lbLoginBadUserPass.Name = "lbLoginBadUserPass";
            this.lbLoginBadUserPass.Size = new System.Drawing.Size(260, 13);
            this.lbLoginBadUserPass.TabIndex = 5;
            this.lbLoginBadUserPass.Text = "La combinacion de usuario y contraseña es incorrecta";
            this.lbLoginBadUserPass.Visible = false;
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.AcceptsReturn = true;
            this.tbLoginPassword.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginPassword.Location = new System.Drawing.Point(220, 50);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(111, 21);
            this.tbLoginPassword.TabIndex = 2;
            // 
            // tbLoginUser
            // 
            this.tbLoginUser.AcceptsTab = true;
            this.tbLoginUser.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginUser.Location = new System.Drawing.Point(220, 19);
            this.tbLoginUser.Name = "tbLoginUser";
            this.tbLoginUser.Size = new System.Drawing.Size(111, 21);
            this.tbLoginUser.TabIndex = 1;
            // 
            // lbLoginPassword
            // 
            this.lbLoginPassword.AutoSize = true;
            this.lbLoginPassword.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginPassword.ForeColor = System.Drawing.Color.Maroon;
            this.lbLoginPassword.Location = new System.Drawing.Point(152, 55);
            this.lbLoginPassword.Name = "lbLoginPassword";
            this.lbLoginPassword.Size = new System.Drawing.Size(62, 13);
            this.lbLoginPassword.TabIndex = 2;
            this.lbLoginPassword.Text = "Contraseña";
            // 
            // lbLoginUser
            // 
            this.lbLoginUser.AutoSize = true;
            this.lbLoginUser.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginUser.ForeColor = System.Drawing.Color.Maroon;
            this.lbLoginUser.Location = new System.Drawing.Point(170, 24);
            this.lbLoginUser.Name = "lbLoginUser";
            this.lbLoginUser.Size = new System.Drawing.Size(44, 13);
            this.lbLoginUser.TabIndex = 1;
            this.lbLoginUser.Text = "Usuario";
            // 
            // btLoginEntrar
            // 
            this.btLoginEntrar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoginEntrar.ForeColor = System.Drawing.Color.Maroon;
            this.btLoginEntrar.Location = new System.Drawing.Point(256, 79);
            this.btLoginEntrar.Name = "btLoginEntrar";
            this.btLoginEntrar.Size = new System.Drawing.Size(75, 23);
            this.btLoginEntrar.TabIndex = 4;
            this.btLoginEntrar.Text = "Entrar";
            this.btLoginEntrar.UseVisualStyleBackColor = true;
            this.btLoginEntrar.Click += new System.EventHandler(this.btLoginEntrar_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.pnLoginContents);
            this.Controls.Add(this.pnLogo);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taimer Login";
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.pnSystemButtons.ResumeLayout(false);
            this.pnLoginContents.ResumeLayout(false);
            this.pnLoginContents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnSystemButtons;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel pnLoginContents;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.TextBox tbLoginUser;
        private System.Windows.Forms.Label lbLoginPassword;
        private System.Windows.Forms.Label lbLoginUser;
        private System.Windows.Forms.Button btLoginEntrar;
        private System.Windows.Forms.Label lbLoginBadUserPass;
        private System.Windows.Forms.LinkLabel llIrAWeb;
        private System.Windows.Forms.LinkLabel llRecordarDatos;
        private System.Windows.Forms.CheckBox cbLoginRemeberData;
    }
}

