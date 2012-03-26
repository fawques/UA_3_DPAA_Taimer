namespace TaimerGUI {
    partial class ClientGestTurno {
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
            this.dgTurnos = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbErrUbi = new System.Windows.Forms.Label();
            this.tbUbi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbErrHora = new System.Windows.Forms.Label();
            this.udMinFin = new System.Windows.Forms.NumericUpDown();
            this.udHoraFin = new System.Windows.Forms.NumericUpDown();
            this.udMinIni = new System.Windows.Forms.NumericUpDown();
            this.udHoraIni = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTurnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMinFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraIni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTurnos
            // 
            this.dgTurnos.AllowUserToAddRows = false;
            this.dgTurnos.AllowUserToDeleteRows = false;
            this.dgTurnos.AllowUserToOrderColumns = true;
            this.dgTurnos.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.HoraInicio,
            this.HoraFin,
            this.Borrar,
            this.Modificar,
            this.Ubicacion});
            this.dgTurnos.Location = new System.Drawing.Point(340, 117);
            this.dgTurnos.Name = "dgTurnos";
            this.dgTurnos.ReadOnly = true;
            this.dgTurnos.Size = new System.Drawing.Size(403, 150);
            this.dgTurnos.TabIndex = 72;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Width = 60;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            this.HoraFin.Width = 60;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Width = 70;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Width = 70;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Visible = false;
            // 
            // lbErrUbi
            // 
            this.lbErrUbi.AutoSize = true;
            this.lbErrUbi.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrUbi.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrUbi.Location = new System.Drawing.Point(264, 87);
            this.lbErrUbi.Name = "lbErrUbi";
            this.lbErrUbi.Size = new System.Drawing.Size(145, 13);
            this.lbErrUbi.TabIndex = 71;
            this.lbErrUbi.Text = "El campo no puede estar vacio";
            this.lbErrUbi.Visible = false;
            // 
            // tbUbi
            // 
            this.tbUbi.Location = new System.Drawing.Point(69, 83);
            this.tbUbi.Name = "tbUbi";
            this.tbUbi.Size = new System.Drawing.Size(189, 20);
            this.tbUbi.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Ubicación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbErrHora);
            this.groupBox1.Controls.Add(this.udMinFin);
            this.groupBox1.Controls.Add(this.udHoraFin);
            this.groupBox1.Controls.Add(this.udMinIni);
            this.groupBox1.Controls.Add(this.udHoraIni);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDia);
            this.groupBox1.Location = new System.Drawing.Point(68, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 181);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hora y Dia";
            // 
            // lbErrHora
            // 
            this.lbErrHora.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrHora.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrHora.Location = new System.Drawing.Point(27, 144);
            this.lbErrHora.Name = "lbErrHora";
            this.lbErrHora.Size = new System.Drawing.Size(131, 34);
            this.lbErrHora.TabIndex = 66;
            this.lbErrHora.Text = "La hora de fin no puede ser menor que la de inicio";
            this.lbErrHora.Visible = false;
            // 
            // udMinFin
            // 
            this.udMinFin.Location = new System.Drawing.Point(131, 106);
            this.udMinFin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.udMinFin.Name = "udMinFin";
            this.udMinFin.Size = new System.Drawing.Size(39, 20);
            this.udMinFin.TabIndex = 13;
            // 
            // udHoraFin
            // 
            this.udHoraFin.Location = new System.Drawing.Point(62, 106);
            this.udHoraFin.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.udHoraFin.Name = "udHoraFin";
            this.udHoraFin.Size = new System.Drawing.Size(42, 20);
            this.udHoraFin.TabIndex = 12;
            // 
            // udMinIni
            // 
            this.udMinIni.Location = new System.Drawing.Point(131, 72);
            this.udMinIni.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.udMinIni.Name = "udMinIni";
            this.udMinIni.Size = new System.Drawing.Size(39, 20);
            this.udMinIni.TabIndex = 11;
            // 
            // udHoraIni
            // 
            this.udHoraIni.Location = new System.Drawing.Point(62, 72);
            this.udHoraIni.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.udHoraIni.Name = "udHoraIni";
            this.udHoraIni.Size = new System.Drawing.Size(42, 20);
            this.udHoraIni.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "De";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "El";
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
            this.cbDia.Location = new System.Drawing.Point(62, 32);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(121, 21);
            this.cbDia.TabIndex = 0;
            this.cbDia.Text = "Lunes";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(276, 149);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(43, 46);
            this.btAdd.TabIndex = 69;
            this.btAdd.Text = "Add =>";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 66;
            this.label1.Text = "Gestionar Turnos";
            // 
            // ClientGestTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 532);
            this.Controls.Add(this.dgTurnos);
            this.Controls.Add(this.lbErrUbi);
            this.Controls.Add(this.tbUbi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.Name = "ClientGestTurno";
            this.Text = "ClientGestTurno";
            ((System.ComponentModel.ISupportInitialize)(this.dgTurnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMinFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraIni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.Label lbErrUbi;
        private System.Windows.Forms.TextBox tbUbi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbErrHora;
        private System.Windows.Forms.NumericUpDown udMinFin;
        private System.Windows.Forms.NumericUpDown udHoraFin;
        private System.Windows.Forms.NumericUpDown udMinIni;
        private System.Windows.Forms.NumericUpDown udHoraIni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label1;
    }
}