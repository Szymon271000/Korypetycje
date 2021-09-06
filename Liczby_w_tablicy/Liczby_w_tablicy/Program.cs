using System;

namespace Liczby_w_tablicy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[11];
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            

        }
    }
}
