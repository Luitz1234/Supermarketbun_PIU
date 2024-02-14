using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_bun_bun
{
    public partial class Supermarket : Form
    {
        public Supermarket()
        {
            InitializeComponent();
        }

        private void Supermarket_Load(object sender, EventArgs e)
        {

        }

        private void adaugare_produse_Click(object sender, EventArgs e)
        {
            AdaugareProduse adauga = new AdaugareProduse();
            adauga.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void afisare_produse_Click(object sender, EventArgs e)
        {
            this.Close();
            AfisareProduse afisare = new AfisareProduse();
            afisare.Show();

            
        }

        private void cautare_produse_Click(object sender, EventArgs e)
        {
            this.Close();
            CautareProdus cautare = new CautareProdus();
            cautare.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdaugareFurnizor adFurnizor = new AdaugareFurnizor();
            adFurnizor.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AfisareFurnizori afisF = new AfisareFurnizori();
            afisF.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
