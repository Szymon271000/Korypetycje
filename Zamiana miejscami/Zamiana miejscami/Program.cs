using System;

namespace Zamiana_miejscami
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_number = int.Parse(Console.ReadLine());
            int second_number = int.Parse(Console.ReadLine());

            int tmp = first_number;
            first_number = second_number;
            second_number = tmp;

            Console.Write(first_number + " " + second_number);
        }
    }
}
