using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja03._01
{
    class Car
    {
        private string nazwa;
        private string rejestracja;
        private int numerMiejsca;

        public Car(string nazwa, string rejestracja, int numerMiejsca)
        {
            this.nazwa = nazwa;
            this.rejestracja = rejestracja;
            this.numerMiejsca = numerMiejsca;
        }

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public string Rejestracja { get => rejestracja; set => rejestracja = value; }
        public int NumerMiejsca { get => numerMiejsca; set => numerMiejsca = value; }

        public override string ToString()
        {
            return $"{nameof(Nazwa)}: {Nazwa}, {nameof(Rejestracja)}: {Rejestracja}, {nameof(NumerMiejsca)}: {NumerMiejsca}";
        }
    }
}
