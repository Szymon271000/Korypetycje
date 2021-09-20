using System;
using System.Collections.Generic;

namespace Stonks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe: ");
            int n = int.Parse(Console.ReadLine());
            List<int> MojaLista = new List<int>();
            int min = int.MinValue;
            while (n > min)
            {
                MojaLista.Add(n);
                min = n;
                Console.WriteLine("Podaj liczbe: ");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
