using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spr
{
    class Sprzedawca
    {
        private string imie;
        private string nazwisko;
        private int kodSprzedawcy;
        private string endDate;
        private string dzial;
        private float wynagrodzenie;

        public Sprzedawca(string imie, string nazwisko, int kodSprzedawcy, string endDate, string dzial, float wynagrodzenie)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.KodSprzedawcy = kodSprzedawcy;
            this.EndDate = endDate;
            this.Dzial = dzial;
            this.Wynagrodzenie = wynagrodzenie;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public int KodSprzedawcy { get => kodSprzedawcy; set => kodSprzedawcy = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public string Dzial { get => dzial; set => dzial = value; }
        public virtual float Wynagrodzenie { get => wynagrodzenie; set => wynagrodzenie = value; }

        public virtual string Wyswietl()
        {
            string wynik = $"Sprzedawca: {Imie} ,{Nazwisko}, {KodSprzedawcy}, {EndDate}, {Dzial}, {Wynagrodzenie}";
            return wynik;
        }
    }
}
