namespace Cines
{
    partial class PuntoVenta
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
            this.comboPelicula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboIdioma = new System.Windows.Forms.ComboBox();
            this.comboSala = new System.Windows.Forms.ComboBox();
            this.comboSalaNumero = new System.Windows.Forms.ComboBox();
            this.comboHorario = new System.Windows.Forms.ComboBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.comboDuracion = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboPelicula
            // 
            this.comboPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPelicula.FormattingEnabled = true;
            this.comboPelicula.Location = new System.Drawing.Point(90, 12);
            this.comboPelicula.Name = "comboPelicula";
            this.comboPelicula.Size = new System.Drawing.Size(121, 21);
            this.comboPelicula.TabIndex = 0;
            this.comboPelicula.SelectedIndexChanged += new System.EventHandler(this.comboPelicula_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Película";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idioma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Duración";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Horario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sala número";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sala";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboIdioma
            // 
            this.comboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIdioma.FormattingEnabled = true;
            this.comboIdioma.Location = new System.Drawing.Point(90, 46);
            this.comboIdioma.Name = "comboIdioma";
            this.comboIdioma.Size = new System.Drawing.Size(121, 21);
            this.comboIdioma.TabIndex = 9;
            // 
            // comboSala
            // 
            this.comboSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSala.FormattingEnabled = true;
            this.comboSala.Location = new System.Drawing.Point(90, 78);
            this.comboSala.Name = "comboSala";
            this.comboSala.Size = new System.Drawing.Size(121, 21);
            this.comboSala.TabIndex = 10;
            // 
            // comboSalaNumero
            // 
            this.comboSalaNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSalaNumero.FormattingEnabled = true;
            this.comboSalaNumero.Location = new System.Drawing.Point(90, 107);
            this.comboSalaNumero.Name = "comboSalaNumero";
            this.comboSalaNumero.Size = new System.Drawing.Size(121, 21);
            this.comboSalaNumero.TabIndex = 11;
            // 
            // comboHorario
            // 
            this.comboHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHorario.FormattingEnabled = true;
            this.comboHorario.Location = new System.Drawing.Point(90, 137);
            this.comboHorario.Name = "comboHorario";
            this.comboHorario.Size = new System.Drawing.Size(121, 21);
            this.comboHorario.TabIndex = 12;
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(90, 176);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboCategoria.TabIndex = 13;
            // 
            // comboDuracion
            // 
            this.comboDuracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDuracion.FormattingEnabled = true;
            this.comboDuracion.Location = new System.Drawing.Point(90, 208);
            this.comboDuracion.Name = "comboDuracion";
            this.comboDuracion.Size = new System.Drawing.Size(121, 21);
            this.comboDuracion.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(217, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // PuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 261);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboDuracion);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.comboHorario);
            this.Controls.Add(this.comboSalaNumero);
            this.Controls.Add(this.comboSala);
            this.Controls.Add(this.comboIdioma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPelicula);
            this.Name = "PuntoVenta";
            this.Text = "PuntoVenta";
            this.Load += new System.EventHandler(this.PuntoVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboIdioma;
        private System.Windows.Forms.ComboBox comboSala;
        private System.Windows.Forms.ComboBox comboSalaNumero;
        private System.Windows.Forms.ComboBox comboHorario;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.ComboBox comboDuracion;
        private System.Windows.Forms.Button btnBuscar;
    }
}