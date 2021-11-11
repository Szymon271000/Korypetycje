using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    class Czasopismo: Pozycja
    {
        private int numer;

        public Czasopismo(string tytul, int id, string wydawnictwo, int rokWydania, int numer): base (tytul, id, wydawnictwo , rokWydania)
        {
            this.Numer = numer;
        }

        public int Numer { get => numer; set => numer = value; }

        public override void WypiszInfo()
        {
            Console.WriteLine($"Ksiazka: {Tytul} {Id} {Wydawnictwo} {RokWydania} {numer} ");
        }

    }
}
