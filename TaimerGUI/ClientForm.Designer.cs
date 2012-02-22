namespace TaimerGUI {
    partial class ClientForm {
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panGenerarHorario = new System.Windows.Forms.Panel();
            this.lbGenerarHorario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panGenerarHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panGenerarHorario);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(1206, 576);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // panGenerarHorario
            // 
            this.panGenerarHorario.Controls.Add(this.lbGenerarHorario);
            this.panGenerarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panGenerarHorario.Location = new System.Drawing.Point(3, 2);
            this.panGenerarHorario.Name = "panGenerarHorario";
            this.panGenerarHorario.Size = new System.Drawing.Size(288, 214);
            this.panGenerarHorario.TabIndex = 0;
            // 
            // lbGenerarHorario
            // 
            this.lbGenerarHorario.AutoSize = true;
            this.lbGenerarHorario.Location = new System.Drawing.Point(88, 97);
            this.lbGenerarHorario.Name = "lbGenerarHorario";
            this.lbGenerarHorario.Size = new System.Drawing.Size(82, 13);
            this.lbGenerarHorario.TabIndex = 0;
            this.lbGenerarHorario.Text = "Generar Horario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Botón de pánico!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 576);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panGenerarHorario.ResumeLayout(false);
            this.panGenerarHorario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panGenerarHorario;
        private System.Windows.Forms.Label lbGenerarHorario;
        private System.Windows.Forms.Button button1;
    }
}