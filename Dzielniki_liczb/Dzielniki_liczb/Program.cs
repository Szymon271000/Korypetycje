using System;

namespace Dzielniki_liczb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 21; i++)
            {
                for (int j = 1; j < 21; j++)
                {
                    int dzielnik = i % j;
                    if (dzielnik == 0)
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            } 
        }
    }
}
