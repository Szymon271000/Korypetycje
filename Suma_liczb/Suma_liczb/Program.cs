using System;

namespace Suma_liczb
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 201; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
