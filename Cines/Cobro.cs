using System;
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
    public partial class Cobro : Form
    {
        public Cobro()
        {
            InitializeComponent();
            double Plata = AsientosMaquinaNuevaIMAX.Pago;
            PlataLbl.Text=Convert.ToString(Plata);
        }

        private void PagarLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transacción Realizada");
            Dispose();
            AsientosMaquinaNuevaIMAX.Pago = 0;
        }
    }
}
