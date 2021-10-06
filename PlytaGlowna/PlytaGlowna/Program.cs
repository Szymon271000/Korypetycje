using System;

namespace PlytaGlowna
{
    class Program
    {
        static void Main(string[] args)
        {
            Ram r1 = new Ram("Kingstone", 8);
            Ram r2 = new Ram("HyperX", 8);
            Ram r3 = new Ram("Samsung", 2);

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);

            PlytaGlowna p1 = new PlytaGlowna("Gigabyte", 16);
            Console.WriteLine("Pusta");
            Console.WriteLine(p1);
            p1.AddRam(r1);
            Console.WriteLine("Jeden ram");
            Console.WriteLine(p1);
            p1.AddRam(r2);
            Console.WriteLine("Dwa ramy");
            Console.WriteLine(p1);
            p1.AddRam(r3);
            Console.WriteLine("trzy ramy");
            Console.WriteLine(p1);

            int suma = p1.IleGB();
            Console.WriteLine(suma);
            Console.WriteLine(p1);
        }
    }
}
