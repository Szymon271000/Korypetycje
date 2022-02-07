using System;

namespace Lekcja07._02
{
    class Program
    {
        static void Hello()
        {
            Console.WriteLine("Hello world!");
        }

        static void Potega(int a, int b)
        {
            Console.WriteLine(Math.Pow(a, b));
        }

        static int Dodawanie(double x, double y)
        {
            return (int)(x + y);
        }

        static int RzutKostka()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }

        static void Main(string[] args)
        {
            Action x = Hello;
            x();

            Action<int, int> a = Potega;
            a(2, 5);

            Func<double, double, int> funkcja = Dodawanie; //<typ argumentu 1, typ argumentu 2, typ zwracany>
            Console.WriteLine(funkcja(10, 20));

            Func<int> func = RzutKostka;
            Console.WriteLine(func());
        }
    }
}
