namespace TaimerGUI
{
    partial class ClientCrearActiv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rTBDescripcion = new System.Windows.Forms.RichTextBox();
            this.gVHorasTemp = new System.Windows.Forms.DataGridView();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.bttnCrearActiv = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.gVHorasTemp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnMinHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnMinDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnHorHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnHorDesde)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Crear actividad";
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(35, 101);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(180, 20);
            this.tBNombre.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Descripcion";
            // 
            // rTBDescripcion
            // 
            this.rTBDescripcion.Location = new System.Drawing.Point(35, 194);
            this.rTBDescripcion.Name = "rTBDescripcion";
            this.rTBDescripcion.Size = new System.Drawing.Size(401, 101);
            this.rTBDescripcion.TabIndex = 33;
            this.rTBDescripcion.Text = "";
            // 
            // gVHorasTemp
            // 
            this.gVHorasTemp.AllowUserToAddRows = false;
            this.gVHorasTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVHorasTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.horaInicio,
            this.horaFin,
            this.borrar});
            this.gVHorasTemp.Location = new System.Drawing.Point(315, 332);
            this.gVHorasTemp.Name = "gVHorasTemp";
            this.gVHorasTemp.ReadOnly = true;
            this.gVHorasTemp.Size = new System.Drawing.Size(443, 150);
            this.gVHorasTemp.TabIndex = 35;
            this.gVHorasTemp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVHorasTemp_CellContentClick);
            // 
            // dia
            // 
            this.dia.HeaderText = "Dia";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
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
            // borrar
            // 
            this.borrar.HeaderText = "Borrar";
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            this.borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.borrar.Text = "Borrar";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TaimerGUI.Properties.Resources.flechaRight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(254, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 46);
            this.button1.TabIndex = 37;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnCrearActiv
            // 
            this.bttnCrearActiv.Location = new System.Drawing.Point(535, 548);
            this.bttnCrearActiv.Name = "bttnCrearActiv";
            this.bttnCrearActiv.Size = new System.Drawing.Size(105, 35);
            this.bttnCrearActiv.TabIndex = 38;
            this.bttnCrearActiv.Text = "Crear";
            this.bttnCrearActiv.UseVisualStyleBackColor = true;
            this.bttnCrearActiv.Click += new System.EventHandler(this.bttnCrearActiv_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(659, 548);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(105, 35);
            this.bCancelar.TabIndex = 39;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrorDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
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
            this.groupBox1.Location = new System.Drawing.Point(35, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 186);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hora y Dia";
            // 
            // lblErrorDate
            // 
            this.lblErrorDate.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDate.Location = new System.Drawing.Point(23, 137);
            this.lblErrorDate.Name = "lblErrorDate";
            this.lblErrorDate.Size = new System.Drawing.Size(166, 46);
            this.lblErrorDate.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "M";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "H";
            // 
            // nmUpDwnMinHasta
            // 
            this.nmUpDwnMinHasta.Location = new System.Drawing.Point(128, 108);
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
            this.nmUpDwnMinDesde.Location = new System.Drawing.Point(128, 72);
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
            this.label9.Location = new System.Drawing.Point(173, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "H";
            // 
            // nmUpDwnHorHasta
            // 
            this.nmUpDwnHorHasta.Location = new System.Drawing.Point(59, 106);
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
            this.nmUpDwnHorDesde.Location = new System.Drawing.Point(59, 72);
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
            this.comboBoxDia.Location = new System.Drawing.Point(62, 32);
            this.comboBoxDia.Name = "comboBoxDia";
            this.comboBoxDia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDia.TabIndex = 0;
            // 
            // ClientCrearActiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bttnCrearActiv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gVHorasTemp);
            this.Controls.Add(this.rTBDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientCrearActiv";
            this.Text = "ClientCrearActiv";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClientCrearActiv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVHorasTemp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnMinHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnMinDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnHorHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnHorDesde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rTBDescripcion;
        private System.Windows.Forms.DataGridView gVHorasTemp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttnCrearActiv;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDia;
        private System.Windows.Forms.NumericUpDown nmUpDwnHorHasta;
        private System.Windows.Forms.NumericUpDown nmUpDwnHorDesde;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmUpDwnMinHasta;
        private System.Windows.Forms.NumericUpDown nmUpDwnMinDesde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFin;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
        private System.Windows.Forms.Label lblErrorDate;
    }
}