namespace TaimerGUI {
    partial class AModiTurn {
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
            this.lbHoraIni = new System.Windows.Forms.Label();
            this.lbDia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
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
            this.udMinFin = new System.Windows.Forms.NumericUpDown();
            this.udHoraFin = new System.Windows.Forms.NumericUpDown();
            this.lbErrUbi = new System.Windows.Forms.Label();
            this.lbErrHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraFin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHoraIni
            // 
            this.lbHoraIni.AutoSize = true;
            this.lbHoraIni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbHoraIni.Location = new System.Drawing.Point(126, 270);
            this.lbHoraIni.Name = "lbHoraIni";
            this.lbHoraIni.Size = new System.Drawing.Size(34, 13);
            this.lbHoraIni.TabIndex = 34;
            this.lbHoraIni.Text = "13:00";
            this.lbHoraIni.Click += new System.EventHandler(this.lbHoraIni_Click);
            // 
            // lbDia
            // 
            this.lbDia.AutoSize = true;
            this.lbDia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbDia.Location = new System.Drawing.Point(126, 220);
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
            this.label3.Location = new System.Drawing.Point(46, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Hora de Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Hora Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Día:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(49, 144);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 13);
            this.lbName.TabIndex = 29;
            this.lbName.Text = "Asignatura:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(123, 128);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(136, 29);
            this.lbUserName.TabIndex = 27;
            this.lbUserName.Text = "DPAA Teoria";
            // 
            // lbHoraFin
            // 
            this.lbHoraFin.AutoSize = true;
            this.lbHoraFin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbHoraFin.Location = new System.Drawing.Point(126, 318);
            this.lbHoraFin.Name = "lbHoraFin";
            this.lbHoraFin.Size = new System.Drawing.Size(34, 13);
            this.lbHoraFin.TabIndex = 39;
            this.lbHoraFin.Text = "15:00";
            this.lbHoraFin.Click += new System.EventHandler(this.lbHoraFin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 39);
            this.label9.TabIndex = 41;
            this.label9.Text = "Modificar Turno";
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
            this.tbUbi.Location = new System.Drawing.Point(125, 369);
            this.tbUbi.Name = "tbUbi";
            this.tbUbi.Size = new System.Drawing.Size(258, 20);
            this.tbUbi.TabIndex = 47;
            this.tbUbi.Visible = false;
            this.tbUbi.Leave += new System.EventHandler(this.tbUbi_Validated);
            this.tbUbi.Validated += new System.EventHandler(this.tbUbi_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ubicación:";
            // 
            // lbUbi
            // 
            this.lbUbi.AutoSize = true;
            this.lbUbi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbUbi.Location = new System.Drawing.Point(126, 372);
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
            this.cbDia.Location = new System.Drawing.Point(125, 216);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(121, 21);
            this.cbDia.TabIndex = 48;
            this.cbDia.Text = "Lunes";
            this.cbDia.Visible = false;
            this.cbDia.Leave += new System.EventHandler(this.cbDia_Validated);
            this.cbDia.Validated += new System.EventHandler(this.cbDia_Validated);
            // 
            // udHoraIni
            // 
            this.udHoraIni.Location = new System.Drawing.Point(125, 267);
            this.udHoraIni.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.udHoraIni.Name = "udHoraIni";
            this.udHoraIni.Size = new System.Drawing.Size(37, 20);
            this.udHoraIni.TabIndex = 49;
            this.udHoraIni.Visible = false;
            this.udHoraIni.Leave += new System.EventHandler(this.udHoraIni_Validated);
            this.udHoraIni.Validated += new System.EventHandler(this.udHoraIni_Validated);
            // 
            // udMinIni
            // 
            this.udMinIni.Location = new System.Drawing.Point(168, 267);
            this.udMinIni.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.udMinIni.Name = "udMinIni";
            this.udMinIni.Size = new System.Drawing.Size(37, 20);
            this.udMinIni.TabIndex = 50;
            this.udMinIni.Visible = false;
            this.udMinIni.Leave += new System.EventHandler(this.udMinIni_Validated);
            this.udMinIni.Validated += new System.EventHandler(this.udMinIni_Validated);
            // 
            // udMinFin
            // 
            this.udMinFin.Location = new System.Drawing.Point(168, 315);
            this.udMinFin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.udMinFin.Name = "udMinFin";
            this.udMinFin.Size = new System.Drawing.Size(37, 20);
            this.udMinFin.TabIndex = 52;
            this.udMinFin.Visible = false;
            this.udMinFin.Leave += new System.EventHandler(this.udMinFin_Validated);
            this.udMinFin.Validated += new System.EventHandler(this.udMinFin_Validated);
            // 
            // udHoraFin
            // 
            this.udHoraFin.Location = new System.Drawing.Point(125, 315);
            this.udHoraFin.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.udHoraFin.Name = "udHoraFin";
            this.udHoraFin.Size = new System.Drawing.Size(37, 20);
            this.udHoraFin.TabIndex = 51;
            this.udHoraFin.Visible = false;
            this.udHoraFin.Leave += new System.EventHandler(this.udHoraFin_Validated);
            this.udHoraFin.Validated += new System.EventHandler(this.udHoraFin_Validated);
            // 
            // lbErrUbi
            // 
            this.lbErrUbi.AutoSize = true;
            this.lbErrUbi.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrUbi.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrUbi.Location = new System.Drawing.Point(389, 376);
            this.lbErrUbi.Name = "lbErrUbi";
            this.lbErrUbi.Size = new System.Drawing.Size(145, 13);
            this.lbErrUbi.TabIndex = 65;
            this.lbErrUbi.Text = "El campo no puede estar vacio";
            this.lbErrUbi.Visible = false;
            // 
            // lbErrHora
            // 
            this.lbErrHora.AutoSize = true;
            this.lbErrHora.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrHora.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrHora.Location = new System.Drawing.Point(211, 322);
            this.lbErrHora.Name = "lbErrHora";
            this.lbErrHora.Size = new System.Drawing.Size(229, 13);
            this.lbErrHora.TabIndex = 67;
            this.lbErrHora.Text = "La hora de fin no puede ser anterior a la de inicio";
            this.lbErrHora.Visible = false;
            // 
            // AModiTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
            this.Controls.Add(this.lbErrHora);
            this.Controls.Add(this.lbErrUbi);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbUbi);
            this.Controls.Add(this.lbHoraFin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbHoraIni);
            this.Controls.Add(this.lbDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbUbi);
            this.Controls.Add(this.cbDia);
            this.Controls.Add(this.udMinIni);
            this.Controls.Add(this.udHoraIni);
            this.Controls.Add(this.udMinFin);
            this.Controls.Add(this.udHoraFin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AModiTurn";
            this.Text = "AGestTurno";
            ((System.ComponentModel.ISupportInitialize)(this.udHoraIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraFin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHoraIni;
        private System.Windows.Forms.Label lbDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUserName;
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
        private System.Windows.Forms.NumericUpDown udMinFin;
        private System.Windows.Forms.NumericUpDown udHoraFin;
        private System.Windows.Forms.Label lbErrUbi;
        private System.Windows.Forms.Label lbErrHora;

    }
}