using System;

namespace Wymiana_ujemnych
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] my_numbers = new int[6];
            for (int i = 0; i < my_numbers.Length; i++)
            {
                Console.Write("Podaj liczbe: ");
                my_numbers[i] = Convert.ToInt32(Console.In.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Wczytano: ");
            for (int i = 0; i < my_numbers.Length; i++)
            {
                Console.Write(my_numbers[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Po zmianie: ");
            for (int i = 0; i < my_numbers.Length; i++)
            {
                if (my_numbers[i] < 0)
                {
                    int new_number = 0;
                    my_numbers[i] = new_number;
                }
                Console.Write(my_numbers[i] + " ");
            }
        }
    }
}
