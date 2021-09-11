using System;

namespace LiczbyPierwsze
{
    class Program
    {
        static int[] LiczbyPierwsze (int[] Tablica)
        {
            for (int i = 0; i < Tablica.Length; i++)
            {
                for (int j = 2; j < Tablica[i]; j++)
                {
                    if (Tablica [i] % j == 0)
                    {
                        return Tablica;
                    }
                }
            }
            return Tablica;
        }
        static void Main(string[] args)
        {
            string Tablica = Console.ReadLine();
            string[] Numery = Tablica.Split(" ");
            int[] myInts = Array.ConvertAll(Numery, int.Parse);
            int[] result = LiczbyPierwsze(myInts);
            Console.WriteLine(result);

        }
    }
}
