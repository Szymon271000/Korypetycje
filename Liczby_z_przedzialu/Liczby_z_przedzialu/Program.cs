using System;

namespace Liczby_z_przedzialu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj poczatek przedzialu: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Podaj koniec przedzialu: ");
            int n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                Console.Write(i + " ");
                i++;
            }
        }
    }
}
