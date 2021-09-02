using System;

namespace Petla_liczbowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj wartosc: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < n + 1)
            {
                Console.Write(i + " ");
                i++;
            }
        }
    }
}
