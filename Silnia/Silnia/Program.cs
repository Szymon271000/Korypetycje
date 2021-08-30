using System;

namespace Silnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe");
            int n = int.Parse(Console.ReadLine());
            int silnia = 1;
            for (int i = 1; i < n + 1; i++)
            {
                silnia = silnia * i;
            }
            Console.WriteLine($"Wynik: {silnia}");
        }
    }
}
