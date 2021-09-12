using System;

namespace SredniaTablicy
{
    class Program
    {
        static int SredniaTablicy(int[] Numbers, int rozmiar)
        {
            rozmiar = Numbers.Length;
            int suma = 0;
            for (int i = 0; i < rozmiar; i++)
            {
                suma = suma + Numbers[i];
            }
            int Average = suma / rozmiar;
            return Average;
        }
        static void Main(string[] args)
        {
            string Napis = Console.ReadLine();
            string[] Elements = Napis.Split(" ");
            int[] Numbers = new int[Elements.Length];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(Elements[i]);
            }

            int Result = SredniaTablicy(Numbers, Numbers.Length);
            Console.WriteLine(Result);
        }
    }
}
