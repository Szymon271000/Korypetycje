using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spr
{
    class KierownikSprzedazy: Sprzedawca
    {

        private string uprawnienia;
        private float dodatek;

        public override float Wynagrodzenie { get => base.Wynagrodzenie + (Wynagrodzenie * dodatek); set => base.Wynagrodzenie = value; }

        public KierownikSprzedazy(string imie, string nazwisko, int kodSprzedawcy, string endDate, string dzial, float wynagrodzenie, string uprawnienia, float dodatek):base(imie, nazwisko, kodSprzedawcy, endDate, dzial, wynagrodzenie)
        {
            this.uprawnienia = uprawnienia;
            this.dodatek = dodatek;
        }

        public override string Wyswietl()
        {
            string wynik = $"{base.Wyswietl()} {uprawnienia}, {dodatek}";
            return wynik;
        }
    }
}
