using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbiornik
{
    class Zbiornik
    {
        public int NumerZbiornika;
        public int Pojemnosc;
        public int StanWody;

        public Zbiornik()
        {
            StanWody = 0;
        }

        public Zbiornik(int numerZbiornika, int pojemnosc, int stanWody)
        {
            NumerZbiornika = numerZbiornika;
            Pojemnosc = pojemnosc;
            StanWody = stanWody;
        }

        public int Dolej
        {
            set
            {
                if (value >= 0 && value <= Pojemnosc)
                {
                     StanWody += value; 
                }
            }
        }
        public int Odlej
        {
            set
            {
                if (value >= 0 && value <= Pojemnosc && StanWody > 0)
                {
                    StanWody -= value;
                }
            }
        }

        public override string ToString()
        {
            return $"Zbiornik {NumerZbiornika} z pojemnoscia {Pojemnosc} stan wody {StanWody}";
        }
    }
}
