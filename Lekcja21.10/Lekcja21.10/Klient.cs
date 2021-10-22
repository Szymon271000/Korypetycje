using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja21._10
{
    class Klient
    {
        private string imie;
        private string nazwisko;
        private string tel;

        public Klient(string imie, string nazwisko, string tel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.Tel = tel;
        }

        public string Imie { get => imie; }
        public string Nazwisko { get => nazwisko; }
        public string Tel { get => tel;
            set
            {
                if (!TelefonExtension.PoprawnyNrTel(value))
                {
                    throw new TelFormatException(value); //rzut wyjatkiem
                }

                tel = value;
            }
        }
    }
}
