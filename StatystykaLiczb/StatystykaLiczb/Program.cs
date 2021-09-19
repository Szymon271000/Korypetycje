using System;
using System.Collections.Generic;

namespace StatystykaLiczb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList = new List<int>() { 1, 2, 6, 11, 8, 3, 5, 4, 9, 21, 5, 12 };
            int Counter2 = 0;
            int Counter3 = 0;
            Console.WriteLine("Moja lista: ");
            for (int i = 0; i < MyList.Count; i++)
            {
                Console.Write(MyList[i] + " ");
            }
            for (int i = 0; i < MyList.Count; i++)
            {
                if (MyList[i] % 2 == 0)
                {
                    Counter2++;
                }
            }
            for (int i = 0; i < MyList.Count; i++)
            {
                if (MyList[i] % 3 == 0)
                {
                    Counter3++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Liczby podzielne przez 2 : {Counter2}");
            Console.WriteLine($"Lcizby podzielne przez 3 : {Counter3}");
        }
    }
}
