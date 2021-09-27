using System;

namespace Zbiornik
{
    class Program
    {
        static void Main(string[] args)
        {
            Zbiornik Z1 = new Zbiornik(numerZbiornika: 1, pojemnosc: 200, stanWody: 0);
            Console.WriteLine(Z1);
            Z1.Dolej = 100;
            Console.WriteLine(Z1);
            Z1.Odlej = 50;
            Console.WriteLine(Z1);
            Zbiornik Z2 = new Zbiornik(numerZbiornika: 2, pojemnosc: 1000, stanWody: 500);
            Console.WriteLine(Z2);
        }
    }
}
