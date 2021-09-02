using System;

namespace Min_i_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Podaj liczbe: ");
                int n = int.Parse(Console.ReadLine());
                if (n < min)
                {
                    min = n;
                }
                if (n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
        }
    }
}
