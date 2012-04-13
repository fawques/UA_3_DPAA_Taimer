namespace TaimerGUI {
    partial class AAddAsig {
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
            this.btCreate = new System.Windows.Forms.Button();
            this.btAddTurn = new System.Windows.Forms.Button();
            this.tbDesc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgTurnos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbErrName = new System.Windows.Forms.Label();
            this.lbErrDesc = new System.Windows.Forms.Label();
            this.lbErrCoord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCoord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTitu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.udCurso = new System.Windows.Forms.NumericUpDown();
            this.lbErrTit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTurnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(668, 549);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 35);
            this.btCancel.TabIndex = 49;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(544, 549);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(105, 35);
            this.btCreate.TabIndex = 6;
            this.btCreate.Text = "Crear";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btAddTurn
            // 
            this.btAddTurn.Location = new System.Drawing.Point(169, 371);
            this.btAddTurn.Name = "btAddTurn";
            this.btAddTurn.Size = new System.Drawing.Size(125, 57);
            this.btAddTurn.TabIndex = 4;
            this.btAddTurn.Text = "Gestionar Turnos";
            this.btAddTurn.UseVisualStyleBackColor = true;
            this.btAddTurn.Click += new System.EventHandler(this.btAddTurn_Click);
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(44, 137);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(420, 78);
            this.tbDesc.TabIndex = 2;
            this.tbDesc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(44, 98);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 40;
            this.label1.Text = "Crear Asignatura";
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
            this.dataGridViewTextBoxColumn1,
            this.HoraInicio,
            this.HoraFin,
            this.Ubicacion});
            this.dgTurnos.Location = new System.Drawing.Point(300, 319);
            this.dgTurnos.Name = "dgTurnos";
            this.dgTurnos.ReadOnly = true;
            this.dgTurnos.Size = new System.Drawing.Size(423, 176);
            this.dgTurnos.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Día";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // lbErrName
            // 
            this.lbErrName.AutoSize = true;
            this.lbErrName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrName.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrName.Location = new System.Drawing.Point(150, 102);
            this.lbErrName.Name = "lbErrName";
            this.lbErrName.Size = new System.Drawing.Size(145, 13);
            this.lbErrName.TabIndex = 64;
            this.lbErrName.Text = "El campo no puede estar vacio";
            this.lbErrName.Visible = false;
            // 
            // lbErrDesc
            // 
            this.lbErrDesc.AutoSize = true;
            this.lbErrDesc.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrDesc.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrDesc.Location = new System.Drawing.Point(470, 141);
            this.lbErrDesc.Name = "lbErrDesc";
            this.lbErrDesc.Size = new System.Drawing.Size(145, 13);
            this.lbErrDesc.TabIndex = 65;
            this.lbErrDesc.Text = "El campo no puede estar vacio";
            this.lbErrDesc.Visible = false;
            // 
            // lbErrCoord
            // 
            this.lbErrCoord.AutoSize = true;
            this.lbErrCoord.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrCoord.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrCoord.Location = new System.Drawing.Point(470, 240);
            this.lbErrCoord.Name = "lbErrCoord";
            this.lbErrCoord.Size = new System.Drawing.Size(145, 13);
            this.lbErrCoord.TabIndex = 68;
            this.lbErrCoord.Text = "El campo no puede estar vacio";
            this.lbErrCoord.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Coordinador";
            // 
            // tbCoord
            // 
            this.tbCoord.Location = new System.Drawing.Point(44, 236);
            this.tbCoord.Name = "tbCoord";
            this.tbCoord.Size = new System.Drawing.Size(420, 20);
            this.tbCoord.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Creación de una nueva asignatura y sus turnos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Titulación";
            // 
            // tbTitu
            // 
            this.tbTitu.Location = new System.Drawing.Point(44, 280);
            this.tbTitu.Name = "tbTitu";
            this.tbTitu.Size = new System.Drawing.Size(185, 20);
            this.tbTitu.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Curso";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // udCurso
            // 
            this.udCurso.Location = new System.Drawing.Point(423, 280);
            this.udCurso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCurso.Name = "udCurso";
            this.udCurso.Size = new System.Drawing.Size(41, 20);
            this.udCurso.TabIndex = 74;
            this.udCurso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbErrTit
            // 
            this.lbErrTit.AutoSize = true;
            this.lbErrTit.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrTit.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrTit.Location = new System.Drawing.Point(235, 283);
            this.lbErrTit.Name = "lbErrTit";
            this.lbErrTit.Size = new System.Drawing.Size(145, 13);
            this.lbErrTit.TabIndex = 75;
            this.lbErrTit.Text = "El campo no puede estar vacio";
            this.lbErrTit.Visible = false;
            // 
            // AAddAsig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
            this.Controls.Add(this.lbErrTit);
            this.Controls.Add(this.udCurso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTitu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbErrCoord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCoord);
            this.Controls.Add(this.lbErrDesc);
            this.Controls.Add(this.lbErrName);
            this.Controls.Add(this.dgTurnos);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btAddTurn);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AAddAsig";
            this.Text = "AAddAsig";
            this.Enter += new System.EventHandler(this.AAddAsig_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgTurnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btAddTurn;
        private System.Windows.Forms.RichTextBox tbDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgTurnos;
        private System.Windows.Forms.Label lbErrName;
        private System.Windows.Forms.Label lbErrDesc;
        private System.Windows.Forms.Label lbErrCoord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCoord;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTitu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown udCurso;
        private System.Windows.Forms.Label lbErrTit;

    }
}