namespace rubenDesign
{
    partial class Client
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
            this.buttonExitClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExitClient
            // 
            this.buttonExitClient.Location = new System.Drawing.Point(197, 12);
            this.buttonExitClient.Name = "buttonExitClient";
            this.buttonExitClient.Size = new System.Drawing.Size(75, 23);
            this.buttonExitClient.TabIndex = 1;
            this.buttonExitClient.Text = "Salir";
            this.buttonExitClient.UseVisualStyleBackColor = true;
            this.buttonExitClient.Click += new System.EventHandler(this.buttonExitClient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExitClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.Text = "Cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExitClient;
        private System.Windows.Forms.Button button1;
    }
}