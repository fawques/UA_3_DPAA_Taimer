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
            this.lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttnCrearActiv = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.btnAddTurno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gVHorasTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Taimer - Crear actividad";
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(32, 132);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(180, 20);
            this.tBNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 116);
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
            this.rTBDescripcion.TabIndex = 2;
            this.rTBDescripcion.Text = "";
            // 
            // gVHorasTemp
            // 
            this.gVHorasTemp.AllowUserToAddRows = false;
            this.gVHorasTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gVHorasTemp.BackgroundColor = System.Drawing.Color.Wheat;
            this.gVHorasTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVHorasTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.horaInicio,
            this.horaFin,
            this.lugar});
            this.gVHorasTemp.Location = new System.Drawing.Point(279, 332);
            this.gVHorasTemp.Name = "gVHorasTemp";
            this.gVHorasTemp.ReadOnly = true;
            this.gVHorasTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gVHorasTemp.Size = new System.Drawing.Size(479, 196);
            this.gVHorasTemp.TabIndex = 6;
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
            // lugar
            // 
            this.lugar.HeaderText = "Lugar";
            this.lugar.Name = "lugar";
            this.lugar.ReadOnly = true;
            // 
            // bttnCrearActiv
            // 
            this.bttnCrearActiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnCrearActiv.Location = new System.Drawing.Point(535, 548);
            this.bttnCrearActiv.Name = "bttnCrearActiv";
            this.bttnCrearActiv.Size = new System.Drawing.Size(105, 35);
            this.bttnCrearActiv.TabIndex = 4;
            this.bttnCrearActiv.Text = "Crear";
            this.bttnCrearActiv.UseVisualStyleBackColor = true;
            this.bttnCrearActiv.Click += new System.EventHandler(this.bttnCrearActiv_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.Location = new System.Drawing.Point(659, 548);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(105, 35);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Maroon;
            this.lblErrorNombre.Location = new System.Drawing.Point(218, 136);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(103, 13);
            this.lblErrorNombre.TabIndex = 58;
            this.lblErrorNombre.Text = "No puede estar vacio";
            this.lblErrorNombre.Visible = false;
            // 
            // btnAddTurno
            // 
            this.btnAddTurno.Location = new System.Drawing.Point(107, 396);
            this.btnAddTurno.Name = "btnAddTurno";
            this.btnAddTurno.Size = new System.Drawing.Size(130, 51);
            this.btnAddTurno.TabIndex = 3;
            this.btnAddTurno.Text = "Gestionar turnos";
            this.btnAddTurno.UseVisualStyleBackColor = true;
            this.btnAddTurno.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Crea tu actividad personal para luego gestionar horarios con actividades propias." +
                "";
            // 
            // ClientCrearActiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddTurno);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bttnCrearActiv);
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
        private System.Windows.Forms.Button bttnCrearActiv;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Button btnAddTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar;
        private System.Windows.Forms.Label label3;
    }
}