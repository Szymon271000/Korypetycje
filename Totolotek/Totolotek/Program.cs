using System;

namespace Totolotek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 100);
                numbers[i] = number;
                sum = sum + numbers[i];
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
