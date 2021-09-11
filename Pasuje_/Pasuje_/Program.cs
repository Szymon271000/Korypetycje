using System;

namespace Pasuje_
{
    class Program
    {
        static bool Pasuje (int liczba, int poczatek, int koniec)
        {
            for (int i = poczatek; i < koniec; i++)
            {
                if ((liczba >= poczatek) && (liczba <= koniec))
                {
                    return true;
                }
            }
            return false;
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
            bool result = Pasuje(Numbers[0], Numbers[1], Numbers[2]);
            Console.WriteLine(result);
        }
    }
}
