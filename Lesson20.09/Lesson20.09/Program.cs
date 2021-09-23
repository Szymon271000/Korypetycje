using System;

namespace Lesson20._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat p = new Prostokat();
            p.dlugosc = 10;
            p.szerokosc = 100;
            p.kolor = "red";

            Console.WriteLine("Pole prostokata nr 1 wynosi: " + p.Pole());

            Prostokat p2 = new Prostokat();
            p2.dlugosc = 2;
            p2.szerokosc = 4;
            p2.kolor = "yellow";

            Console.WriteLine("Pole prostokata nr 2 wynosi: " + p2.Pole());

            Czlowiek Man1 = new Czlowiek();
            Man1.Imie = "Jan";
            Man1.Narodowosc = "Polska";
            Man1.Plec = 'M';
            Man1.Wzrost = 185;
            Man1.Zawod = "Programista Front-End";

            Console.WriteLine(Man1.PrzedstawSie());

            Czlowiek Woman = new Czlowiek();
            Woman.Imie = "Barbara";
            Woman.Narodowosc = "Polska";
            Woman.Plec = 'K';
            Woman.Wzrost = 168;
            Woman.Zawod = "Programista Back-End";

            Console.WriteLine(Woman.PrzedstawSie());

            Czlowiek c2 = new Czlowiek();
            Console.WriteLine(c2.PrzedstawSie());

            Prostokat p3 = new Prostokat();
            Console.WriteLine(p3.Pole());

            new Prostokat(); //tworzy nowy prostokat ale nie jest zapamietany w zadnej zmiennej, jednak kosntruktor sie wykona

            Prostokat p4 = new Prostokat(dl: 10, szer: 20, kol: "green");
            Console.WriteLine(p4.Pole());

            Czlowiek Man2 = new Czlowiek(Im: "Andrzej", Wzrost: 185, Za: "Malarz", Pl: 'M', Naro: "Polska");
            Console.WriteLine(Man2.PrzedstawSie());

            var t = new Towar(nrProduktu: 1, nazwa: "Mleko", cenaBrutto: 4);
            Console.WriteLine(t);

            Prostokat p5 = new Prostokat(dl: 5, szer: 15, kol: "yellow");
            Console.WriteLine(p5);

            Console.WriteLine();
            Kolo kolo = new Kolo(10);
            Console.WriteLine("Srednica kola wynosi: " + kolo.Srednica); //tutaj zadziala get
            Console.WriteLine("Pole kola wynosi: " + kolo.Pole); //tutaj zadziala get
            kolo.Srednica = 100; //tutaj zadziala set
            Console.WriteLine("Srednica kola wynosi: " + kolo.Srednica);
            Console.WriteLine("Pole kola wynosi: " + kolo.Pole);


            Console.WriteLine();
            Towar t2 = new Towar(2, "Cola", 6);
            Console.WriteLine(t2);
            t2.CenaNetto = 10;
            Console.WriteLine(t2);

            Console.WriteLine(kolo.Kolor);
        }
    }
}
