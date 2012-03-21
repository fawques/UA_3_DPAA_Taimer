namespace Taimer
{
    partial class TestEN
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
            this.hini = new System.Windows.Forms.TextBox();
            this.mini = new System.Windows.Forms.TextBox();
            this.hfin = new System.Windows.Forms.TextBox();
            this.mfin = new System.Windows.Forms.TextBox();
            this.crear = new System.Windows.Forms.Button();
            this.diacombo = new System.Windows.Forms.ComboBox();
            this.lista = new System.Windows.Forms.ListBox();
            this.borrar = new System.Windows.Forms.Button();
            this.codBorrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.copiar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.comboact = new System.Windows.Forms.ComboBox();
            this.horasiguales = new System.Windows.Forms.Button();
            this.minutosdiferencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hini
            // 
            this.hini.Location = new System.Drawing.Point(49, 8);
            this.hini.Name = "hini";
            this.hini.Size = new System.Drawing.Size(32, 20);
            this.hini.TabIndex = 0;
            this.hini.Text = "12";
            // 
            // mini
            // 
            this.mini.Location = new System.Drawing.Point(87, 8);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(32, 20);
            this.mini.TabIndex = 1;
            this.mini.Text = "00";
            // 
            // hfin
            // 
            this.hfin.Location = new System.Drawing.Point(49, 34);
            this.hfin.Name = "hfin";
            this.hfin.Size = new System.Drawing.Size(32, 20);
            this.hfin.TabIndex = 2;
            this.hfin.Text = "23";
            // 
            // mfin
            // 
            this.mfin.Location = new System.Drawing.Point(87, 34);
            this.mfin.Name = "mfin";
            this.mfin.Size = new System.Drawing.Size(32, 20);
            this.mfin.TabIndex = 3;
            this.mfin.Text = "59";
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(172, 7);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(63, 21);
            this.crear.TabIndex = 4;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // diacombo
            // 
            this.diacombo.FormattingEnabled = true;
            this.diacombo.Items.AddRange(new object[] {
            "L",
            "M",
            "X",
            "J",
            "V",
            "S",
            "D"});
            this.diacombo.Location = new System.Drawing.Point(125, 7);
            this.diacombo.Name = "diacombo";
            this.diacombo.Size = new System.Drawing.Size(41, 21);
            this.diacombo.TabIndex = 6;
            this.diacombo.Text = "L";
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 89);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(369, 134);
            this.lista.TabIndex = 7;
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(318, 5);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(63, 19);
            this.borrar.TabIndex = 5;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click_1);
            // 
            // codBorrar
            // 
            this.codBorrar.Location = new System.Drawing.Point(280, 4);
            this.codBorrar.Name = "codBorrar";
            this.codBorrar.Size = new System.Drawing.Size(32, 20);
            this.codBorrar.TabIndex = 8;
            this.codBorrar.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cód:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "H. Ini:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "H. Fin:";
            // 
            // copiar
            // 
            this.copiar.Enabled = false;
            this.copiar.Location = new System.Drawing.Point(249, 30);
            this.copiar.Name = "copiar";
            this.copiar.Size = new System.Drawing.Size(63, 19);
            this.copiar.TabIndex = 12;
            this.copiar.Text = "Copiar";
            this.copiar.UseVisualStyleBackColor = true;
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(318, 30);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(63, 19);
            this.modificar.TabIndex = 13;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // comboact
            // 
            this.comboact.Enabled = false;
            this.comboact.FormattingEnabled = true;
            this.comboact.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3"});
            this.comboact.Location = new System.Drawing.Point(125, 35);
            this.comboact.Name = "comboact";
            this.comboact.Size = new System.Drawing.Size(41, 21);
            this.comboact.TabIndex = 14;
            this.comboact.Text = "A1";
            // 
            // horasiguales
            // 
            this.horasiguales.Location = new System.Drawing.Point(172, 35);
            this.horasiguales.Name = "horasiguales";
            this.horasiguales.Size = new System.Drawing.Size(63, 21);
            this.horasiguales.TabIndex = 15;
            this.horasiguales.Text = "¿Iguales?";
            this.horasiguales.UseVisualStyleBackColor = true;
            this.horasiguales.Click += new System.EventHandler(this.horasiguales_Click);
            // 
            // minutosdiferencia
            // 
            this.minutosdiferencia.Location = new System.Drawing.Point(172, 62);
            this.minutosdiferencia.Name = "minutosdiferencia";
            this.minutosdiferencia.Size = new System.Drawing.Size(63, 21);
            this.minutosdiferencia.TabIndex = 16;
            this.minutosdiferencia.Text = "Mins. dif.";
            this.minutosdiferencia.UseVisualStyleBackColor = true;
            this.minutosdiferencia.Click += new System.EventHandler(this.minutosdiferencia_Click);
            // 
            // TestEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 235);
            this.Controls.Add(this.minutosdiferencia);
            this.Controls.Add(this.horasiguales);
            this.Controls.Add(this.comboact);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.copiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codBorrar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.diacombo);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.mfin);
            this.Controls.Add(this.hfin);
            this.Controls.Add(this.mini);
            this.Controls.Add(this.hini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestEN";
            this.Text = "Test de turnos";
            this.Load += new System.EventHandler(this.TestEN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hini;
        private System.Windows.Forms.TextBox mini;
        private System.Windows.Forms.TextBox hfin;
        private System.Windows.Forms.TextBox mfin;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.ComboBox diacombo;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.TextBox codBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button copiar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.ComboBox comboact;
        private System.Windows.Forms.Button horasiguales;
        private System.Windows.Forms.Button minutosdiferencia;
    }
}