using System;

namespace LosowyWyraz2
{
    class Program
    {
        static string LosowyWyraz2(int Dlugosc)
        {
            string Slowo = "abcdefghijklmnopqrstvz";
            string NewWord = string.Empty;
            for (int i = 0; i < Dlugosc; i++)
            {
                Random rnd = new Random();
                int month = rnd.Next(Slowo[0], Slowo[21]);
                char z = (char)month;
                NewWord = NewWord + z;
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
