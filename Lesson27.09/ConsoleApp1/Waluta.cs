using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Waluta
    {
        //Zasada hermetyzacji - wszystkie pola w klasie sa private, mozesz sie do nich odnosic wykorzystujac np properties (get; set)
        private double pln; //private - tej zmiennej mozna uzywac tylko w klasie

        public Waluta(double pln)
        {
            this.Pln = pln;
        }

        public double Pln { get => pln; 
            set
            {
                if(value >= 0)
                {
                    pln = value;
                }
            }
        } //za pomoca property mozemy ustawic wartosc w polu prywatnym

        public double Eur
        {
            get => pln / 4.5;
            set
            {
                if (value > 0)
                {
                    pln = value * 4.5;
                }
            }
        }

        public double Usd => pln / 3.8;

        public override string ToString()
        {
            return $"{Pln}zł";
        }
    }
}
