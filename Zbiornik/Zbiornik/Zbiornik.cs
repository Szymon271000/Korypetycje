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
        private static int counter = 1;

        public Zbiornik()
        {
            StanWody = 0;
            NumerZbiornika = counter;
            counter++;
            Pojemnosc = 0;
        }

        public Zbiornik(int pojemnosc)
        {
            NumerZbiornika = counter;
            counter++;
            Pojemnosc = pojemnosc;
            StanWody = 0;
        }

        public void Dolej(int value)
        {
         
                if (value >= 0 && value + StanWody <= Pojemnosc)
                {
                     StanWody += value; 
                }
            
        }
        public void Odlej(int value)
        {
            
                if (value >= 0 && StanWody - value >= 0)
                {
                    StanWody -= value;
                }
            
        }

        public override string ToString()
        {
            return $"Zbiornik {NumerZbiornika} z pojemnoscia {Pojemnosc} stan wody {StanWody}";
        }
    }
}
