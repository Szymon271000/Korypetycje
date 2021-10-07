using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turniej
{
    public class Gracz
    {
        private string Imie;
        private string Nazwisko;
        private int Punkty;

        public Gracz(string imie, string nazwisko, int punkty)
        {
            Imie1 = imie;
            Nazwisko1 = nazwisko;
            Punkty = punkty;
        }
        public Gracz()
        {

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

        public string Imie1 { get => Imie; set => Imie = value; }
        public string Nazwisko1 { get => Nazwisko; set => Nazwisko = value; }

        public override string ToString()
        {
            return $"Gracz: {Imie1} {Nazwisko1} {Punkty1}";
        }
    }
}
