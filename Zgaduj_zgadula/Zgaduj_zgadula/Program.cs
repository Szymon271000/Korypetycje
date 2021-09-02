using System;

namespace Zgaduj_zgadula
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random_numer = rnd.Next(0, 10);
            Console.Write("Podaj liczbe: ");
            int n = int.Parse(Console.ReadLine());
            while (n != random_numer)
            {
                if (n > random_numer)
                {
                    Console.WriteLine("Za duza");
                }
                else
                {
                    Console.WriteLine("Za mala");
                }
                Console.Write("Podaj liczbe: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Wygrana, koniec programu.");
        }
    }
}
