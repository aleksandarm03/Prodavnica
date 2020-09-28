using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Proizvod
    {
        #region atributi
        private string naziv, proizvodjac;
        private double cena;
        #endregion

        #region konstruktori
        public Proizvod(string naziv, string proizvodjac, double cena)
        {
            if (naziv.Equals(string.Empty))
                throw new Exception("Nema naziv!");
            else if (proizvodjac.Equals(string.Empty))
                throw new Exception("Nema proizvodjaca!");
            else if (cena < 0)
                throw new Exception("Cena<0!");
            else
            {
                this.naziv = naziv;
                this.proizvodjac = proizvodjac;
                this.cena = cena;
            }
        }

        public Proizvod(string naziv, string proizvodjac)
        {
            if (naziv.Equals(string.Empty))
                throw new Exception("Nema naziv!");
            else if (proizvodjac.Equals(string.Empty))
                throw new Exception("Nema proizvodjaca!");
            else
            {
                this.naziv = naziv;
                this.proizvodjac = proizvodjac;
                this.cena = 0;
            }
        }
        

        #endregion

        #region metode
        public bool SkupljiOd(Proizvod p)
        {
            if (cena > p.cena) return true;
            else return false;
            //return cena > p.cena;
        }

        public void PromeniCenu(double novaCena)
        {
            if (novaCena < 0)
                throw new Exception("Cena<0!");
            else
                this.cena = novaCena;
        }

        public string Prikaz()
        {
            return naziv + ", " + proizvodjac + " - " + cena + "RSD";
        }
        #endregion
    }

}
