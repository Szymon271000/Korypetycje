using System;

namespace Mnozenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Liczba: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i < 11)
            {
                int product = n * i;
                Console.WriteLine($"{n} * {i} = {product}");
                i++;
            }
        }
    }
}
