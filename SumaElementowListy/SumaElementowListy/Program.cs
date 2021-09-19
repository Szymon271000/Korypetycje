using System;
using System.Collections.Generic;

namespace SumaElementowListy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaLiczb = new List<int>();
            int sum = 0;
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Podaj element nr {i} :");
                int Liczba = int.Parse(Console.ReadLine());
                ListaLiczb.Add(Liczba);
                sum = sum + Liczba;
            }
            Console.Write("Wprowadzono: ");
            for (int i = 0; i < ListaLiczb.Count; i++)
            {
                Console.Write(ListaLiczb[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Suma: {sum}");
        }
    }
}
