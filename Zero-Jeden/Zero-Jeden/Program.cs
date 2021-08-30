using System;

namespace Zero_Jeden
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
            }
        }
    }
}
