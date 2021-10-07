using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja07._10
{
    class Czlowiek
    {
        protected string imie; //protected jest do klas dziedziczacyh
        protected string nazwisko;
        protected int wiek;
        protected string oddzial;

        public Czlowiek(string imie, string nazwisko, int wiek, string oddzial)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.oddzial = oddzial;
        }

        public override string ToString()
        {
            return $"Ma na imie {imie}, jego nazwisko jest {nazwisko}, ma {wiek} lat i jest na odzziale {oddzial}";
        }
    }
}
