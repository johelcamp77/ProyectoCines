﻿namespace Cines
{
    partial class Cartelera1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NombreLbl = new System.Windows.Forms.Label();
            this.IdiomaLbl = new System.Windows.Forms.Label();
            this.SalaLbl = new System.Windows.Forms.Label();
            this.HorarioLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(221, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(34, 20);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sencilla";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(9, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.BackColor = System.Drawing.Color.Transparent;
            this.NombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NombreLbl.Location = new System.Drawing.Point(12, 49);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(65, 20);
            this.NombreLbl.TabIndex = 3;
            this.NombreLbl.Text = "Nombre";
            // 
            // IdiomaLbl
            // 
            this.IdiomaLbl.AutoSize = true;
            this.IdiomaLbl.BackColor = System.Drawing.Color.Transparent;
            this.IdiomaLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IdiomaLbl.Location = new System.Drawing.Point(113, 78);
            this.IdiomaLbl.Name = "IdiomaLbl";
            this.IdiomaLbl.Size = new System.Drawing.Size(38, 13);
            this.IdiomaLbl.TabIndex = 5;
            this.IdiomaLbl.Text = "Idioma";
            // 
            // SalaLbl
            // 
            this.SalaLbl.AutoSize = true;
            this.SalaLbl.BackColor = System.Drawing.Color.Transparent;
            this.SalaLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalaLbl.Location = new System.Drawing.Point(13, 78);
            this.SalaLbl.Name = "SalaLbl";
            this.SalaLbl.Size = new System.Drawing.Size(28, 13);
            this.SalaLbl.TabIndex = 6;
            this.SalaLbl.Text = "Sala";
            // 
            // HorarioLbl
            // 
            this.HorarioLbl.AutoSize = true;
            this.HorarioLbl.BackColor = System.Drawing.Color.Transparent;
            this.HorarioLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HorarioLbl.Location = new System.Drawing.Point(218, 78);
            this.HorarioLbl.Name = "HorarioLbl";
            this.HorarioLbl.Size = new System.Drawing.Size(41, 13);
            this.HorarioLbl.TabIndex = 7;
            this.HorarioLbl.Text = "Horario";
            // 
            // Cartelera1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Cines.Properties.Resources.fondo_gris_de_lineas_1053_300;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.HorarioLbl);
            this.Controls.Add(this.SalaLbl);
            this.Controls.Add(this.IdiomaLbl);
            this.Controls.Add(this.NombreLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cartelera1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cartelera1";
            this.Load += new System.EventHandler(this.Cartelera1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.Label IdiomaLbl;
        private System.Windows.Forms.Label SalaLbl;
        private System.Windows.Forms.Label HorarioLbl;
    }
}