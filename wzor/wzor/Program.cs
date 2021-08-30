using System;

namespace wzor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            for (int j = 0; j < n ; j++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
