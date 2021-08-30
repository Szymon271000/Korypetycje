using System;

namespace Wczytywanie_z_warunkami
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_min = -11;
            int second_min = 55;
            Console.WriteLine("Podaj liczbe:");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            while ((n <= first_min) || ( n >= first_min))
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
