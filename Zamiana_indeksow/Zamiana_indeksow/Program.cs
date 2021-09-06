using System;

namespace Zamiana_indeksow
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 11);
                numbers[i] = number;
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Podaj indeksy ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                var temp = numbers[a];
                numbers[a] = numbers[b];
                numbers[b] = temp;
                Console.Write(numbers[i]+ " ");
            }
        }
    }
}
