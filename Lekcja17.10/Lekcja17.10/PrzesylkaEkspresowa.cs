using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17._10
{
    class PrzesylkaEkspresowa: Przesylka
    {
        private int czaswysylki;

        public PrzesylkaEkspresowa(int czaswysylki, string adresat, float waga):base (adresat, waga)
        {
            this.czaswysylki = czaswysylki;
        }

        public override float ObliczCene() //nadpisuje Cie
        {
            float cena = Waga * 5 + (15 - czaswysylki);
            return cena;
        }
    }
}
