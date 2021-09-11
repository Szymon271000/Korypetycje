using System;

namespace Zeruj
{
    class Program
    {
        static void Zeruj(int[] Tablica, int rozmiar)
        {
            rozmiar = Tablica.Length;
            for (int i = 0; i < rozmiar; i++)
            {
                Tablica[i] = 0;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
