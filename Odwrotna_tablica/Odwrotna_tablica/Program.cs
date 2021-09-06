using System;

namespace Odwrotna_tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.In.ReadLine());
            }
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
           
        }
    }
}
