using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadTrip
{
    class APU: ICzujnik
    {
        private bool czyWylaczony;

        public APU(bool czyWylaczony)
        {
            this.czyWylaczony = czyWylaczony;
        }

        public int Wynik()
        {
            if (czyWylaczony == true)
            {
                Random rnd = new Random();
                int number = rnd.Next(0, 90);
                return number;
            }
            else
            {
                return 0;
            }
        }

        public bool Alarm()
        {
            int temperatura = Wynik();
            if (temperatura > 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
