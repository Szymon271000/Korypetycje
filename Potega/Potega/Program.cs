using System;

namespace Potega
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_number = int.Parse(Console.ReadLine());
            int second_number = int.Parse(Console.ReadLine());
            double potega = first_number;
            for (int i = 0; i < second_number + 1; i++)
            {
                potega = Math.Pow(first_number, i);
            }
            Console.WriteLine(potega);
        }
    }
}
