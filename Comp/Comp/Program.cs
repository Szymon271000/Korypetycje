using System;

namespace Comp
{
    class Program
    {
        static void Main(string[] args)
        {
            Komputer k1 = new Komputer();
            Laptop l1 = new Laptop();
            Laptop l2 = new Laptop("Apple", "MacBookPro", "A1932", "CPU 8-Core", "PCI Express", 1000, 1.7f, "A1943", true);

            string wynik1 = k1.Wyswietl();
            string wynik2 = l1.Wyswietl();
            string wynik3 = l2.Wyswietl();

            Console.WriteLine(wynik1);
            Console.WriteLine(wynik2);
            Console.WriteLine(wynik3);
        }
    }
}
