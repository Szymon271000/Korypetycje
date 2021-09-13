using System;

namespace LiczbyPierwsze
{
    class Program
    {
        /*static int[] LiczbyPierwsze (int[] Tablica)
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
        }*/
        static void Main(string[] args)
        {
            string Tablica = Console.ReadLine();
            string[] Numery = Tablica.Split(" ");
            int[] myInts = new int[Numery.Length];
            for (int i = 0; i < myInts.Length; i++)
            {
                myInts[i] = int.Parse(Numery[i]);
            }
            for (int i = 0; i < myInts.Length; i++)
            {
                for (int j = 2; j < myInts[i]; j++)
                {
                    if (myInts[i] % j != 0)
                    {
                        j++;
                    }
                    else if (myInts[i] % j == 0)
                    {
                        Console.Write(myInts[i] + " ");
                    }
                }
            }
        }
    }
}
