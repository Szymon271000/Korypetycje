using System;
using System.Collections.Generic;

namespace CiagWLiscie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe: ");
            int Liczba = int.Parse(Console.ReadLine());
            List<int> ListaLiczb = new List<int>();
            for (int i = 0; i < Liczba + 1; i++)
            {
                ListaLiczb.Add(i);
            }

            Console.WriteLine("Wynik: ");

            for (int i = 0; i < ListaLiczb.Count; i++)
            {
                Console.Write(ListaLiczb[i] + " ");
            }
        }
    }
}
