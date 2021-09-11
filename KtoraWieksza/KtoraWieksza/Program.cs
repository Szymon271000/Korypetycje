using System;

namespace KtoraWieksza
{
    class Program
    {
        static int KtoraWieksza(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            string[] Elements = Input.Split(" ");
            int[] Numbers = new int[Elements.Length];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(Elements[i]);
            }
            int result = KtoraWieksza(Numbers[0], Numbers[1]);
            Console.WriteLine(result);
        }
    }
}
