using System;

namespace LiczbyWJednejLinii
{
    class Program
    {
        static int LiczbyWJednejLinii(string dane)
        {
            string[] elementy = dane.Split(" ");
            int[] liczby = new int[elementy.Length];
            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = int.Parse(elementy[i]);
            }
            int suma = 0;
            for (int i = 0; i < liczby.Length; i++)
            {
                suma = suma + liczby[i];
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj liczby: ");
            string Input = Console.ReadLine();
            int result = LiczbyWJednejLinii(Input);
            Console.WriteLine($"Suma: {result}");
        }
    }
}
