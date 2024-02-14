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
using LibrarieClase;
using Administrare_produs;


namespace Supermarket_bun_bun
{
    public partial class CautareProdus : Form
    {

        private Administrare_produs_FisierText adminProduse;
        public CautareProdus()

        {
            string numeFisierProduse = ConfigurationManager.AppSettings["produs"];
            string locatieFisierProduse1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            string caleCompletaProduse1 = locatieFisierProduse1 + "\\" + numeFisierProduse;
            adminProduse = new Administrare_produs_FisierText(caleCompletaProduse1);


            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cauta_Click(object sender, EventArgs e)
        {
            Produs[] produse = adminProduse.GetProduse(out int nrProduse);
            int ok = 0;

            if (CautareCombo.SelectedItem != null)
            {
                if (CautareCombo.SelectedItem.ToString() == "Nume")
                {
                    for (int i = 0; i < nrProduse; i++)

                    {
                        if (produse[i].Get_nume() == TexCauta.Text)
                        {
                            dataGridView1.Rows.Add(produse[i].GetIdProdus(), produse[i].nume_produs, produse[i].tip, produse[i].data_expirare);
                            ok = 1;

                        }

                    }
                }
                else if (CautareCombo.SelectedItem.ToString() == "Tip")
                {
                    for (int i = 0; i < nrProduse; i++)

                    {
                        if (produse[i].tip == TexCauta.Text)
                        {
                            dataGridView1.Rows.Add(produse[i].GetIdProdus(), produse[i].nume_produs, produse[i].tip, produse[i].data_expirare);
                            ok = 1;

                        }

                    }
                }
                else if (CautareCombo.SelectedItem.ToString() == "Data expirare")
                {
                    for (int i = 0; i < nrProduse; i++)

                    {
                        if (produse[i].data_expirare == TexCauta.Text && Convert.ToDateTime(produse[i].data_expirare) > DateTime.Now)
                        {
                            dataGridView1.Rows.Add(produse[i].GetIdProdus(), produse[i].nume_produs, produse[i].tip, produse[i].data_expirare);
                            ok = 1;

                        }

                    }
                }
                if (ok == 0)
                {
                    MessageBox.Show("Nu am gasit produsul cautat!");
                }


            }
            else MessageBox.Show("Introduceti o varianta in campul de mai sus!");
        } 

    private void Inapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            Supermarket supermarket = new Supermarket();
            supermarket.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            CautareCombo.ResetText();
            TexCauta.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }



}

