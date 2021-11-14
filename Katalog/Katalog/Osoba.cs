using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    class Osoba
    {
        private string imie;
        private string nazwisko;

        public Osoba(string imie, string nazwisko)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }

        public override string ToString()
        {
            return $"Osoba nazywa sie: {imie} {nazwisko}";
        }
    }
}
