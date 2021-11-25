using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacjenciZLINQ
{
    class Pacjent
    {
        private string imie;
        private string nazwisko;
        private string pesel;
        private string numerUbezpieczenia;
        private int wiek;

        public Pacjent(string imie, string nazwisko, string pesel, string numerUbezpieczenia, int wiek)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Pesel = pesel;
            this.NumerUbezpieczenia = numerUbezpieczenia;
            this.Wiek = wiek;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Pesel { get => pesel; 
            set 
            { if (value.Length == 11)
                {
                    value = pesel;
                } 
            } 
        }
        public string NumerUbezpieczenia { get => numerUbezpieczenia; set => numerUbezpieczenia = value; }
        public int Wiek { get => wiek; set => wiek = value; }

        public override string ToString()
        {
            return $"Pacjent: {imie} {nazwisko} z PESELEM {pesel} i numerem ubezpieczenia {numerUbezpieczenia} ma {wiek}";
        }
    }
}
