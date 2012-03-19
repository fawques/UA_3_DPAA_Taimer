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
            this.lbErrName = new System.Windows.Forms.Label();
            this.lbErrDesc = new System.Windows.Forms.Label();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTurnos)).BeginInit();
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
            this.btCreate.TabIndex = 48;
            this.btCreate.Text = "Crear";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btAddTurn
            // 
            this.btAddTurn.Location = new System.Drawing.Point(169, 319);
            this.btAddTurn.Name = "btAddTurn";
            this.btAddTurn.Size = new System.Drawing.Size(125, 57);
            this.btAddTurn.TabIndex = 47;
            this.btAddTurn.Text = "Añadir Turnos";
            this.btAddTurn.UseVisualStyleBackColor = true;
            this.btAddTurn.Click += new System.EventHandler(this.btAddTurn_Click);
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(44, 195);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(495, 101);
            this.tbDesc.TabIndex = 44;
            this.tbDesc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(44, 136);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 41;
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
            this.dgTurnos.Size = new System.Drawing.Size(303, 176);
            this.dgTurnos.TabIndex = 51;
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
            this.HoraInicio.Width = 80;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            this.HoraFin.Width = 80;
            // 
            // lbErrName
            // 
            this.lbErrName.AutoSize = true;
            this.lbErrName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrName.ForeColor = System.Drawing.Color.Maroon;
            this.lbErrName.Location = new System.Drawing.Point(150, 140);
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
            this.lbErrDesc.Location = new System.Drawing.Point(545, 199);
            this.lbErrDesc.Name = "lbErrDesc";
            this.lbErrDesc.Size = new System.Drawing.Size(145, 13);
            this.lbErrDesc.TabIndex = 65;
            this.lbErrDesc.Text = "El campo no puede estar vacio";
            this.lbErrDesc.Visible = false;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Visible = false;
            // 
            // AAddAsig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgTurnos)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.Label lbErrName;
        private System.Windows.Forms.Label lbErrDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;

    }
}