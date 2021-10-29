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

        public override float ObliczWartosc()
        {
            float wynik;
            if (autor == "Stephen Prata" || autor == "Jerzy Grebosz")
            {
                wynik = (float)(IloscLiter() * 0.7);
                
            }
            else
            {
                wynik = (float)(IloscLiter() * 0.5);
                
            }
            return wynik;
        }

        public override string ToString()
        {
            return $"Ksiazka {Id}, {Tresc}, {autor}, {tytul}";
        }
    }
}
