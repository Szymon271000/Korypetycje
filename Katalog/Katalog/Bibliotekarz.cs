using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    class Bibliotekarz: Osoba
    {
        private DateTime dataZatrudnienia;
        private double wynagrodzenie;

        public Bibliotekarz(string imie, string nazwisko, DateTime dataZatrudnienia, double wynagrodzenie): base (imie, nazwisko)
        {
            this.dataZatrudnienia = dataZatrudnienia;
            this.wynagrodzenie = wynagrodzenie;
        }

        public override string ToString()
        {
            return $"Bibliotekarz: {Imie} {Nazwisko} {dataZatrudnienia.ToShortDateString()}";
        }
    }
}
