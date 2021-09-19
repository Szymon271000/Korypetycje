using System;
using System.Collections.Generic;

namespace DodawanieLiczbDoListy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Liczby = new List<int>();
            Console.WriteLine("Podaj liczbe: ");
            int Liczba = int.Parse(Console.ReadLine());
            Liczby.Add(Liczba);
            while (Liczba != 0)
            {
                Console.WriteLine("Podaj liczbe: ");
                Liczba = int.Parse(Console.ReadLine());
                Liczby.Add(Liczba);
            }
            Console.Write("Koniec programu, wprowadzono: ");
            for (int i = 0; i < Liczby.Count; i++)
            {
                Console.Write(Liczby[i] + " ");
            }
        }
    }
}
