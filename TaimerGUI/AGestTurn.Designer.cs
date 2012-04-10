namespace TaimerGUI {
    partial class AGestTurn {
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
            this.btCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btCreate = new System.Windows.Forms.Button();
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
            this.tbUbi = new System.Windows.Forms.TextBox();
            this.lbErrUbi = new System.Windows.Forms.Label();
            this.dgTurnos = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpBoxTurno = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBoxLugarMod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nUDMinFinMod = new System.Windows.Forms.NumericUpDown();
            this.nUDMinIniMod = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nUDHorFinMod = new System.Windows.Forms.NumericUpDown();
            this.nUDHorIniMod = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbBoxDiaMod = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMinFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTurnos)).BeginInit();
            this.grpBoxTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinFinMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinIniMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHorFinMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHorIniMod)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(668, 549);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 35);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ubicación";
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(544, 549);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(105, 35);
            this.btCreate.TabIndex = 6;
            this.btCreate.Text = "Confirmar";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(27, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 181);
            this.groupBox1.TabIndex = 2;
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
            this.udMinFin.TabIndex = 5;
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
            this.udHoraFin.TabIndex = 4;
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
            this.udMinIni.TabIndex = 3;
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
            this.udHoraIni.TabIndex = 2;
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
            "Domingo",
            "Jueves",
            "Lunes",
            "Martes",
            "Miercoles",
            "Sabado",
            "Viernes"});
            this.cbDia.Location = new System.Drawing.Point(62, 32);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(121, 21);
            this.cbDia.TabIndex = 1;
            this.cbDia.Text = "Lunes";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(222, 175);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(43, 46);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add =>";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 50;
            this.label1.Text = "Gestionar Turnos";
            // 
            // tbUbi
            // 
            this.tbUbi.Location = new System.Drawing.Point(27, 92);
            this.tbUbi.Name = "tbUbi";
            this.tbUbi.Size = new System.Drawing.Size(189, 20);
            this.tbUbi.TabIndex = 1;
            // 
            // lbErrUbi
            // 
            this.lbErrUbi.AutoSize = true;
            this.lbErrUbi.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrUbi.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrUbi.Location = new System.Drawing.Point(222, 96);
            this.lbErrUbi.Name = "lbErrUbi";
            this.lbErrUbi.Size = new System.Drawing.Size(145, 13);
            this.lbErrUbi.TabIndex = 64;
            this.lbErrUbi.Text = "El campo no puede estar vacio";
            this.lbErrUbi.Visible = false;
            // 
            // dgTurnos
            // 
            this.dgTurnos.AllowUserToAddRows = false;
            this.dgTurnos.AllowUserToDeleteRows = false;
            this.dgTurnos.AllowUserToOrderColumns = true;
            this.dgTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTurnos.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.HoraInicio,
            this.HoraFin,
            this.Ubicacion,
            this.Borrar});
            this.dgTurnos.Location = new System.Drawing.Point(271, 118);
            this.dgTurnos.Name = "dgTurnos";
            this.dgTurnos.ReadOnly = true;
            this.dgTurnos.Size = new System.Drawing.Size(497, 178);
            this.dgTurnos.TabIndex = 4;
            this.dgTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTurnos_CellClick);
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
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            // 
            // grpBoxTurno
            // 
            this.grpBoxTurno.Controls.Add(this.btnCancelar);
            this.grpBoxTurno.Controls.Add(this.btnGuardar);
            this.grpBoxTurno.Controls.Add(this.label17);
            this.grpBoxTurno.Controls.Add(this.txtBoxLugarMod);
            this.grpBoxTurno.Controls.Add(this.label2);
            this.grpBoxTurno.Controls.Add(this.label7);
            this.grpBoxTurno.Controls.Add(this.nUDMinFinMod);
            this.grpBoxTurno.Controls.Add(this.nUDMinIniMod);
            this.grpBoxTurno.Controls.Add(this.label12);
            this.grpBoxTurno.Controls.Add(this.label13);
            this.grpBoxTurno.Controls.Add(this.nUDHorFinMod);
            this.grpBoxTurno.Controls.Add(this.nUDHorIniMod);
            this.grpBoxTurno.Controls.Add(this.label14);
            this.grpBoxTurno.Controls.Add(this.label15);
            this.grpBoxTurno.Controls.Add(this.label16);
            this.grpBoxTurno.Controls.Add(this.cmbBoxDiaMod);
            this.grpBoxTurno.Location = new System.Drawing.Point(23, 347);
            this.grpBoxTurno.Name = "grpBoxTurno";
            this.grpBoxTurno.Size = new System.Drawing.Size(760, 148);
            this.grpBoxTurno.TabIndex = 5;
            this.grpBoxTurno.TabStop = false;
            this.grpBoxTurno.Text = "Turno";
            this.grpBoxTurno.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(548, 85);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 30);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(548, 39);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 29);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Confirmar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(259, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 65;
            this.label17.Text = "Lugar";
            // 
            // txtBoxLugarMod
            // 
            this.txtBoxLugarMod.Location = new System.Drawing.Point(323, 48);
            this.txtBoxLugarMod.Name = "txtBoxLugarMod";
            this.txtBoxLugarMod.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLugarMod.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "M";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "H";
            // 
            // nUDMinFinMod
            // 
            this.nUDMinFinMod.Location = new System.Drawing.Point(127, 85);
            this.nUDMinFinMod.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nUDMinFinMod.Name = "nUDMinFinMod";
            this.nUDMinFinMod.Size = new System.Drawing.Size(39, 20);
            this.nUDMinFinMod.TabIndex = 4;
            // 
            // nUDMinIniMod
            // 
            this.nUDMinIniMod.Location = new System.Drawing.Point(127, 49);
            this.nUDMinIniMod.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nUDMinIniMod.Name = "nUDMinIniMod";
            this.nUDMinIniMod.Size = new System.Drawing.Size(39, 20);
            this.nUDMinIniMod.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "M";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "H";
            // 
            // nUDHorFinMod
            // 
            this.nUDHorFinMod.Location = new System.Drawing.Point(58, 83);
            this.nUDHorFinMod.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nUDHorFinMod.Name = "nUDHorFinMod";
            this.nUDHorFinMod.Size = new System.Drawing.Size(40, 20);
            this.nUDHorFinMod.TabIndex = 3;
            // 
            // nUDHorIniMod
            // 
            this.nUDHorIniMod.Location = new System.Drawing.Point(58, 49);
            this.nUDHorIniMod.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nUDHorIniMod.Name = "nUDHorIniMod";
            this.nUDHorIniMod.Size = new System.Drawing.Size(42, 20);
            this.nUDHorIniMod.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "De";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(265, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "El";
            // 
            // cmbBoxDiaMod
            // 
            this.cmbBoxDiaMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDiaMod.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cmbBoxDiaMod.Location = new System.Drawing.Point(302, 89);
            this.cmbBoxDiaMod.Name = "cmbBoxDiaMod";
            this.cmbBoxDiaMod.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxDiaMod.TabIndex = 6;
            // 
            // AGestTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
            this.Controls.Add(this.grpBoxTurno);
            this.Controls.Add(this.dgTurnos);
            this.Controls.Add(this.lbErrUbi);
            this.Controls.Add(this.tbUbi);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AGestTurn";
            this.Text = "Turno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMinFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHoraIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTurnos)).EndInit();
            this.grpBoxTurno.ResumeLayout(false);
            this.grpBoxTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinFinMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinIniMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHorFinMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHorIniMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.TextBox tbUbi;
        private System.Windows.Forms.NumericUpDown udMinFin;
        private System.Windows.Forms.NumericUpDown udHoraFin;
        private System.Windows.Forms.NumericUpDown udMinIni;
        private System.Windows.Forms.NumericUpDown udHoraIni;
        private System.Windows.Forms.Label lbErrUbi;
        private System.Windows.Forms.DataGridView dgTurnos;
        private System.Windows.Forms.Label lbErrHora;
        private System.Windows.Forms.GroupBox grpBoxTurno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBoxLugarMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nUDMinFinMod;
        private System.Windows.Forms.NumericUpDown nUDMinIniMod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nUDHorFinMod;
        private System.Windows.Forms.NumericUpDown nUDHorIniMod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbBoxDiaMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}