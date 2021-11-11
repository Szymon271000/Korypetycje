using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    class Autor
    {
        private string imie;
        private string nazwisko;

        public Autor(string imie, string nazwisko)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }

        public override string ToString()
        {
            return $"Auto nazywa sie {imie} {nazwisko}";
        }
    }
}
