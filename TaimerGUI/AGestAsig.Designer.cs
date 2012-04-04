namespace TaimerGUI {
    partial class AGestAsig {
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
            this.lbCoord = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbHoraInfo = new System.Windows.Forms.Label();
            this.lbCoordInfo = new System.Windows.Forms.Label();
            this.lbDescInfo = new System.Windows.Forms.Label();
            this.lbNameInfo = new System.Windows.Forms.Label();
            this.btNewUser = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.dgAsig = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgTurns = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btGestTurno = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbCoord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTurns)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCoord
            // 
            this.lbCoord.AutoSize = true;
            this.lbCoord.Location = new System.Drawing.Point(516, 233);
            this.lbCoord.Name = "lbCoord";
            this.lbCoord.Size = new System.Drawing.Size(31, 13);
            this.lbCoord.TabIndex = 21;
            this.lbCoord.Text = "Irene";
            this.lbCoord.Click += new System.EventHandler(this.lbCoord_Click);
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(516, 195);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(208, 13);
            this.lbDesc.TabIndex = 20;
            this.lbDesc.Text = "Diseño y Analisis de Algoritmos Avanzados";
            this.lbDesc.Click += new System.EventHandler(this.lbDesc_Click);
            // 
            // lbHoraInfo
            // 
            this.lbHoraInfo.AutoSize = true;
            this.lbHoraInfo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoraInfo.Location = new System.Drawing.Point(453, 273);
            this.lbHoraInfo.Name = "lbHoraInfo";
            this.lbHoraInfo.Size = new System.Drawing.Size(49, 13);
            this.lbHoraInfo.TabIndex = 19;
            this.lbHoraInfo.Text = "Horarios:";
            // 
            // lbCoordInfo
            // 
            this.lbCoordInfo.AutoSize = true;
            this.lbCoordInfo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoordInfo.Location = new System.Drawing.Point(434, 233);
            this.lbCoordInfo.Name = "lbCoordInfo";
            this.lbCoordInfo.Size = new System.Drawing.Size(68, 13);
            this.lbCoordInfo.TabIndex = 18;
            this.lbCoordInfo.Text = "Coordinador:";
            // 
            // lbDescInfo
            // 
            this.lbDescInfo.AutoSize = true;
            this.lbDescInfo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescInfo.Location = new System.Drawing.Point(437, 195);
            this.lbDescInfo.Name = "lbDescInfo";
            this.lbDescInfo.Size = new System.Drawing.Size(65, 13);
            this.lbDescInfo.TabIndex = 17;
            this.lbDescInfo.Text = "Descripcion:";
            // 
            // lbNameInfo
            // 
            this.lbNameInfo.AutoSize = true;
            this.lbNameInfo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameInfo.Location = new System.Drawing.Point(454, 144);
            this.lbNameInfo.Name = "lbNameInfo";
            this.lbNameInfo.Size = new System.Drawing.Size(48, 13);
            this.lbNameInfo.TabIndex = 16;
            this.lbNameInfo.Text = "Nombre:";
            // 
            // btNewUser
            // 
            this.btNewUser.Location = new System.Drawing.Point(287, 484);
            this.btNewUser.Name = "btNewUser";
            this.btNewUser.Size = new System.Drawing.Size(107, 24);
            this.btNewUser.TabIndex = 15;
            this.btNewUser.Text = "Nueva Asignatura";
            this.btNewUser.UseVisualStyleBackColor = true;
            this.btNewUser.Click += new System.EventHandler(this.btNewUser_Click_1);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(514, 131);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(136, 29);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "DPAA Teoria";
            this.lbName.Click += new System.EventHandler(this.lbUserName_Click);
            // 
            // dgAsig
            // 
            this.dgAsig.AllowUserToAddRows = false;
            this.dgAsig.AllowUserToDeleteRows = false;
            this.dgAsig.AllowUserToOrderColumns = true;
            this.dgAsig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAsig.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Profesor});
            this.dgAsig.Location = new System.Drawing.Point(94, 129);
            this.dgAsig.Name = "dgAsig";
            this.dgAsig.ReadOnly = true;
            this.dgAsig.Size = new System.Drawing.Size(300, 349);
            this.dgAsig.TabIndex = 13;
            this.dgAsig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAsig_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Profesor
            // 
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 12;
            // 
            // dgTurns
            // 
            this.dgTurns.AllowUserToAddRows = false;
            this.dgTurns.AllowUserToDeleteRows = false;
            this.dgTurns.AllowUserToOrderColumns = true;
            this.dgTurns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTurns.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgTurns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTurns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.Inicio,
            this.Fin,
            this.Ubicacion});
            this.dgTurns.Enabled = false;
            this.dgTurns.Location = new System.Drawing.Point(519, 273);
            this.dgTurns.Name = "dgTurns";
            this.dgTurns.ReadOnly = true;
            this.dgTurns.Size = new System.Drawing.Size(246, 140);
            this.dgTurns.TabIndex = 24;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // Inicio
            // 
            this.Inicio.HeaderText = "Inicio";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            // 
            // Fin
            // 
            this.Fin.HeaderText = "Fin";
            this.Fin.Name = "Fin";
            this.Fin.ReadOnly = true;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 39);
            this.label6.TabIndex = 25;
            this.label6.Text = "Gestionar Asignaturas";
            // 
            // btGestTurno
            // 
            this.btGestTurno.Enabled = false;
            this.btGestTurno.Location = new System.Drawing.Point(658, 419);
            this.btGestTurno.Name = "btGestTurno";
            this.btGestTurno.Size = new System.Drawing.Size(107, 24);
            this.btGestTurno.TabIndex = 26;
            this.btGestTurno.Text = "Gestionar Turnos";
            this.btGestTurno.UseVisualStyleBackColor = true;
            this.btGestTurno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCancel
            // 
            this.btCancel.Enabled = false;
            this.btCancel.Location = new System.Drawing.Point(678, 548);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 35);
            this.btCancel.TabIndex = 63;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCreate
            // 
            this.btCreate.Enabled = false;
            this.btCreate.Location = new System.Drawing.Point(554, 548);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(105, 35);
            this.btCreate.TabIndex = 62;
            this.btCreate.Text = "Confirmar";
            this.btCreate.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(519, 140);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(140, 20);
            this.tbName.TabIndex = 64;
            this.tbName.Visible = false;
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(519, 191);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(246, 20);
            this.tbDesc.TabIndex = 65;
            this.tbDesc.Visible = false;
            this.tbDesc.Validated += new System.EventHandler(this.tbDesc_Validated);
            // 
            // tbCoord
            // 
            this.tbCoord.Location = new System.Drawing.Point(519, 229);
            this.tbCoord.Name = "tbCoord";
            this.tbCoord.Size = new System.Drawing.Size(246, 20);
            this.tbCoord.TabIndex = 66;
            this.tbCoord.Visible = false;
            this.tbCoord.Validated += new System.EventHandler(this.tbCoord_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Filtrar:";
            // 
            // AGestAsig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btGestTurno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgTurns);
            this.Controls.Add(this.lbCoord);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbHoraInfo);
            this.Controls.Add(this.lbCoordInfo);
            this.Controls.Add(this.lbDescInfo);
            this.Controls.Add(this.lbNameInfo);
            this.Controls.Add(this.btNewUser);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.dgAsig);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbCoord);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AGestAsig";
            this.Text = "AGestAsig";
            this.Load += new System.EventHandler(this.AGestAsig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTurns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCoord;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbHoraInfo;
        private System.Windows.Forms.Label lbCoordInfo;
        private System.Windows.Forms.Label lbDescInfo;
        private System.Windows.Forms.Label lbNameInfo;
        private System.Windows.Forms.Button btNewUser;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dgAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgTurns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btGestTurno;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbCoord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
    }
}