using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turniej
{
    class Gracz
    {
        private string Imie;
        private string Nazwisko;
        private int Punkty;

        public Gracz(string imie, string nazwisko, int punkty)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Punkty = punkty;
        }

        public int Punkty1 { get => Punkty;
            set 
            {
                if (value > 0)
                {
                    value = Punkty;
                }
            }
        }

        public override string ToString()
        {
            return $"Gracz: {Imie} {Nazwisko} {Punkty1}";
        }
    }
}
