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

        public string Producent1 { get => Producent; set => Producent = value; }

        public Ram(string producent, int pomjemnosc)
        {
            Producent1 = producent;
            Pojemnosc = pomjemnosc;
        }
        public Ram()
        {

        }



        public override string ToString()
        {
            return $"Ram producenta {Producent1} ma pojemnosc {Pojemnosc1}";

        }
    }
}
