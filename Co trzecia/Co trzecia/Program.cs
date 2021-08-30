using System;

namespace Co_trzecia
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 22; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
