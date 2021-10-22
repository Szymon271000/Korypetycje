using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadTrip
{
    class RurkaPilota: ICzujnik
    {
        private string dataProdukcji;
        public int ilosc;

        public RurkaPilota(string dataProdukcji, int ilosc)
        {
            this.dataProdukcji = dataProdukcji;
            this.ilosc = ilosc;
        }

        public int Losowanie()
        {
            dataProdukcji.Split("/");
            string[] datestring = new string[dataProdukcji.Length];
            int[] date = new int[3];
            for (int i = 0; i < date.Length; i++)
            {
                date[i] = int.Parse(datestring[i]);
            }
            if (2021 - date[2] > 10)
            {
                Random rnd = new Random();
                int suma = 0;
                for (int i = 0; i < ilosc; i++)
                {
                    int number = rnd.Next(0, 41);
                    suma = suma + number;
                }
                int srednia = suma / ilosc;
                return srednia;
            }
            else
            {
                Random rnd = new Random();
                int suma = 0;
                for (int i = 0; i < ilosc; i++)
                {
                    int number = rnd.Next(0, 31);
                    suma = suma + number;
                }
                int srednia = suma / ilosc;
                return srednia;
            }
        }
      
        public bool Alarm(int temperatura)
        {
            temperatura = Losowanie();
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
