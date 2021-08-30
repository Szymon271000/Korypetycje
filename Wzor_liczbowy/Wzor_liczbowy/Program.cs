using System;

namespace Wzor_liczbowy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1 ; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (j <= i)
                        Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
