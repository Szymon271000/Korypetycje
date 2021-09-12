using System;

namespace FiltrowanieLiczbV2
{
    class Program
    {

        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            string[] Elements = Input.Split(" ");
            int[] Numbers = new int[Elements.Length];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(Elements[i]);
            }
            int min = int.Parse(Console.ReadLine());
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] < min)
                {
                    Console.Write(Numbers[i] + " ");
                }
            }
        }
    }
}
