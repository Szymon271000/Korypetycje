using System;

namespace Liczby_w_przedziale
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_number = int.Parse(Console.ReadLine());
            int second_number = int.Parse(Console.ReadLine());
            for (int i = first_number; i < second_number; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
