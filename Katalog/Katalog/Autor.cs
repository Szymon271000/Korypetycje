using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    class Autor: Osoba
    {
        private string narodowosc;

        public Autor(string imie, string nazwisko, string narodowosc): base (imie, nazwisko)
        {
            this.narodowosc = narodowosc;
        }

        public override string ToString()
        {
            return $"Auto nazywa sie {Imie} {Nazwisko} {narodowosc}";
        }
    }
}
