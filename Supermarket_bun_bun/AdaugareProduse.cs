using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Administrare_produs;
using LibrarieClase;


namespace Supermarket_bun_bun
{
    public partial class AdaugareProduse : Form
    {

        private const int LUNGIME_MAXIMA = 20;
        public  DateTime temp;

        private Administrare_produs_FisierText adminProduse;

        public AdaugareProduse()
        {

            string numeFisierProduse = ConfigurationManager.AppSettings["produs"];
            string locatieFisierProduse1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            string caleCompletaProduse1 = locatieFisierProduse1 + "\\" + numeFisierProduse;
            adminProduse = new Administrare_produs_FisierText(caleCompletaProduse1);

            InitializeComponent();
        }

        private void Inapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            Supermarket supermarket = new Supermarket();
            supermarket.Show();

        }
        
        private void Adauga_Click(object sender, EventArgs e)
       
        {
            bool ok = false;

            
            if (NumeProdus.Text == "" || NumeProdus.Text.Length > LUNGIME_MAXIMA)
            {
                ok = false;
                
            }else 
            {
                ok = true;
            }

            if (tipProdus.Text == "")
            {
                ok = false;
                
                
            }
            else
            {
                ok = true;
            }

            if (DateTime.TryParse(Expirare.Text, out temp)  )
            {
                ok = true;

               
            }
            else
            {
                ok = false;
            }


            if (ok == true)
            {
                Produs produs = new Produs();
                produs.nume_produs = NumeProdus.Text;
                produs.tip = tipProdus.Text;
                produs.data_expirare = Expirare.Text;
                adminProduse.AddProdus(produs);

            }
            else MessageBox.Show("Campuri invalide!");
            

            
            
        }

        private void AdaugareProduse_Load(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumeProdus_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            NumeProdus.Clear();
            tipProdus.ResetText();
            Expirare.Clear();
        }
    }
}
