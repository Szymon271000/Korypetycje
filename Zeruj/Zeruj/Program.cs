using System;

namespace Zeruj
{
    class Program
    {
        static void Zeruj(int[] Tablica)
        {
            int rozmiar = Tablica.Length;
            for (int i = 0; i < rozmiar; i++)
            {
                Tablica[i] = 0;
            }
        }
        static void Main(string[] args)
        {
            int[] Liczby = new int[] { 9, 10, 3, 4, 6 };
            Zeruj(Liczby);
            for (int i = 0; i < Liczby.Length; i++)
            {
                Console.Write(Liczby[i] + " ");
            }
        }
    }
}
