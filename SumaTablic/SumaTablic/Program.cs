using System;

namespace SumaTablic
{
    class Program
    {
        static int[] SumaTablic(int[] First, int[] Second)
        {
            if (First.Length != Second.Length)
            {
                return null;
            }

            int[] NewTablica = new int[First.Length];
            for (int i = 0; i < First.Length; i++)
            {
                int sum = First[i] + Second[i];
                NewTablica[i] = sum;
            }
            return NewTablica;
        }
        static void Main(string[] args)
        {
            Console.Write("Tablica 1 : ");
            string First = Console.ReadLine();
            string[] Elements = First.Split(" ");
            int[] Numbers = new int[Elements.Length];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(Elements[i]);
            }
            Console.Write("Tablica 2 : ");
            string Second = Console.ReadLine();
            string[] Elements2 = Second.Split(" ");
            int[] Numbers2 = new int[Elements.Length];
            for (int i = 0; i < Numbers2.Length; i++)
            {
                Numbers2[i] = int.Parse(Elements2[i]);
            }
            Console.Write("Wynik: ");
            int[] Result = SumaTablic(Numbers, Numbers2);
            for (int i = 0; i < Result.Length; i++)
            {
                Console.Write(Result[i] + " ");
            }
        }
    }
}
