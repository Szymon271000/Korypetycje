using System;

namespace LosowyWyraz
{
    class Program
    {
        static string LosowyWyraz(int Liczba)
        {
            string Slowo = string.Empty;
            for (int i = 0; i < Liczba; i++)
            {
                Random rnd = new Random();
                int number = rnd.Next(97, 122);
                char z = (char)number;
                Slowo = Slowo + z;
            }
            return Slowo;
        }
        static void Main(string[] args)
        {
            int Dlugosc = int.Parse(Console.ReadLine());
            string Result = LosowyWyraz(Dlugosc);
            Console.WriteLine(Result);
        }
    }
}
