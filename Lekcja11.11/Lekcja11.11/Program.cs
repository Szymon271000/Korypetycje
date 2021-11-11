using System;

namespace Lekcja11._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek u1 = new Ulamek(4, 8);
            Ulamek u2 = new Ulamek(1, 2);
            Console.WriteLine(u1);
            Console.WriteLine(u2);

            Ulamek u3 = new Ulamek(3, 4);
            Ulamek u4 = new Ulamek(1, 2);
            int a = 15;
            int b = 10;

            if (u1 == u2)
            {
                Console.WriteLine("Rowne");
            }

            if (u3 > u4)
            {
                Console.WriteLine("u3 jest wiekszy");
            }

            Console.WriteLine(u3 * u4);
            Console.WriteLine(u3 * 5);
            Console.WriteLine(u3 / u4);

            //double liczba = u4;
            //Console.WriteLine(liczba);

            Ulamek ux = (Ulamek)3;
            Console.WriteLine(ux);
        }
    }
}
