namespace TaimerGUI {
    partial class AGestTurno {
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
            this.btBuscarUSer = new System.Windows.Forms.Button();
            this.lbHoraIni = new System.Windows.Forms.Label();
            this.lbDia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btNewUser = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbHoraFin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.tbUbi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbUbi = new System.Windows.Forms.Label();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.udHoraIni = new System.Windows.Forms.NumericUpDown();
            this.udMinIni = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinIni)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscarUSer
            // 
            this.btBuscarUSer.Location = new System.Drawing.Point(318, 103);
            this.btBuscarUSer.Name = "btBuscarUSer";
            this.btBuscarUSer.Size = new System.Drawing.Size(75, 20);
            this.btBuscarUSer.TabIndex = 35;
            this.btBuscarUSer.Text = "Buscar";
            this.btBuscarUSer.UseVisualStyleBackColor = true;
            // 
            // lbHoraIni
            // 
            this.lbHoraIni.AutoSize = true;
            this.lbHoraIni.Location = new System.Drawing.Point(515, 233);
            this.lbHoraIni.Name = "lbHoraIni";
            this.lbHoraIni.Size = new System.Drawing.Size(34, 13);
            this.lbHoraIni.TabIndex = 34;
            this.lbHoraIni.Text = "13:00";
            this.lbHoraIni.Click += new System.EventHandler(this.lbHoraIni_Click);
            // 
            // lbDia
            // 
            this.lbDia.AutoSize = true;
            this.lbDia.Location = new System.Drawing.Point(515, 195);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(36, 13);
            this.lbDia.TabIndex = 33;
            this.lbDia.Text = "Lunes";
            this.lbDia.Click += new System.EventHandler(this.lbDia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Hora de Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Hora Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Día:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(438, 145);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 13);
            this.lbName.TabIndex = 29;
            this.lbName.Text = "Asignatura:";
            // 
            // btNewUser
            // 
            this.btNewUser.Location = new System.Drawing.Point(286, 481);
            this.btNewUser.Name = "btNewUser";
            this.btNewUser.Size = new System.Drawing.Size(107, 24);
            this.btNewUser.TabIndex = 28;
            this.btNewUser.Text = "Nuevo Turno";
            this.btNewUser.UseVisualStyleBackColor = true;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(512, 129);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(136, 29);
            this.lbUserName.TabIndex = 27;
            this.lbUserName.Text = "DPAA Teoria";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 25;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(93, 129);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(300, 346);
            this.dataGridView2.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Día";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 30;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora Inicio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora Fin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // lbHoraFin
            // 
            this.lbHoraFin.AutoSize = true;
            this.lbHoraFin.Location = new System.Drawing.Point(515, 270);
            this.lbHoraFin.Name = "lbHoraFin";
            this.lbHoraFin.Size = new System.Drawing.Size(34, 13);
            this.lbHoraFin.TabIndex = 39;
            this.lbHoraFin.Text = "15:00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 39);
            this.label9.TabIndex = 41;
            this.label9.Text = "Gestionar Turnos";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(667, 515);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 35);
            this.btCancel.TabIndex = 43;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(543, 515);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(105, 35);
            this.btConfirm.TabIndex = 42;
            this.btConfirm.Text = "Confirmar";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // tbUbi
            // 
            this.tbUbi.Location = new System.Drawing.Point(514, 303);
            this.tbUbi.Name = "tbUbi";
            this.tbUbi.Size = new System.Drawing.Size(258, 20);
            this.tbUbi.TabIndex = 47;
            this.tbUbi.Visible = false;
            this.tbUbi.Validated += new System.EventHandler(this.tbUbi_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ubicación:";
            // 
            // lbUbi
            // 
            this.lbUbi.AutoSize = true;
            this.lbUbi.Location = new System.Drawing.Point(515, 306);
            this.lbUbi.Name = "lbUbi";
            this.lbUbi.Size = new System.Drawing.Size(67, 13);
            this.lbUbi.TabIndex = 40;
            this.lbUbi.Text = "Pepito Perez";
            this.lbUbi.Click += new System.EventHandler(this.lbUbi_Click);
            // 
            // cbDia
            // 
            this.cbDia.DisplayMember = "Lunes";
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cbDia.Location = new System.Drawing.Point(514, 191);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(121, 21);
            this.cbDia.TabIndex = 48;
            this.cbDia.Text = "Lunes";
            this.cbDia.Visible = false;
            this.cbDia.Validated += new System.EventHandler(this.cbDia_Validated);
            // 
            // udHoraIni
            // 
            this.udHoraIni.Location = new System.Drawing.Point(514, 230);
            this.udHoraIni.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.udHoraIni.Name = "udHoraIni";
            this.udHoraIni.Size = new System.Drawing.Size(37, 20);
            this.udHoraIni.TabIndex = 49;
            this.udHoraIni.Visible = false;
            this.udHoraIni.Validated += new System.EventHandler(this.udHoraIni_Validated);
            // 
            // udMinIni
            // 
            this.udMinIni.Location = new System.Drawing.Point(557, 230);
            this.udMinIni.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.udMinIni.Name = "udMinIni";
            this.udMinIni.Size = new System.Drawing.Size(37, 20);
            this.udMinIni.TabIndex = 50;
            this.udMinIni.Visible = false;
            this.udMinIni.Validated += new System.EventHandler(this.udMinIni_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "13:00";
            // 
            // AGestTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbUbi);
            this.Controls.Add(this.lbHoraFin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btBuscarUSer);
            this.Controls.Add(this.lbHoraIni);
            this.Controls.Add(this.lbDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btNewUser);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbUbi);
            this.Controls.Add(this.cbDia);
            this.Controls.Add(this.udMinIni);
            this.Controls.Add(this.udHoraIni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AGestTurno";
            this.Text = "AGestTurno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinIni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscarUSer;
        private System.Windows.Forms.Label lbHoraIni;
        private System.Windows.Forms.Label lbDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btNewUser;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lbHoraFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.TextBox tbUbi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbUbi;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.NumericUpDown udHoraIni;
        private System.Windows.Forms.NumericUpDown udMinIni;
        private System.Windows.Forms.Label label4;

    }
}