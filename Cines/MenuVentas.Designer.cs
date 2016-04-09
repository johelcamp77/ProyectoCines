namespace Cines
{
    partial class MenuVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVentas));
            this.NuevaBtn = new System.Windows.Forms.Button();
            this.ViejaBtn = new System.Windows.Forms.Button();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.PuntoVentaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NuevaBtn
            // 
            this.NuevaBtn.Location = new System.Drawing.Point(67, 181);
            this.NuevaBtn.Name = "NuevaBtn";
            this.NuevaBtn.Size = new System.Drawing.Size(102, 23);
            this.NuevaBtn.TabIndex = 0;
            this.NuevaBtn.Text = "Máquina Nueva";
            this.NuevaBtn.UseVisualStyleBackColor = true;
            // 
            // ViejaBtn
            // 
            this.ViejaBtn.Location = new System.Drawing.Point(175, 181);
            this.ViejaBtn.Name = "ViejaBtn";
            this.ViejaBtn.Size = new System.Drawing.Size(102, 23);
            this.ViejaBtn.TabIndex = 1;
            this.ViejaBtn.Text = "Máquina Vieja";
            this.ViejaBtn.UseVisualStyleBackColor = true;
            this.ViejaBtn.Click += new System.EventHandler(this.ViejaBtn_Click);
            // 
            // VolverBtn
            // 
            this.VolverBtn.Location = new System.Drawing.Point(12, 327);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(75, 23);
            this.VolverBtn.TabIndex = 2;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // PuntoVentaBtn
            // 
            this.PuntoVentaBtn.Location = new System.Drawing.Point(283, 181);
            this.PuntoVentaBtn.Name = "PuntoVentaBtn";
            this.PuntoVentaBtn.Size = new System.Drawing.Size(102, 23);
            this.PuntoVentaBtn.TabIndex = 3;
            this.PuntoVentaBtn.Text = "Punto de Venta";
            this.PuntoVentaBtn.UseVisualStyleBackColor = true;
            this.PuntoVentaBtn.Click += new System.EventHandler(this.PuntoVentaBtn_Click);
            // 
            // MenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cines.Properties.Resources.Fondo_Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.PuntoVentaBtn);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.ViejaBtn);
            this.Controls.Add(this.NuevaBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuVentas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NuevaBtn;
        private System.Windows.Forms.Button ViejaBtn;
        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.Button PuntoVentaBtn;
    }
}