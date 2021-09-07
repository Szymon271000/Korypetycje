using System;

namespace Zamiana_indeksow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = rnd.Next(1, 11);
                numbers[i] = number;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Podaj indeksy ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            string[] liczby = text.Split(" ");

            Console.WriteLine();

            if(liczby.Length != 2)
            {
                Console.WriteLine("Podano niepoprawna ilosc liczb!");
                return; //wywolanie returna w mainie konczy aplikacje [taki exit]
            }

            int a = int.Parse(liczby[0]);
            int b = int.Parse(liczby[1]);

            if(a >= 0 && a < numbers.Length && b >= 0 && b < numbers.Length)
            {
                var temp = numbers[a];
                numbers[a] = numbers[b];
                numbers[b] = temp;

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Niepoprawne indeksy!");
            }
        }
    }
}
