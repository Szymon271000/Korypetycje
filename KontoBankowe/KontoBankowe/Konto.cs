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
        private float debet;
        private float oprocentowanie;
        private string pin;

        public Konto(float oprocentowanie)
        {
            this.oprocentowanie = oprocentowanie;
        }


        public void Wyplac(int kwota)
        {
            if (kwota < stankonta || debet > kwota)
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
            debet = kwota;
            return debet;
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
            float NowyStanKonta = (stankonta * (oprocentowanie / 12)) + stankonta;//stankonta - debet + ((stankonta - debet) * (oprocentowanie / 12)); //- 500 + ((stankonta -500) *(oprocentowanie / 12)); //SetDebet(stankonta)// 
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
