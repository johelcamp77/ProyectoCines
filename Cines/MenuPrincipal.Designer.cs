namespace Cines
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnCartelera = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCartelera
            // 
            this.btnCartelera.Location = new System.Drawing.Point(187, 109);
            this.btnCartelera.Name = "btnCartelera";
            this.btnCartelera.Size = new System.Drawing.Size(100, 27);
            this.btnCartelera.TabIndex = 0;
            this.btnCartelera.Text = "Cartelera";
            this.btnCartelera.UseVisualStyleBackColor = true;
            this.btnCartelera.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(187, 160);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(100, 23);
            this.btnVenta.TabIndex = 1;
            this.btnVenta.Text = "Venta de Boletos";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.VentaBtn_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(187, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.salirbtn_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Location = new System.Drawing.Point(187, 200);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(100, 27);
            this.btnAdministrador.TabIndex = 3;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cines.Properties.Resources.Fondo_Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnCartelera);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cines JJ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCartelera;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAdministrador;
    }
}

