using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise20._11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers.Add(input);
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int przedial1 = numbers.Count(x => x >= 0 && x <= 10);
            List<int> parzyste = numbers.FindAll(x => x % 2 == 0);
            bool dodatnie = numbers.Any(x => x <= 0);
            bool mniejsza = numbers.Any(x => x < -10);
        }
    }
}
