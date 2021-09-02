using System;

namespace Dawaj_pasy
{
    class Program
    {
        static void Main(string[] args)
        {
            string right_passwrod = "1234";
            Console.Write("Podaj haslo: ");
            string prove = Console.ReadLine();
            if (prove != right_passwrod)
            {
                Console.WriteLine("Niepoprawne!");
            }
            while (prove != right_passwrod)
            {
                Console.Write("Podaj haslo: ");
                prove = Console.ReadLine();
                if (prove != right_passwrod)
                {
                    Console.WriteLine("Niepoprawne!");
                }
            }
            Console.WriteLine("Ok, zalogowano do systemu");
        }
    }
}
