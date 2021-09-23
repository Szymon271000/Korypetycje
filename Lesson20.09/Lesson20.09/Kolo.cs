using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20._09
{
    class Kolo
    {
        public int Promien;

        //properties (wlasciwosci)
        public int Srednica { get => 2 * Promien; set => Promien = value / 2; } //jesli bedziesz chcial pobrac wartosc z tej wlasciowsci to dostaniesz podowojona wartosc promienia
        //set uzmozliwia ustawienie wartosci

        public double Pole { get => Math.PI * Promien * Promien; }

        public string Kolor { get => "white"; }

        public Kolo(int promien)
        {
            this.Promien = promien;
        }

        public override string ToString()
        {
            return $"Kolo: r={Promien}";
        }
    }
}
