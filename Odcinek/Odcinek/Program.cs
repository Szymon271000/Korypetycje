using System;

namespace Odcinek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj dlugosc: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < n)
            {
                Console.Write("-");
                i++;
            }
        }
    }
}
