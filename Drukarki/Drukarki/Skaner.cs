using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukarki
{
    class Skaner : Urzadzenie, ISkanowanie
    {
        private int szybkosc;

        public Skaner(string marka, string model, int szybkosc): base (marka, model)
        {
            this.Szybkosc = szybkosc;
        }

        public int Szybkosc { get => szybkosc;
            set
            {
                if (value > 0)
                {
                    value = szybkosc;
                }
            }
        } 

        public void Skanuj()
        {
            if (szybkosc <= 0)
            {
                throw new SzybkoscUjemnaException();
            }
            else
            {
                Console.WriteLine($"Drukarka moze skanowac kartke w {szybkosc} sekundach");
            }
        }

        public override string ToString()
        {
            return $"Skaner: {Marka}, {Model}, {Szybkosc}";
        }
    }
}
