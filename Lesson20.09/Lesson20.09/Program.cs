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

            Prostokat p2 = new Prostokat();
            p2.dlugosc = 2;
            p2.szerokosc = 4;
            p2.kolor = "yellow";

            Czlowiek Man1 = new Czlowiek();
            Man1.Imie = "Jan";
            Man1.Narodowosc = "Polska";
            Man1.Plec = 'M';
            Man1.Wzrost = 185;
            Man1.Zawod = "Programista Front-End";

            Czlowiek Woman = new Czlowiek();
            Woman.Imie = "Barbara";
            Woman.Narodowosc = "Polska";
            Woman.Plec = 'K';
            Woman.Wzrost = 168;
            Woman.Zawod = "Programista Back-End";
        }
    }
}
