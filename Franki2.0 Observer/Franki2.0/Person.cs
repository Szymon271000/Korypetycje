using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franki2._0
{
    class Person: IZainteresowany
    {
        private string imie;
        private string nazwisko;
        private int kwota;

        public Person(string imie, string nazwisko, int kwota)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Kwota = kwota;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public int Kwota { get => kwota; set => kwota = value; }

        public void ZmianaKursu(double przelicznik)
        {
            Console.WriteLine($"Zmiana wartosci na {przelicznik}, aktualna wartosc kredytu w zl dla {Imie} {Nazwisko} to : {Math.Round(Kwota * przelicznik)} zl");
        }
    }
}
