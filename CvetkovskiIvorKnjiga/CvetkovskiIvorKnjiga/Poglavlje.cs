using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvetkovskiIvorKnjiga
{
    class Poglavlje
    {
        private string nazivPoglavlja;
        private int brojStranice, ukupanBrojStanica;

        public void setNazivPoglavlja(string imePoglavlja)
        {
            nazivPoglavlja = imePoglavlja;
        }

        public void setBrojStranice (int brojStranice)
        {
            this.brojStranice = brojStranice;
        }


        public void setUkupanBrojStranica (int totalStranica)
        {
            ukupanBrojStanica = totalStranica;
        }

        public string getNazivPoglavlja()
        {
            return nazivPoglavlja;
        }

        public int getBrojStranice()
        {
            return brojStranice;
        }

        public int getUkupanBrojStranica()
        {
            return ukupanBrojStanica;
        }
       
        public Poglavlje(string naziv, int broj)
        {
            nazivPoglavlja = naziv;
            brojStranice = broj;
        }

        
    }
}
