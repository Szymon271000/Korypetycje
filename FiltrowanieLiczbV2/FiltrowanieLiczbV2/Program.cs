using System;

namespace FiltrowanieLiczbV2
{
    class Program
    {
        static int ZliczMniejsze(int[] Tablica, int liczba)
        {
            int counter = 0;
            for (int i = 0; i < Tablica.Length; i++)
            {
                if (Tablica[i] < liczba)
                {
                    counter++;
                }
            }
            return counter;
        }
        static int[] Filtruj(int[] Tablica, int liczba)
        {
            int counter = ZliczMniejsze(Tablica, liczba);
            int[] Wynik = new int[counter];
            int k = 0;
            for (int i = 0; i < Tablica.Length; i++)
            {
                if (Tablica[i] < liczba)
                {
                    Wynik[k] = Tablica[i];
                    k++;
                }
            }
            return Wynik;
        }

        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            string[] Elements = Input.Split(" ");
            int[] Numbers = new int[Elements.Length];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(Elements[i]);
            }
            int min = int.Parse(Console.ReadLine());
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] < min)
                {
                    Console.Write(Numbers[i] + " ");
                }
            }
        }
    }
}
