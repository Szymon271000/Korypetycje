using System;

namespace Spr
{
    class Program
    {
        static void Main(string[] args)
        {
            Sprzedawca p1 = new Sprzedawca("Andzrej", "Mosakowski", 1, "25/12/2021", "Elektronika", 4999.99f);
            KierownikSprzedazy ks1 = new KierownikSprzedazy("Mariusz", "Nowak", 2, "01//06/2022", "Elektronika", 4999.99f, "Administrator", 0.30f);
            ks1.NoweWynagrodzenie();
            string a = p1.Wyswietl();
            string b = ks1.Wyswietl();
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
