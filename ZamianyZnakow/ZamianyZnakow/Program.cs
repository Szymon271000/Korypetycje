using System;

namespace ZamianyZnakow
{
    class Program
    {
        static string ZamianyZnakow(string Test , int indeks)
        {
            for (int i = 0; i < Test.Length; i*= indeks)
            {
                Test[i] = '*';
            }
            return Test;
        }
        static void Main(string[] args)
        {
            string Test = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string result = ZamianyZnakow(Test, number);
            Console.WriteLine(result);
        }
    }
}
