using System;

namespace Kwadraty_liczb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbe: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                double i_quadrat = Math.Pow(i,2);
                Console.Write(i_quadrat + " ");
                i++;
            }
        }
    }
}
