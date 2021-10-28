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
        private string rodzaj;

        public Wiersz(string tresc, Rodzaj rodzaj): base (tresc)
        {
           
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
            if (rodzaj == "sylabiczny")
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
