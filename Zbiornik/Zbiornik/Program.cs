using System;

namespace Zbiornik
{
    class Program
    {
        static void Main(string[] args)
        {
            Zbiornik z1 = new Zbiornik(200);
            Console.WriteLine(z1);
            z1.Dolej(100);
            Console.WriteLine(z1);
            z1.Odlej(50);
            Console.WriteLine(z1);
            Zbiornik z2 = new Zbiornik(1000);
            z2.Dolej(500);
            Console.WriteLine(z2);
        }
    }
}
