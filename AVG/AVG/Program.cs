using System;
using System.Collections.Generic;

namespace AVG
{
    class Program
    {
        static int AVG (List<int> Liczby)
        {
            int sum = 0;

            for (int i = 0; i < Liczby.Count; i++)
            {
                sum = sum + Liczby[i];
            }

            int srednia = sum / Liczby.Count;
            return srednia;
        }
        static void Main(string[] args)
        {
            List<int> Liczby = new List<int>() { 1, 2, 3, 4, 5 };
            for (int i = 0; i < Liczby.Count; i++)
            {
                Console.Write(Liczby[i] + " ");
            }
            Console.WriteLine();
            int srednia = AVG(Liczby);
            Console.WriteLine(srednia);
        }
    }
}
