using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieClase;
using Administrare_produs;
using System.IO;

namespace Supermarket_bun_bun
{
    public partial class AfisareProduse : Form

    {
        private Administrare_produs_FisierText adminProduse;


        public AfisareProduse()
        {
            string numeFisierProduse = System.Configuration.ConfigurationManager.AppSettings["produs"];
            string locatieFisierProduse1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            string caleCompletaProduse1 = locatieFisierProduse1 + "\\" + numeFisierProduse;
            adminProduse = new Administrare_produs_FisierText(caleCompletaProduse1);


            InitializeComponent();
            AfisareGridView();
        }

        public  void AfisareGridView()
        {
            Produs[] produs = adminProduse.GetProduse(out int nrProduse);
            int ID = 0;
            for (int i = 0; i<nrProduse;i++)
            {
                ID = ID + 1;
                dataGridView1.Rows.Add( ID, produs[i].nume_produs, produs[i].tip, produs[i].data_expirare);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Supermarket supermarket = new Supermarket();
            supermarket.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AfisareProduse_Load(object sender, EventArgs e)
        {

        }
    }
}
