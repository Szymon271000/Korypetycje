using System;

namespace LiczbyPierwsze
{
    class Program
    {
        static bool CzyPierwsza(int liczba)
        {
            for (int i = 2; i <= liczba / 2; i++)
            {
                if (liczba % i == 0)
                {
                    return false;
                }
            }

            return true;
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
