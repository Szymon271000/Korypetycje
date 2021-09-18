using System;

namespace LosowyWyraz2
{
    class Program
    {
        static string LosowyWyraz2(int Dlugosc)
        {
            string Slowo = "+-*";
            string NewWord = string.Empty;
            Random rnd = new Random();
            for (int i = 0; i < Dlugosc; i++)
            {
                int index = rnd.Next(0, Slowo.Length);
                NewWord = NewWord + Slowo[index];
            }

            return NewWord;
        }
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            string result = LosowyWyraz2(Number);
            Console.WriteLine(result);
        }
    }
}
