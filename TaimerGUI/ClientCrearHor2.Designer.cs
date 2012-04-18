namespace TaimerGUI
{
    partial class ClientCrearHor2
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
            this.chkBxLunes = new System.Windows.Forms.CheckBox();
            this.chkBxMartes = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.grpBoxRestric = new System.Windows.Forms.GroupBox();
            this.groubBoxDias = new System.Windows.Forms.GroupBox();
            this.chkBxAll = new System.Windows.Forms.CheckBox();
            this.chkBoxDomingo = new System.Windows.Forms.CheckBox();
            this.chkBoxSabado = new System.Windows.Forms.CheckBox();
            this.chkBoxMiercoles = new System.Windows.Forms.CheckBox();
            this.chkBoxViernes = new System.Windows.Forms.CheckBox();
            this.chkBoxJueves = new System.Windows.Forms.CheckBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pnlHorario = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHoras = new System.Windows.Forms.Panel();
            this.pnlDomingo = new System.Windows.Forms.Panel();
            this.pnlSabado = new System.Windows.Forms.Panel();
            this.pnlViernes = new System.Windows.Forms.Panel();
            this.pnlJueves = new System.Windows.Forms.Panel();
            this.pnlMiercoles = new System.Windows.Forms.Panel();
            this.pnlMartes = new System.Windows.Forms.Panel();
            this.pnlLunes = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.grpBoxRestric.SuspendLayout();
            this.groubBoxDias.SuspendLayout();
            this.pnlHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Taimer - Crear horario";
            // 
            // chkBxLunes
            // 
            this.chkBxLunes.AutoSize = true;
            this.chkBxLunes.Location = new System.Drawing.Point(18, 40);
            this.chkBxLunes.Name = "chkBxLunes";
            this.chkBxLunes.Size = new System.Drawing.Size(55, 17);
            this.chkBxLunes.TabIndex = 23;
            this.chkBxLunes.Text = "Lunes";
            this.chkBxLunes.UseVisualStyleBackColor = true;
            // 
            // chkBxMartes
            // 
            this.chkBxMartes.AutoSize = true;
            this.chkBxMartes.Location = new System.Drawing.Point(18, 64);
            this.chkBxMartes.Name = "chkBxMartes";
            this.chkBxMartes.Size = new System.Drawing.Size(58, 17);
            this.chkBxMartes.TabIndex = 24;
            this.chkBxMartes.Text = "Martes";
            this.chkBxMartes.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(262, 136);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 17);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.Text = "Menos huecos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(262, 160);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 17);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Menos dias";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // grpBoxRestric
            // 
            this.grpBoxRestric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpBoxRestric.Controls.Add(this.groubBoxDias);
            this.grpBoxRestric.Controls.Add(this.radioButton1);
            this.grpBoxRestric.Controls.Add(this.radioButton2);
            this.grpBoxRestric.Location = new System.Drawing.Point(217, 112);
            this.grpBoxRestric.Name = "grpBoxRestric";
            this.grpBoxRestric.Size = new System.Drawing.Size(383, 351);
            this.grpBoxRestric.TabIndex = 30;
            this.grpBoxRestric.TabStop = false;
            this.grpBoxRestric.Text = "Restricciones";
            this.grpBoxRestric.Visible = false;
            // 
            // groubBoxDias
            // 
            this.groubBoxDias.Controls.Add(this.chkBxAll);
            this.groubBoxDias.Controls.Add(this.chkBxLunes);
            this.groubBoxDias.Controls.Add(this.chkBoxDomingo);
            this.groubBoxDias.Controls.Add(this.chkBxMartes);
            this.groubBoxDias.Controls.Add(this.chkBoxSabado);
            this.groubBoxDias.Controls.Add(this.chkBoxMiercoles);
            this.groubBoxDias.Controls.Add(this.chkBoxViernes);
            this.groubBoxDias.Controls.Add(this.chkBoxJueves);
            this.groubBoxDias.Enabled = false;
            this.groubBoxDias.Location = new System.Drawing.Point(60, 96);
            this.groubBoxDias.Name = "groubBoxDias";
            this.groubBoxDias.Size = new System.Drawing.Size(175, 117);
            this.groubBoxDias.TabIndex = 35;
            this.groubBoxDias.TabStop = false;
            this.groubBoxDias.Text = "Dias";
            // 
            // chkBxAll
            // 
            this.chkBxAll.AutoSize = true;
            this.chkBxAll.Location = new System.Drawing.Point(19, 17);
            this.chkBxAll.Name = "chkBxAll";
            this.chkBxAll.Size = new System.Drawing.Size(56, 17);
            this.chkBxAll.TabIndex = 35;
            this.chkBxAll.Text = "Todos";
            this.chkBxAll.UseVisualStyleBackColor = true;
            this.chkBxAll.CheckedChanged += new System.EventHandler(this.chkBxAll_CheckedChanged);
            // 
            // chkBoxDomingo
            // 
            this.chkBoxDomingo.AutoSize = true;
            this.chkBoxDomingo.Location = new System.Drawing.Point(105, 87);
            this.chkBoxDomingo.Name = "chkBoxDomingo";
            this.chkBoxDomingo.Size = new System.Drawing.Size(68, 17);
            this.chkBoxDomingo.TabIndex = 34;
            this.chkBoxDomingo.Text = "Domingo";
            this.chkBoxDomingo.UseVisualStyleBackColor = true;
            // 
            // chkBoxSabado
            // 
            this.chkBoxSabado.AutoSize = true;
            this.chkBoxSabado.Location = new System.Drawing.Point(105, 63);
            this.chkBoxSabado.Name = "chkBoxSabado";
            this.chkBoxSabado.Size = new System.Drawing.Size(63, 17);
            this.chkBoxSabado.TabIndex = 33;
            this.chkBoxSabado.Text = "Sabado";
            this.chkBoxSabado.UseVisualStyleBackColor = true;
            // 
            // chkBoxMiercoles
            // 
            this.chkBoxMiercoles.AutoSize = true;
            this.chkBoxMiercoles.Location = new System.Drawing.Point(18, 87);
            this.chkBoxMiercoles.Name = "chkBoxMiercoles";
            this.chkBoxMiercoles.Size = new System.Drawing.Size(71, 17);
            this.chkBoxMiercoles.TabIndex = 30;
            this.chkBoxMiercoles.Text = "Miercoles";
            this.chkBoxMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkBoxViernes
            // 
            this.chkBoxViernes.AutoSize = true;
            this.chkBoxViernes.Location = new System.Drawing.Point(105, 40);
            this.chkBoxViernes.Name = "chkBoxViernes";
            this.chkBoxViernes.Size = new System.Drawing.Size(61, 17);
            this.chkBoxViernes.TabIndex = 32;
            this.chkBoxViernes.Text = "Viernes";
            this.chkBoxViernes.UseVisualStyleBackColor = true;
            // 
            // chkBoxJueves
            // 
            this.chkBoxJueves.AutoSize = true;
            this.chkBoxJueves.Location = new System.Drawing.Point(105, 17);
            this.chkBoxJueves.Name = "chkBoxJueves";
            this.chkBoxJueves.Size = new System.Drawing.Size(60, 17);
            this.chkBoxJueves.TabIndex = 31;
            this.chkBoxJueves.Text = "Jueves";
            this.chkBoxJueves.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.Location = new System.Drawing.Point(630, 581);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(158, 52);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.Image = global::TaimerGUI.Properties.Resources.flechaLeft;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(12, 581);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(158, 52);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Volver";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlHorario
            // 
            this.pnlHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlHorario.AutoScroll = true;
            this.pnlHorario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHorario.BackColor = System.Drawing.Color.Maroon;
            this.pnlHorario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHorario.Controls.Add(this.label9);
            this.pnlHorario.Controls.Add(this.label8);
            this.pnlHorario.Controls.Add(this.label7);
            this.pnlHorario.Controls.Add(this.label6);
            this.pnlHorario.Controls.Add(this.label5);
            this.pnlHorario.Controls.Add(this.label4);
            this.pnlHorario.Controls.Add(this.label3);
            this.pnlHorario.Controls.Add(this.label2);
            this.pnlHorario.Controls.Add(this.pnlHoras);
            this.pnlHorario.Controls.Add(this.pnlDomingo);
            this.pnlHorario.Controls.Add(this.pnlSabado);
            this.pnlHorario.Controls.Add(this.pnlViernes);
            this.pnlHorario.Controls.Add(this.pnlJueves);
            this.pnlHorario.Controls.Add(this.pnlMiercoles);
            this.pnlHorario.Controls.Add(this.pnlMartes);
            this.pnlHorario.Controls.Add(this.pnlLunes);
            this.pnlHorario.Location = new System.Drawing.Point(12, 85);
            this.pnlHorario.Name = "pnlHorario";
            this.pnlHorario.Size = new System.Drawing.Size(771, 460);
            this.pnlHorario.TabIndex = 33;
            this.pnlHorario.Visible = false;
            this.pnlHorario.MouseEnter += new System.EventHandler(this.pnlHorario_MouseEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(658, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Domingo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(565, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sabado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(469, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Viernes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(375, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Jueves";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(275, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Miercoles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(182, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Martes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(94, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lunes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horas";
            // 
            // pnlHoras
            // 
            this.pnlHoras.BackColor = System.Drawing.Color.Maroon;
            this.pnlHoras.Location = new System.Drawing.Point(-1, 35);
            this.pnlHoras.Name = "pnlHoras";
            this.pnlHoras.Size = new System.Drawing.Size(61, 1460);
            this.pnlHoras.TabIndex = 1;
            // 
            // pnlDomingo
            // 
            this.pnlDomingo.BackColor = System.Drawing.Color.Snow;
            this.pnlDomingo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDomingo.Location = new System.Drawing.Point(640, 35);
            this.pnlDomingo.Name = "pnlDomingo";
            this.pnlDomingo.Size = new System.Drawing.Size(90, 1460);
            this.pnlDomingo.TabIndex = 1;
            // 
            // pnlSabado
            // 
            this.pnlSabado.BackColor = System.Drawing.Color.Snow;
            this.pnlSabado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSabado.Location = new System.Drawing.Point(544, 35);
            this.pnlSabado.Name = "pnlSabado";
            this.pnlSabado.Size = new System.Drawing.Size(90, 1460);
            this.pnlSabado.TabIndex = 1;
            // 
            // pnlViernes
            // 
            this.pnlViernes.BackColor = System.Drawing.Color.Snow;
            this.pnlViernes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViernes.Location = new System.Drawing.Point(448, 35);
            this.pnlViernes.Name = "pnlViernes";
            this.pnlViernes.Size = new System.Drawing.Size(90, 1460);
            this.pnlViernes.TabIndex = 1;
            // 
            // pnlJueves
            // 
            this.pnlJueves.BackColor = System.Drawing.Color.Snow;
            this.pnlJueves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJueves.Location = new System.Drawing.Point(352, 35);
            this.pnlJueves.Name = "pnlJueves";
            this.pnlJueves.Size = new System.Drawing.Size(90, 1460);
            this.pnlJueves.TabIndex = 1;
            // 
            // pnlMiercoles
            // 
            this.pnlMiercoles.BackColor = System.Drawing.Color.Snow;
            this.pnlMiercoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMiercoles.Location = new System.Drawing.Point(256, 35);
            this.pnlMiercoles.Name = "pnlMiercoles";
            this.pnlMiercoles.Size = new System.Drawing.Size(90, 1460);
            this.pnlMiercoles.TabIndex = 1;
            // 
            // pnlMartes
            // 
            this.pnlMartes.BackColor = System.Drawing.Color.Snow;
            this.pnlMartes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMartes.Location = new System.Drawing.Point(160, 35);
            this.pnlMartes.Name = "pnlMartes";
            this.pnlMartes.Size = new System.Drawing.Size(90, 1460);
            this.pnlMartes.TabIndex = 1;
            // 
            // pnlLunes
            // 
            this.pnlLunes.BackColor = System.Drawing.Color.Snow;
            this.pnlLunes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLunes.Location = new System.Drawing.Point(65, 35);
            this.pnlLunes.Name = "pnlLunes";
            this.pnlLunes.Size = new System.Drawing.Size(90, 1460);
            this.pnlLunes.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(630, 581);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(151, 52);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Selecciona tus preferencias sobre el horario y crealo.";
            // 
            // btnDescartar
            // 
            this.btnDescartar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDescartar.Location = new System.Drawing.Point(28, 581);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(156, 52);
            this.btnDescartar.TabIndex = 3;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Visible = false;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // ClientCrearHor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 666);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.grpBoxRestric);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlHorario);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientCrearHor2";
            this.Text = "ClientCrearHor2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ClientCrearHor2_Activated);
            this.Load += new System.EventHandler(this.ClientCrearHor2_Load);
            this.grpBoxRestric.ResumeLayout(false);
            this.grpBoxRestric.PerformLayout();
            this.groubBoxDias.ResumeLayout(false);
            this.groubBoxDias.PerformLayout();
            this.pnlHorario.ResumeLayout(false);
            this.pnlHorario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBxLunes;
        private System.Windows.Forms.CheckBox chkBxMartes;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox grpBoxRestric;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.CheckBox chkBoxDomingo;
        private System.Windows.Forms.CheckBox chkBoxSabado;
        private System.Windows.Forms.CheckBox chkBoxViernes;
        private System.Windows.Forms.CheckBox chkBoxJueves;
        private System.Windows.Forms.CheckBox chkBoxMiercoles;
        private System.Windows.Forms.GroupBox groubBoxDias;
        private System.Windows.Forms.CheckBox chkBxAll;
        private System.Windows.Forms.Panel pnlHorario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlHoras;
        private System.Windows.Forms.Panel pnlDomingo;
        private System.Windows.Forms.Panel pnlSabado;
        private System.Windows.Forms.Panel pnlViernes;
        private System.Windows.Forms.Panel pnlJueves;
        private System.Windows.Forms.Panel pnlMiercoles;
        private System.Windows.Forms.Panel pnlMartes;
        private System.Windows.Forms.Panel pnlLunes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDescartar;
    }
}