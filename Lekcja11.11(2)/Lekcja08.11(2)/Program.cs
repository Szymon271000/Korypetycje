using System;
using System.Collections.Generic;

namespace Lekcja08._11_2_
{
    class Program
    {
        static void Pokaz<MojTyp>(List<MojTyp> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        static (int, int) MinMax(int[] tablica)
        {
            int min = tablica[0];
            int max = tablica[0];
            for (int i = 0; i < tablica.Length; i++)
            {
                if(tablica[i] > max)
                {
                    max = tablica[i];
                }
                if(tablica[i] < min)
                {
                    min = tablica[i];
                }
            }
            return (min, max);
        }

        static void Main(string[] args)
        {
            List<string> slowa = new List<string>
            {
                "ala", "ma", "kota"
            };
            Pokaz(slowa);

            List<int> liczby = new List<int>() { 10, 20, 30, 40 };
            Pokaz(liczby);

            Stos<int> stos = new Stos<int>();
            stos.Push(10);
            stos.Push(20);
            stos.Push(30);

            Console.WriteLine(stos.Pop());
            Console.WriteLine(stos[0]);

            var tablica = new int[] { 10, 5, 1, 0, 8, 9, 100, 5, 1, 4, 11 };
            (int minimum, int maximum) = MinMax(tablica);
            Console.WriteLine($"Min: {minimum} Max: {maximum}");

            var wynik = MinMax(tablica);
            Console.WriteLine($"Min: {wynik.Item1} Max: {wynik.Item2}");
        }
    }
}
