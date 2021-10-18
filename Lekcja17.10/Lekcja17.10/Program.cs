using System;
using System.Collections.Generic;

namespace Lekcja17._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Przesylka p1 = new Przesylka("Andrzej", 5.2f);
            Przesylka p2 = new Przesylka("Lukasz", 4.2f);
            PrzesylkaEkspresowa p3 = new PrzesylkaEkspresowa(2, "Szymon", 7.5f);
            PrzesylkaEkspresowa p4 = new PrzesylkaEkspresowa(2, "Hubert", 10);

            List<Przesylka> przesylki = new List<Przesylka>();
            przesylki.Add(p1);
            przesylki.Add(p2);
            przesylki.Add(p3);
            przesylki.Add(p4);

            float suma = 0;
            for (int i = 0; i < przesylki.Count; i++)
            {
                Console.WriteLine($"Przesylka {i} kosztuje : {przesylki[i].ObliczCene()}");
                suma = suma + przesylki[i].ObliczCene();
            }
            Console.WriteLine(suma);
        }
    }
}
