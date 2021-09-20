using System;
using System.Collections.Generic;

namespace Monety
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ile monet? ");
            int n = int.Parse(Console.ReadLine());
            List<string> Monety = new List<string>();
            int CounterR = 0;
            int CounterO = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj znak monety:");
                string moneta = Console.ReadLine();
                if (moneta == "O")
                {
                    CounterO++;
                }
                else if (moneta == "R")
                {
                    CounterR++;
                }
                Monety.Add(moneta);
            }

            for (int i = 0; i < Monety.Count; i++)
            {
                Console.Write(Monety[i] + " ");
            }

            Console.WriteLine();

            if (CounterO > CounterR)
            {
                Console.WriteLine($"Nalezy odwrocic: {CounterR}");
            }
            else
            {
                Console.WriteLine($"Nalezy odwrocic: {CounterO}");
            }
        }
    }
}
