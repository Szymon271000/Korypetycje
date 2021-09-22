using System;
using System.Collections.Generic;

namespace FibonacciWLiscie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MojaLista = new List<int>() { 1, 1 };
            for (int i = 2; i < 10; i++)
            {
                MojaLista.Add(MojaLista[i - 2] + MojaLista[i - 1]);
            }

            for (int i = 0; i < MojaLista.Count; i++)
            {
                Console.WriteLine(MojaLista[i] + " ");
            }
            
        }
    }
}
