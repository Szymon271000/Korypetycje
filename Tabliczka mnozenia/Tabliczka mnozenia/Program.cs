using System;

namespace Tabliczka_mnozenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 10)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    for (int j = 1; j < n + 1; j++)
                    {
                        int product = i * j;
                        Console.Write(product + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Liczba za duza");
            }
        }
    }
}
