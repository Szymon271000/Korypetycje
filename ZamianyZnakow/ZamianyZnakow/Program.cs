using System;

namespace ZamianyZnakow
{
    class Program
    {
        static string ZamianyZnakow(string Test , int indeks)
        {
            string wynik = string.Empty;
            for (int i = 0; i < Test.Length; i++)
            {
                if ((i+1) % indeks != 0)
                {
                    wynik = wynik + Test[i];
                }
                else
                {
                    wynik = wynik + "*";
                }
            }
            return wynik;
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
