using System;

namespace LiczbyPierwsze
{
    class Program
    {
        static bool CzyPierwsza(int liczba)
        {
            int counter = 0;
            for (int i = 1; i <= liczba; i++)
            {
                if (liczba % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string Dane = Console.ReadLine();
            string[] Elements = Dane.Split(" ");
            int[] Numbers = new int[Elements.Length];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(Elements[i]);
            }
            for (int i = 0; i < Numbers.Length; i++)
            {
                bool result = CzyPierwsza(Numbers[i]);
                Console.WriteLine(result);
            }

        }
    }
}
