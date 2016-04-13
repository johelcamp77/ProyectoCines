namespace Cines
{
    partial class Cobro
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
            this.TarjetaLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.PlataLbl = new System.Windows.Forms.Label();
            this.PagarLbl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TarjetaLbl
            // 
            this.TarjetaLbl.AutoSize = true;
            this.TarjetaLbl.Location = new System.Drawing.Point(58, 198);
            this.TarjetaLbl.Name = "TarjetaLbl";
            this.TarjetaLbl.Size = new System.Drawing.Size(119, 13);
            this.TarjetaLbl.TabIndex = 0;
            this.TarjetaLbl.Text = "Digite el # de su tarjeta:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 1;
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Location = new System.Drawing.Point(100, 141);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(74, 13);
            this.TotalLbl.TabIndex = 2;
            this.TotalLbl.Text = "Total a Pagar:";
            // 
            // PlataLbl
            // 
            this.PlataLbl.AutoSize = true;
            this.PlataLbl.Location = new System.Drawing.Point(194, 141);
            this.PlataLbl.Name = "PlataLbl";
            this.PlataLbl.Size = new System.Drawing.Size(0, 13);
            this.PlataLbl.TabIndex = 3;
            // 
            // PagarLbl
            // 
            this.PagarLbl.Location = new System.Drawing.Point(326, 315);
            this.PagarLbl.Name = "PagarLbl";
            this.PagarLbl.Size = new System.Drawing.Size(75, 23);
            this.PagarLbl.TabIndex = 4;
            this.PagarLbl.Text = "Pagar";
            this.PagarLbl.UseVisualStyleBackColor = true;
            this.PagarLbl.Click += new System.EventHandler(this.PagarLbl_Click);
            // 
            // Cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cines.Properties.Resources.Fondo_Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(425, 350);
            this.Controls.Add(this.PagarLbl);
            this.Controls.Add(this.PlataLbl);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TarjetaLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TarjetaLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label PlataLbl;
        private System.Windows.Forms.Button PagarLbl;
    }
}