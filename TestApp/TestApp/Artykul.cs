using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Artykul: Tekst
    {
        private DateTime dataWydania;
        private string nazwaCzasopisma;

        public Artykul(string tresc, DateTime dataWydania, string nazwaCzasopisma): base (tresc)
        {
            this.dataWydania = dataWydania;
            this.nazwaCzasopisma = nazwaCzasopisma;
        }
        public int IloscLiter()
        {
            int ilosc = 0;
            foreach (char letter in Tresc)
            {
                if (char.IsLetter(letter))
                {
                    ilosc++;
                }
            }
            return ilosc;
        }
        public override float ObliczWartosc()
        {
            float wynik = 0;
            if (DateTime.Now.Year - dataWydania.Year < 6)
            {
                wynik = (float)(IloscLiter() * 0.1);
            }
            else if ((DateTime.Now.Year - dataWydania.Year > 6) && (nazwaCzasopisma != "Gazeta Polska"))
            {
                wynik = (float)(IloscLiter() * 0.2);
            }
            else
            {
                wynik = 0;
            }
            return wynik;
        }

        public override string ToString()
        {
            return $"Artykul {Id}, {Tresc}, {dataWydania}, {nazwaCzasopisma}";
        }
    }
}
