using System;
using System.Collections.Generic;

namespace Lekcja08._11_2_
{
    class Program
    {
        static void Pokaz<MojTyp>(List<MojTyp> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            List<string> slowa = new List<string>
            {
                "ala", "ma", "kota"
            };
            Pokaz(slowa);

            List<int> liczby = new List<int>() { 10, 20, 30, 40 };
            Pokaz(liczby);

            Stos<int> stos = new Stos<int>();
            stos.Push(10);
            stos.Push(20);
            stos.Push(30);

            Console.WriteLine(stos.Pop());
        }
    }
}
