using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public enum Rodzaj
    {
        stroficzny,
        stychiczny,
        bialy,
        sylabiczny
    }
    class Wiersz: Tekst
    {
        private Rodzaj rodzaj;

        public Wiersz(string tresc, Rodzaj rodzaj): base (tresc)
        {
            this.rodzaj = rodzaj;
        }
        public override float ObliczWartosc()
        {
            float wynik = 0;
            if (rodzaj == Rodzaj.sylabiczny)
            {
                wynik = (float)(IloscLiter() * 3);
            }
            else
            {
                wynik = (float)(IloscLiter() * 3.5);
            }

            return wynik;

        }
        public override string ToString()
        {
            return $"{Id}, {Tresc}, {rodzaj}";
        }
    }
}
