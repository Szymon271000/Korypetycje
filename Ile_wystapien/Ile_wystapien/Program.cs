using System;

namespace Ile_wystapien
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.Write("Wylosowano: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 6);
                numbers[i] = number;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Po obliczeniach: ");
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 1)
                {
                    counter++;
                }
            }
            Console.Write(counter + " ");
            for (int i = 1; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
