using System;

namespace Lekcja25._10
{
    class Program
    {
        static int pobierzInt()
        {
            Console.WriteLine("Podaj liczbe");
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            bool koniec = false;
            int i = 0;
            float suma = 0;
            while(koniec == false)
            {
                try
                {
                    int pobranaLiczba = pobierzInt();
                    i++;
                    suma += pobranaLiczba;
                }
                catch(FormatException)
                {
                    koniec = true;
                }
            }
            if(i != 0)
            {
                Console.WriteLine(suma / i);
            }
        }
    }
}
