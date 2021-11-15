using System;
using System.Collections.Generic;
using System.Linq;

namespace Lekcja15._11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liczby = new List<int>() { 10, 1, 8, 1, 6, 4, 7, 88, 10, 44, 3, 6, 9, };
            //List<int> list2 = new List<int>();
            //for (int i = 0; i < liczby.Count; i++)
            //{
            //    if (liczby[i] % 2 ==0)
            //    {
            //        list2.Add(liczby[i]);
            //    }
            //}

            List<int> parzyste = liczby.FindAll(liczba => liczba % 2 == 0); //znajdz wszystkie liczby ktore spelniaja zalozenie i utworz nowa liste
            parzyste.ForEach(liczba => Console.WriteLine(liczba));

            Console.WriteLine();

            List<int> list3 = liczby.FindAll(number => number >= 0 && number < 10);
            list3.ForEach(number => Console.WriteLine(number));
            Console.WriteLine();

            bool dodatnie = liczby.All(x => x >= 0); //czy wszsytkie liczby spelniaja zalozone x >= 0
            Console.WriteLine($"Dodatnie: {dodatnie}");

            int zJedynka = liczby.Count(x => x.ToString().Contains("1")); //zlicza wszystkie liczby ktora maja przynajmniej jedna jedynke
            Console.WriteLine(zJedynka);

            //czy istnieje przynamniej jedna wartosc wieksza od 10
            bool wiekszaOd10 = liczby.Any(x => x > 10);
            Console.WriteLine(wiekszaOd10);

            int suma = liczby.Sum(x => x * x); //podnosi kazda liczbe do kwadratu i sumuje
            int min = liczby.Min();
            int max = liczby.Max();

            Miasto m1 = new Miasto("Warszawa", 17.67);
            Miasto m2 = new Miasto("Kraków", 19.32);
            Miasto m3 = new Miasto("Wrocław", 22.31);
            Miasto m4 = new Miasto("Katowice", 17.77);
            Miasto m5 = new Miasto("Rzeszów", 24.16);
            Miasto m6 = new Miasto("Poznań", 19.86);

            List<Miasto> miasta = new List<Miasto>()
            {
                m1, m2, m3, m4, m5, m6
            };

            List<Miasto> ciepleMiasta = miasta.FindAll(x => x.Temperatura > 20);
            ciepleMiasta.ForEach(x => Console.WriteLine(x));

            double sum = miasta.Sum(x => x.Temperatura);
            double srednia = sum / miasta.Count;
            Console.WriteLine(srednia);

            Miasto po = miasta.Find(x => x.Nazwa == "Poznań");
            Console.WriteLine(po);

            double max2 = miasta.Max(x => x.Temperatura);
            Console.WriteLine(max2);

            //jak zamienic liste miast na liste samych temperatur
            List<double> temperatury = miasta.Select(x => x.Temperatura).ToList(); //select zamienia jeden typ w drugi
            List<string> nazwy = miasta.Select(x => x.Nazwa).ToList();

            
        }
    }
}
