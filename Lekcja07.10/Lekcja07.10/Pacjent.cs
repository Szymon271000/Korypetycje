using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja07._10
{
    class Pacjent : Czlowiek
    {
        private string choroba;

        public Pacjent(string choroba ,string imie, string nazwisko, int wiek, string oddzial) :base(imie, nazwisko, wiek, oddzial)
        {
            this.choroba = choroba;
        }

        public override string ToString()
        {
            return $"Pacjent ma na imie {imie} {nazwisko} ma {wiek} lat i jest na {oddzial} {choroba}";
        }
    }
}
