using System;

namespace Statystyka_liczb
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;
            double average = 0;
            int difference = 0;
            while (n + 1 > i)
            {
                Console.WriteLine($"Podaj nr {i}:");
                int num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
                sum = sum + num;
                average = sum / n;
                difference = max - min;
                i++;
            }
            Console.WriteLine($"Srednia: {average}");
            Console.WriteLine($"Roznica: {difference}");
        }
    }
}
