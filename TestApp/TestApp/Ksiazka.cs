using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Ksiazka:Tekst
    {
        private string autor;
        private string tytul;

        public Ksiazka(string tresc, string autor, string tytul):base (tresc)
        {
            this.autor = autor;
            this.tytul = tytul;
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
            if (autor == "Stephen Prata")
            {
                wynik = (float)(IloscLiter() * 0.5);
                
            }
            else if (autor == "Jerzy Grebosz")
            {
                wynik = (float)(IloscLiter() * 0.7);
                
            }
            return wynik;
        }

        public override string ToString()
        {
            return $"Ksiazka {Id}, {Tresc}, {autor}, {tytul}";
        }
    }
}
