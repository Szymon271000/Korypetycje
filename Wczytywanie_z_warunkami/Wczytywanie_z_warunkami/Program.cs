using System;

namespace Wczytywanie_z_warunkami
{
    class Program
    {
        static void Main(string[] args)
        {
            double positive = double.PositiveInfinity;
            int first_min = -11;
            Console.WriteLine("Podaj liczbe:");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            while ((n <= positive) && ( n <= first_min))
            {
                Console.WriteLine("Podaj liczbe:");
                n = int.Parse(Console.ReadLine());
                if (counter == 3)
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine("Koniec programu");
        }
    }
}
