using System;
using System.Collections.Generic;
using System.IO;

namespace AnalizaLiczbWPliku
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = File.ReadAllText(@"C:\Users\huber\OneDrive\Desktop\Liczby.txt");
            string[] linie = info.Split("\r\n");
            int[] Numbers = new int[linie.Length];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(linie[i]);
            }

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }

        }
    }
}
