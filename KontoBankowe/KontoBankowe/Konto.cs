using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoBankowe
{
    class Konto
    {
        private float stankonta;
        private int debet;
        private float oprocentowanie;
        private string pin;

        public Konto(float oprocentowanie)
        {
            this.oprocentowanie = oprocentowanie;
        }


        public void Wyplac(int kwota)
        {
            if (kwota <= stankonta)
            {
                float roznica = stankonta - kwota;
                stankonta = roznica;
            }
            else
            {
                Console.WriteLine("Operacja niemozliwa");
            }
        }
        public void Wplac(float kwota)
        {
            float suma = kwota + stankonta;
            stankonta = suma;
        }

        public float SetDebet(float kwota)
        {
            stankonta = kwota;
            return stankonta;
        }

        public void SetPin(string Newpin)
        {
            if (Newpin.Length != 4)
            {
                Console.WriteLine("Podany numer ma bledny format");
            }
            else
            {
                pin = Newpin;
            }
        }

        public void Kapitalizacja()
        {
            // ask how to use SetDebet(stankonta)
            float NowyStanKonta = stankonta - 500 + ((stankonta -500) *(oprocentowanie / 12)); //SetDebet(stankonta)// 
            stankonta = NowyStanKonta;
        }

        public bool SprawdzPin(int pin)
        {
            string NewPin = pin.ToString();
            if (NewPin == this.pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PozazStan()
        {
            Console.WriteLine($"{stankonta}");
        }
    }
}
