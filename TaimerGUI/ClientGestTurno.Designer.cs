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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbErrUbi = new System.Windows.Forms.Label();
            this.lblErrorDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxLugar = new System.Windows.Forms.TextBox();
            this.nmUpDwnMinHasta = new System.Windows.Forms.NumericUpDown();
            this.nmUpDwnMinDesde = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nmUpDwnHorHasta = new System.Windows.Forms.NumericUpDown();
            this.nmUpDwnHorDesde = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDia = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gVHorasTemp = new System.Windows.Forms.DataGridView();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpBoxTurno = new System.Windows.Forms.GroupBox();
            this.lblMenorTurno = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBoxLugarMod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnConfCambios = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnMinHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnMinDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnHorHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnHorDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVHorasTemp)).BeginInit();
            this.grpBoxTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinFinMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinIniMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHorFinMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHorIniMod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 31);
            this.label1.TabIndex = 66;
            this.label1.Text = "Taimer - Gestionar Turnos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbErrUbi);
            this.groupBox1.Controls.Add(this.lblErrorDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBoxLugar);
            this.groupBox1.Controls.Add(this.nmUpDwnMinHasta);
            this.groupBox1.Controls.Add(this.nmUpDwnMinDesde);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nmUpDwnHorHasta);
            this.groupBox1.Controls.Add(this.nmUpDwnHorDesde);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxDia);
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 235);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turno";
            // 
            // lbErrUbi
            // 
            this.lbErrUbi.AutoSize = true;
            this.lbErrUbi.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrUbi.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrUbi.Location = new System.Drawing.Point(24, 53);
            this.lbErrUbi.Name = "lbErrUbi";
            this.lbErrUbi.Size = new System.Drawing.Size(145, 13);
            this.lbErrUbi.TabIndex = 65;
            this.lbErrUbi.Text = "El campo no puede estar vacío";
            this.lbErrUbi.Visible = false;
            this.lbErrUbi.Click += new System.EventHandler(this.lbErrUbi_Click);
            // 
            // lblErrorDate
            // 
            this.lblErrorDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblErrorDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblErrorDate.Location = new System.Drawing.Point(16, 195);
            this.lblErrorDate.Name = "lblErrorDate";
            this.lblErrorDate.Size = new System.Drawing.Size(166, 32);
            this.lblErrorDate.TabIndex = 60;
            this.lblErrorDate.Text = "La hora de inicio debe ser menor que la de fin.";
            this.lblErrorDate.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Lugar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "M";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "H";
            // 
            // txtBoxLugar
            // 
            this.txtBoxLugar.Location = new System.Drawing.Point(82, 23);
            this.txtBoxLugar.Name = "txtBoxLugar";
            this.txtBoxLugar.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLugar.TabIndex = 61;
            // 
            // nmUpDwnMinHasta
            // 
            this.nmUpDwnMinHasta.Location = new System.Drawing.Point(124, 166);
            this.nmUpDwnMinHasta.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nmUpDwnMinHasta.Name = "nmUpDwnMinHasta";
            this.nmUpDwnMinHasta.Size = new System.Drawing.Size(39, 20);
            this.nmUpDwnMinHasta.TabIndex = 10;
            // 
            // nmUpDwnMinDesde
            // 
            this.nmUpDwnMinDesde.Location = new System.Drawing.Point(124, 130);
            this.nmUpDwnMinDesde.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nmUpDwnMinDesde.Name = "nmUpDwnMinDesde";
            this.nmUpDwnMinDesde.Size = new System.Drawing.Size(39, 20);
            this.nmUpDwnMinDesde.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "H";
            // 
            // nmUpDwnHorHasta
            // 
            this.nmUpDwnHorHasta.Location = new System.Drawing.Point(55, 164);
            this.nmUpDwnHorHasta.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nmUpDwnHorHasta.Name = "nmUpDwnHorHasta";
            this.nmUpDwnHorHasta.Size = new System.Drawing.Size(40, 20);
            this.nmUpDwnHorHasta.TabIndex = 5;
            // 
            // nmUpDwnHorDesde
            // 
            this.nmUpDwnHorDesde.Location = new System.Drawing.Point(55, 130);
            this.nmUpDwnHorDesde.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nmUpDwnHorDesde.Name = "nmUpDwnHorDesde";
            this.nmUpDwnHorDesde.Size = new System.Drawing.Size(42, 20);
            this.nmUpDwnHorDesde.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "De";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "El";
            // 
            // comboBoxDia
            // 
            this.comboBoxDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.comboBoxDia.Location = new System.Drawing.Point(58, 90);
            this.comboBoxDia.Name = "comboBoxDia";
            this.comboBoxDia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDia.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TaimerGUI.Properties.Resources.flechaRight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(232, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 58);
            this.button1.TabIndex = 68;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gVHorasTemp
            // 
            this.gVHorasTemp.AllowUserToAddRows = false;
            this.gVHorasTemp.BackgroundColor = System.Drawing.Color.Wheat;
            this.gVHorasTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVHorasTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.horaInicio,
            this.horaFin,
            this.lugar,
            this.borrar});
            this.gVHorasTemp.Location = new System.Drawing.Point(281, 123);
            this.gVHorasTemp.Name = "gVHorasTemp";
            this.gVHorasTemp.ReadOnly = true;
            this.gVHorasTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gVHorasTemp.Size = new System.Drawing.Size(491, 235);
            this.gVHorasTemp.TabIndex = 67;
            this.gVHorasTemp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVHorasTemp_CellClick);
            // 
            // dia
            // 
            this.dia.HeaderText = "Dia";
            this.dia.MaxInputLength = 15;
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            this.dia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dia.Width = 95;
            // 
            // horaInicio
            // 
            this.horaInicio.HeaderText = "Hora inicio";
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.ReadOnly = true;
            // 
            // horaFin
            // 
            this.horaFin.HeaderText = "Hora fin";
            this.horaFin.Name = "horaFin";
            this.horaFin.ReadOnly = true;
            // 
            // lugar
            // 
            this.lugar.HeaderText = "Lugar";
            this.lugar.Name = "lugar";
            this.lugar.ReadOnly = true;
            // 
            // borrar
            // 
            this.borrar.HeaderText = "Borrar";
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            this.borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.borrar.Text = "Borrar";
            this.borrar.Width = 53;
            // 
            // grpBoxTurno
            // 
            this.grpBoxTurno.Controls.Add(this.lblMenorTurno);
            this.grpBoxTurno.Controls.Add(this.btnCancelar);
            this.grpBoxTurno.Controls.Add(this.btnGuardar);
            this.grpBoxTurno.Controls.Add(this.label17);
            this.grpBoxTurno.Controls.Add(this.txtBoxLugarMod);
            this.grpBoxTurno.Controls.Add(this.label2);
            this.grpBoxTurno.Controls.Add(this.label5);
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
            this.grpBoxTurno.Location = new System.Drawing.Point(16, 402);
            this.grpBoxTurno.Name = "grpBoxTurno";
            this.grpBoxTurno.Size = new System.Drawing.Size(760, 148);
            this.grpBoxTurno.TabIndex = 70;
            this.grpBoxTurno.TabStop = false;
            this.grpBoxTurno.Text = "Modificar turno";
            this.grpBoxTurno.Visible = false;
            // 
            // lblMenorTurno
            // 
            this.lblMenorTurno.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMenorTurno.ForeColor = System.Drawing.Color.Maroon;
            this.lblMenorTurno.Location = new System.Drawing.Point(26, 106);
            this.lblMenorTurno.Name = "lblMenorTurno";
            this.lblMenorTurno.Size = new System.Drawing.Size(166, 32);
            this.lblMenorTurno.TabIndex = 68;
            this.lblMenorTurno.Text = "La hora de inicio debe ser menor que la de fin.";
            this.lblMenorTurno.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(548, 85);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 30);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(548, 39);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 29);
            this.btnGuardar.TabIndex = 66;
            this.btnGuardar.Text = "Confirmar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(240, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 65;
            this.label17.Text = "Ubicación";
            // 
            // txtBoxLugarMod
            // 
            this.txtBoxLugarMod.Location = new System.Drawing.Point(323, 48);
            this.txtBoxLugarMod.Name = "txtBoxLugarMod";
            this.txtBoxLugarMod.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLugarMod.TabIndex = 64;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "H";
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
            this.nUDMinFinMod.TabIndex = 22;
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
            this.nUDMinIniMod.TabIndex = 21;
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
            this.nUDHorFinMod.TabIndex = 18;
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
            this.nUDHorIniMod.TabIndex = 17;
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
            this.cmbBoxDiaMod.TabIndex = 13;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(680, 570);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(92, 30);
            this.btnTerminar.TabIndex = 71;
            this.btnTerminar.Text = "Cancelar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnConfCambios
            // 
            this.btnConfCambios.Location = new System.Drawing.Point(564, 570);
            this.btnConfCambios.Name = "btnConfCambios";
            this.btnConfCambios.Size = new System.Drawing.Size(92, 30);
            this.btnConfCambios.TabIndex = 72;
            this.btnConfCambios.Text = "Confirmar";
            this.btnConfCambios.UseVisualStyleBackColor = true;
            this.btnConfCambios.Click += new System.EventHandler(this.btnConfCambios_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(71, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(258, 13);
            this.label18.TabIndex = 73;
            this.label18.Text = "Añade, borra y modifica los turnos de tus actividades.";
            // 
            // ClientGestTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(792, 616);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnConfCambios);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.grpBoxTurno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gVHorasTemp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientGestTurno";
            this.Text = "ClientGestTurno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnMinHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnMinDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnHorHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnHorDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVHorasTemp)).EndInit();
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxLugar;
        private System.Windows.Forms.Label lblErrorDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmUpDwnMinHasta;
        private System.Windows.Forms.NumericUpDown nmUpDwnMinDesde;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmUpDwnHorHasta;
        private System.Windows.Forms.NumericUpDown nmUpDwnHorDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gVHorasTemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpBoxTurno;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBoxLugarMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label lbErrUbi;
        private System.Windows.Forms.Button btnConfCambios;
        private System.Windows.Forms.Label lblMenorTurno;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
    }
}