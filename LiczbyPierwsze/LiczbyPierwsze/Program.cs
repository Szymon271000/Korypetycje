using System;

namespace LiczbyPierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            string Tablica = Console.ReadLine();
            string[] Numery = Tablica.Split(" ");
            int[] myInts = new int[Numery.Length];
            for (int i = 0; i < myInts.Length; i++)
            {
                myInts[i] = int.Parse(Numery[i]);
            }
            int counter = 0;
            for (int i = 0; i < myInts.Length; i++)
            {
                for (int j = 1; j <= myInts[i]; j++)
                {
                    if (myInts[i] % j == 0)
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
