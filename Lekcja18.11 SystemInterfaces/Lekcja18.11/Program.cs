using System;
using System.Collections.Generic;
using System.Linq;

namespace Lekcja18._11
{
    class Program
    {
        static IEnumerable<int> Losuj(int ile)
        {
            Random rand = new Random();
            for (int i = 0; i < ile; i++)
            {
                yield return rand.Next(0, 21);
            }
        }
        static void Main(string[] args)
        {
            //Car c1 = new Car("Audi", "A4", 80000, new DateTime(2015, 06, 06));
            //Car c2 = new Car("BMW", "4erReihe", 100000, new DateTime(2017,08,01));
            //Car c3 = new Car("Fiat", "Punto", 40000, new DateTime(2018, 09, 01));
            //Car c4 = new Car("Peugeout", "407", 50000, new DateTime(2019, 10, 01));

            //Komis k1 = new Komis();
            //k1.Add(c1);
            //k1.Add(c2);
            //k1.Add(c3);
            //k1.Add(c4);

            Random rand = new Random();
            List<string> marki = new List<string>() { "BMW", "Opel", "Fiat", "Audi", "Renault", "Citroen", "Kia" };
            List<string> modele = new List<string>() { "Z4", "407", "Golf", "A5", "A4", "Ceed" };

            Komis k = new Komis();
            for (int i = 0; i < 15; i++)
            {
                string marka = marki[rand.Next(0, marki.Count)];
                string model = modele[rand.Next(0, modele.Count)];
                int cena = rand.Next(50000, 350000);
                DateTime data = new DateTime(rand.Next(2000, 2022), rand.Next(1, 13), rand.Next(1, 25));
                Car c = new Car(marka, model, cena, data);
                k.Add(c);
            }

            Console.WriteLine(k);
            //k.Sortuj();
            k.SortujPoNazwie();
            Console.WriteLine();
            Console.WriteLine(k);


            Notatnik n = new Notatnik();
            n.DodajLinie("ala ma");
            n.DodajLinie("kota");
            n = null;
            GC.Collect();

            Console.WriteLine();
            foreach (var item in k)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in k.ByMarka("Audi"))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            foreach (var item in Losuj(5))
            {
                Console.WriteLine(item);
            }

            var lista = Losuj(10).ToList();
        }
    }
}
