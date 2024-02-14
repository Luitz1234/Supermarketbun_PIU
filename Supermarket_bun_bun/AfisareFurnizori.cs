using Administrare_produs;
using LibrarieClase;
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

namespace Supermarket_bun_bun
{
    public partial class AfisareFurnizori : Form
    {
        private Administrare_furnizor_FisierText adminFurnizori;
        public AfisareFurnizori()
        {

            string numeFisierFurnizori = ConfigurationManager.AppSettings["furnizor"];
            string locatieFisierFurnizori1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            string caleCompletaFurnizori1 = locatieFisierFurnizori1 + "\\" + numeFisierFurnizori;
            adminFurnizori = new Administrare_furnizor_FisierText(caleCompletaFurnizori1);

            InitializeComponent();
            AfisareGridView();
        }


        public void AfisareGridView()
        {
            Furnizori[] furnizor = adminFurnizori.GetFurnizori(out int nrFurnizori);
            int ID = 0;
            for (int i = 0; i < nrFurnizori; i++)
            {
                ID = ID + 1;
                dataGridView1.Rows.Add( ID, furnizor[i].nume_furnizori, furnizor[i].adresa_furnizori, furnizor[i].numar_telefon);

            }

        }




        private void AfisareFurnizori_Load(object sender, EventArgs e)
        {

        }

        private void InapoiAfisF_Click(object sender, EventArgs e)
        {
            this.Close();
            Supermarket supermarket = new Supermarket();
            supermarket.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
