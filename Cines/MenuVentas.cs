﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cines
{
    public partial class MenuVentas : Form
    {
        public MenuVentas()
        {
            InitializeComponent();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            
            Dispose();
            
            
        }

        private void PuntoVentaBtn_Click(object sender, EventArgs e)
        {
            PuntoVentaUsuario puntoVenta = new PuntoVentaUsuario();
            puntoVenta.Show();
        }
    }
}
