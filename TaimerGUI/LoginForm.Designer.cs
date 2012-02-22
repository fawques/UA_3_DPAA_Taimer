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
            this.label1 = new System.Windows.Forms.Label();
            this.pnSystemButtons = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLoginUser = new System.Windows.Forms.TextBox();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.pnLogo.SuspendLayout();
            this.pnSystemButtons.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnLogo.Size = new System.Drawing.Size(500, 100);
            this.pnLogo.TabIndex = 0;
            this.pnLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pnLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pnLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taimer";
            // 
            // pnSystemButtons
            // 
            this.pnSystemButtons.Controls.Add(this.btMinimize);
            this.pnSystemButtons.Controls.Add(this.btClose);
            this.pnSystemButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSystemButtons.Location = new System.Drawing.Point(425, 0);
            this.pnSystemButtons.Name = "pnSystemButtons";
            this.pnSystemButtons.Size = new System.Drawing.Size(75, 100);
            this.pnSystemButtons.TabIndex = 8;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(44, 3);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(31, 27);
            this.btClose.TabIndex = 7;
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
            this.btMinimize.Location = new System.Drawing.Point(22, 0);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(31, 27);
            this.btMinimize.TabIndex = 8;
            this.btMinimize.Text = "__";
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbLoginPassword);
            this.panel1.Controls.Add(this.tbLoginUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(75, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 154);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(200, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // tbLoginUser
            // 
            this.tbLoginUser.Location = new System.Drawing.Point(147, 40);
            this.tbLoginUser.Name = "tbLoginUser";
            this.tbLoginUser.Size = new System.Drawing.Size(111, 23);
            this.tbLoginUser.TabIndex = 3;
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(147, 71);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.Size = new System.Drawing.Size(111, 23);
            this.tbLoginPassword.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnLogo);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.Text = "Taimer Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.pnSystemButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnSystemButtons;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.TextBox tbLoginUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

