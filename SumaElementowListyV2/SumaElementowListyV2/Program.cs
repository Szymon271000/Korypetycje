using System;
using System.Collections.Generic;

namespace SumaElementowListyV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            List<int> MojaLista = new List<int>();
            while (suma < 100 && MojaLista.Count < 11)
            {
                Console.Write("Podaj liczbe: ");
                int n = int.Parse(Console.ReadLine());
                MojaLista.Add(n);
                suma = suma + n;
            }
            Console.WriteLine("Koniec programu: ");
            for (int i = 0; i < MojaLista.Count; i++)
            {
                Console.Write(MojaLista[i] + " ");
            }
        }
    }
}
