using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlytaGlowna
{
    public class Ram
    {
        private string Producent;
        private int Pojemnosc;
        public int Pojemnosc1
        {
            get => Pojemnosc;
            set
            {
                if (value > 0)
                {
                    value = Pojemnosc;
                }
            }
        }

        public Ram(string producent, int pomjemnosc)
        {
            Producent = producent;
            Pojemnosc = pomjemnosc;
        }
        public Ram()
        {

        }



        public override string ToString()
        {
            return $"Ram producenta {Producent} ma pojemnosc {Pojemnosc1}";

        }
    }
}
