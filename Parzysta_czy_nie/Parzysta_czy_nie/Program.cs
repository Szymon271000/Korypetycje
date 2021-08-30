using System;

namespace Parzysta_czy_nie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe:");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba % 2 == 0)
            {
                Console.WriteLine("Parzysta");
            }
            else
            {
                Console.WriteLine("Nieparzysta");
            }
        }
    }
}
