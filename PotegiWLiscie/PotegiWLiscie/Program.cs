using System;
using System.Collections.Generic;

namespace PotegiWLiscie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj n: ");
            int n = int.Parse(Console.ReadLine());
            List<double> MyList = new List<double>();

            for (int i = 1; i <= n; i++)
            {
                double IDoKwadratu = Math.Pow(i, 2);
                MyList.Add(IDoKwadratu);
            }

            Console.WriteLine("Wynik: ");

            for (int i = 0; i < MyList.Count; i++)
            {
                Console.Write(MyList[i] + " ");
            }
        }
    }
}
