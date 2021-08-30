using System;

namespace Dzielniki_30
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 31; i++)
            {
                if ( 30 % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
