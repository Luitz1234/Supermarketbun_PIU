﻿using System;
using System.IO;
using LibrarieClase;

namespace Administrare_produs
{
    public class Administrare_produs_FisierText
    {
        private const int NR_MAX_PRODUSE = 50;
        private string numeFisier;

        public Administrare_produs_FisierText(string numeFisier)
        {

            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();

        }

        public void AddProdus(Produs produs)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(produs.ConversieLaSir_PentruFisier());
            }
        }

        public Produs[] GetProduse(out int nrProduse)
        {
            Produs[] produse = new Produs[NR_MAX_PRODUSE];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrProduse = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    produse[nrProduse++] = new Produs(linieFisier);
                }
            }
            return produse;
        }
    }
}

