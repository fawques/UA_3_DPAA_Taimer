namespace TaimerGUI
{
    partial class ClientHorHome
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxFilter = new System.Windows.Forms.TextBox();
            this.dataGridHorarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filtro:";
            // 
            // txtBoxFilter
            // 
            this.txtBoxFilter.Location = new System.Drawing.Point(68, 143);
            this.txtBoxFilter.Name = "txtBoxFilter";
            this.txtBoxFilter.Size = new System.Drawing.Size(167, 20);
            this.txtBoxFilter.TabIndex = 13;
            this.txtBoxFilter.TextChanged += new System.EventHandler(this.txtBoxFilter_TextChanged);
            // 
            // dataGridHorarios
            // 
            this.dataGridHorarios.AllowUserToAddRows = false;
            this.dataGridHorarios.AllowUserToDeleteRows = false;
            this.dataGridHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.ver,
            this.borrar});
            this.dataGridHorarios.Location = new System.Drawing.Point(12, 169);
            this.dataGridHorarios.Name = "dataGridHorarios";
            this.dataGridHorarios.ReadOnly = true;
            this.dataGridHorarios.Size = new System.Drawing.Size(373, 353);
            this.dataGridHorarios.TabIndex = 12;
            this.dataGridHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHorarios_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // ver
            // 
            this.ver.HeaderText = "Ver";
            this.ver.Name = "ver";
            this.ver.ReadOnly = true;
            // 
            // borrar
            // 
            this.borrar.HeaderText = "Borrar";
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Listado de horarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Consulta y modifica tus horarios ya creados.";
            // 
            // ClientHorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxFilter);
            this.Controls.Add(this.dataGridHorarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientHorHome";
            this.Text = "ClientHorHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ClientHorHome_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxFilter;
        private System.Windows.Forms.DataGridView dataGridHorarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewButtonColumn ver;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
        private System.Windows.Forms.Label label3;
    }
}