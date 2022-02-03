using System;
using System.IO;

namespace Lekcja03._02
{
    class Program
    {
        static int Dodawanie(int a, int b)
        {
            return a + b;
        }
        static int Odejmowanie(int a, int b)
        {
            return a - b;
        }

        static int Mnozenie(int a, int b)
        {
            return a * b;
        }


        delegate int Operacja(int x, int y);

        public static bool TylkoWroclaw(Adres adres)
        {
            return adres.Miasto == "Wroclaw";
        }

        static void ShowAdres(Adres adres)
        {
            Console.WriteLine(adres);
        }

        static void AppendToFile(Adres adres)
        {
            File.AppendAllText("result.txt", adres + "\n");
        }

        static void Main(string[] args)
        {
            //Operacja[] op = new Operacja[]
            //{
            //    Dodawanie,
            //    Odejmowanie,
            //    Mnozenie,
            //    (a, b) => a/b //funkcja anonimowa, wyraznie lambda, a, b - argumenty, a/b - wynik
            //};
            //Console.WriteLine("Podaj liczbe 1");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj liczbe 2");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj nr operacji");
            //int nr = int.Parse(Console.ReadLine());
            //Console.WriteLine("Wynik: " + op[nr](a, b));

            string[] ulicy = new string[]
            {
                "Ulica Krakowska",
                "Ulica Warszawka",
                "Ulica Pomorksa",
                "Aleja Slowackiego"
            };

            int[] nrMieszkan = new int[]
            {
                1,2,3,4,5,6,7,7
            };

            string[] miasta = new string[]
            {
                "Krakow",
                "Warszawa",
                "Gdansk",
                "Wroclaw"
            };

            Random rnd = new Random();
            KsiazkaAdresow ksiazkaAdresow = new KsiazkaAdresow();

            int ilosc = 0;
            ksiazkaAdresow.OnAdresAdded += ShowAdres;
            ksiazkaAdresow.OnAdresAdded += AppendToFile;
            ksiazkaAdresow.OnAdresAdded += adres => ilosc++;

            for (int i = 0; i < 30; i++)
            {
                int ulicylosowo = rnd.Next(0, ulicy.Length);
                int nrMieszkanialosowo = rnd.Next(0, nrMieszkan.Length);
                int miastalosowo = rnd.Next(0, miasta.Length);
                Adres adres = new Adres(ulicy[ulicylosowo], nrMieszkan[nrMieszkanialosowo], miasta[miastalosowo]);     
                ksiazkaAdresow.Dodaj(adres);
            }

            Console.WriteLine($"Ilosc dodanych ksiazek: {ilosc}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ksiazkaAdresow);
            Console.WriteLine();
            var wynikLista = ksiazkaAdresow.FindAll(TylkoWroclaw);
            Console.WriteLine(wynikLista.ElementsToString());

            Console.WriteLine();
            Console.WriteLine();
            wynikLista = ksiazkaAdresow.FindAll(adres => adres.Miasto == "Warszawa" && adres.NrMieszkania % 2 == 0);
            Console.WriteLine(wynikLista.ElementsToString());
        }
    }
}
