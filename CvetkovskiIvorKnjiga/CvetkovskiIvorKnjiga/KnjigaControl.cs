using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvetkovskiIvorKnjiga
{
    class KnjigaControl 
    {
        List<Poglavlje> popisPoglavlja = new List<Poglavlje>();
        int max = 0;
        int min = 0;

        public void dodajPoglavlje(Poglavlje objekt)
        {
            Poglavlje poglavlje = new Poglavlje(objekt.getNazivPoglavlja(), objekt.getBrojStranice());

            popisPoglavlja.Add(poglavlje);
        }

        public string ispisiPoglavlja()
        {
            string ispis = "Poglavlje knjige: \n";

            foreach (Poglavlje poglavlje in popisPoglavlja)
            {
                ispis = ispis + "Naziv poglavlja" + poglavlje.getNazivPoglavlja() + 
                    "\n Broj stranica: " + poglavlje.getBrojStranice();
                
            }
            return ispis;
        }

        public string ispisiUkupanBrojStranica()
        {
            int total = 0;

            foreach(Poglavlje poglavlje in popisPoglavlja)
            {
                total = total + poglavlje.getBrojStranice();
            }

            return "Ukupan broj stranica knjige je: " + total;
        }

        public string ispisiNajvecePoglavlje()
        {
            string najvecePoglavlje = "";
            foreach(Poglavlje poglavlje in popisPoglavlja)
            {
                if (poglavlje.getBrojStranice() > max)
                {
                    max = poglavlje.getBrojStranice();
                    najvecePoglavlje = poglavlje.getNazivPoglavlja();
                }
            }
            return "Najvece poglavlje je: " + najvecePoglavlje;
        }

        public string ispisiNajmanjePoglavlje()
        {
            foreach (Poglavlje poglavlje in popisPoglavlja)
            {
                if (poglavlje.getBrojStranice() > max)
                {
                    max = poglavlje.getBrojStranice();
                }
            }

            min = max;

            string najmanjePoglavlje = "";

            foreach (Poglavlje poglavlje in popisPoglavlja)
            {
                if (poglavlje.getBrojStranice() < min)
                {
                    min = poglavlje.getBrojStranice();
                    najmanjePoglavlje = poglavlje.getNazivPoglavlja();
                }
            }
            return "Najvece poglavlje je: " + najmanjePoglavlje;
        }
    }
}