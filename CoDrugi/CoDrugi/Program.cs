using System;

namespace CoDrugi
{
    class Program
    {
        static int[] CoDrugiElement(int[] Tablica)
        {
            int counter =  Tablica.Length / 2;

            int[] NewTablica = new int[counter];
            for (int i = 0; i < NewTablica.Length; i++)
            {
                NewTablica[i] = Tablica[(i * 2) + 1];
            }
            return NewTablica;

        }
        static void Main(string[] args)
        {
            Console.Write("Wejscie: ");
            string dane = Console.ReadLine();
            string[] Elements = dane.Split(" ");
            int[] Numbers = new int[Elements.Length];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(Elements[i]);
            }
            Console.Write("Wyjscie: ");
            int[] result = CoDrugiElement(Numbers);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
