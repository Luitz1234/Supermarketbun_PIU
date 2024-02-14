using System;
using System.IO;
using LibrarieClase;

namespace Administrare_produs
{
    public class Administrare_furnizor_FisierText
    {
        private const int NR_MAX_FURNIZORI = 50;
        private string numeFisier;

        public Administrare_furnizor_FisierText(string numeFisier)
        {

            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();

        }

        public void AddFurnizor(Furnizori furnizor)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(furnizor.ConversieLaSir_PentruFisier());
            }
        }

        public Furnizori[] GetFurnizori(out int nrFurnizori)
        {
            Furnizori[] furnizori= new Furnizori[NR_MAX_FURNIZORI];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrFurnizori = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    furnizori[nrFurnizori++] = new Furnizori(linieFisier);
                }
            }
            return furnizori;
        }
    }
}


