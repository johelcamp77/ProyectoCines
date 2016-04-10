using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace Cines
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread mostraCartelera = new Thread(() =>
            {
                //Instanciar ventanas de la cartelera
                
                Cartelera1 cartel1 = new Cartelera1();
                Cartelera2 cartel2 = new Cartelera2();
                Cartelera3 cartel3 = new Cartelera3();
                cartel1.Show();
                cartel2.Show();
                cartel3.Show();
                Application.Run(cartel1);

            });
            mostraCartelera.SetApartmentState(ApartmentState.STA);
            mostraCartelera.Start();

            //frm1 = new Form1();



        }

        private void Cartel1_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void VentaBtn_Click(object sender, EventArgs e)
        {
            MenuVentas MenuVentas = new MenuVentas();
            MenuVentas.Show();

        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
