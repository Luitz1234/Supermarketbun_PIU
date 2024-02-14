using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administrare_produs;
using LibrarieClase;


namespace Supermarket_bun_bun
{
    public partial class AdaugareFurnizor : Form
    {

        private Administrare_furnizor_FisierText adminFurnizori;
        public AdaugareFurnizor()
        {

            string numeFisierFurnizori = ConfigurationManager.AppSettings["furnizor"];
            string locatieFisierFurnizori1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            string caleCompletaFurnizori1 = locatieFisierFurnizori1 + "\\" + numeFisierFurnizori;
            adminFurnizori = new Administrare_furnizor_FisierText(caleCompletaFurnizori1);

            InitializeComponent();
        }

        private void InapoiF_Click(object sender, EventArgs e)
        {
            this.Close();
            Supermarket supermarket = new Supermarket();
            supermarket.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Furnizori furnizor = new Furnizori();
            furnizor.nume_furnizori = numeFurnizor.Text;
            furnizor.adresa_furnizori = adresaFurnizor.Text;
            furnizor.numar_telefon = numarFurnizor.Text;
            adminFurnizori.AddFurnizor(furnizor);
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            numeFurnizor.Clear();
            adresaFurnizor.Clear();
            numarFurnizor.Clear();
        }
    }
}
