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
            this.btBuscarUSer = new System.Windows.Forms.Button();
            this.lbCoord = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbHoraInfo = new System.Windows.Forms.Label();
            this.lbCoordInfo = new System.Windows.Forms.Label();
            this.lbDescInfo = new System.Windows.Forms.Label();
            this.lbNameInfo = new System.Windows.Forms.Label();
            this.btNewUser = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.tbUsers = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgTurns = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbCoord = new System.Windows.Forms.TextBox();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTurns)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscarUSer
            // 
            this.btBuscarUSer.Location = new System.Drawing.Point(319, 103);
            this.btBuscarUSer.Name = "btBuscarUSer";
            this.btBuscarUSer.Size = new System.Drawing.Size(75, 20);
            this.btBuscarUSer.TabIndex = 23;
            this.btBuscarUSer.Text = "Buscar";
            this.btBuscarUSer.UseVisualStyleBackColor = true;
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
            // tbUsers
            // 
            this.tbUsers.AllowUserToAddRows = false;
            this.tbUsers.AllowUserToDeleteRows = false;
            this.tbUsers.AllowUserToOrderColumns = true;
            this.tbUsers.BackgroundColor = System.Drawing.Color.Wheat;
            this.tbUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.tbUsers.Location = new System.Drawing.Point(94, 129);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.ReadOnly = true;
            this.tbUsers.Size = new System.Drawing.Size(300, 349);
            this.tbUsers.TabIndex = 13;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 255;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 12;
            // 
            // dgTurns
            // 
            this.dgTurns.AllowUserToAddRows = false;
            this.dgTurns.AllowUserToDeleteRows = false;
            this.dgTurns.AllowUserToOrderColumns = true;
            this.dgTurns.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgTurns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTurns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.HoraInicio,
            this.HoraFin,
            this.Ubicacion});
            this.dgTurns.Location = new System.Drawing.Point(519, 273);
            this.dgTurns.Name = "dgTurns";
            this.dgTurns.ReadOnly = true;
            this.dgTurns.Size = new System.Drawing.Size(246, 140);
            this.dgTurns.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Día";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Width = 90;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            this.HoraFin.Width = 80;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 24);
            this.button1.TabIndex = 26;
            this.button1.Text = "Gestionar Turnos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Visible = false;
            // 
            // AGestAsig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 595);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgTurns);
            this.Controls.Add(this.btBuscarUSer);
            this.Controls.Add(this.lbCoord);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbHoraInfo);
            this.Controls.Add(this.lbCoordInfo);
            this.Controls.Add(this.lbDescInfo);
            this.Controls.Add(this.lbNameInfo);
            this.Controls.Add(this.btNewUser);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbUsers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbCoord);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AGestAsig";
            this.Text = "AGestAsig";
            ((System.ComponentModel.ISupportInitialize)(this.tbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTurns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscarUSer;
        private System.Windows.Forms.Label lbCoord;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbHoraInfo;
        private System.Windows.Forms.Label lbCoordInfo;
        private System.Windows.Forms.Label lbDescInfo;
        private System.Windows.Forms.Label lbNameInfo;
        private System.Windows.Forms.Button btNewUser;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView tbUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgTurns;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbCoord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
    }
}