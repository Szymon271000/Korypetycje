using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadTrip
{
    class RurkaPilota: ICzujnik
    {
        private DateTime dataProdukcji;
        public int ilosc;

        public RurkaPilota(DateTime dataProdukcji, int ilosc)
        {
            this.dataProdukcji = dataProdukcji;
            this.ilosc = ilosc;
        }

        public int Losowanie()
        {
            int koniecPrzedzialu;
            if (DateTime.Now.Year - dataProdukcji.Year > 10)
            {
                koniecPrzedzialu = 41;
            }
            else
            {
                koniecPrzedzialu = 31;
            }

            Random rnd = new Random();
            int suma = 0;
            for (int i = 0; i < ilosc; i++)
            {
                int number = rnd.Next(0, koniecPrzedzialu);
                suma = suma + number;
            }
            int srednia = suma / ilosc;
            return srednia;
        }
      
        public bool Alarm()
        {
            int temperatura = Losowanie();
            if (temperatura > 25)
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
