using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja11._10Dziecinienie
{
    enum TypMatrycy { IPS, MVA, VA, TN }
    class Monitor: Produkt
    {
        private string rodzaj;
        private float przekatna;
        private TypMatrycy typmatrycy;

        public Monitor(string marka, float cena, string nazwa, int id, int gwarancja, string rodzaj, float przekatna, TypMatrycy typmatrycy): base(marka, cena, nazwa, id, gwarancja)
        {
            this.Rodzaj = rodzaj;
            this.Przekatna = przekatna;
            this.Typmatrycy = typmatrycy;
        }

        public string Rodzaj { get => rodzaj; set => rodzaj = value; }
        public float Przekatna { get => przekatna; set => przekatna = value; }
        internal TypMatrycy Typmatrycy { get => typmatrycy; set => typmatrycy = value; }

        public override string ToString()
        {
            return $"Monitor: {Marka}, {Cena}, {Nazwa}, {Id}, {Gwarancja}, {Rodzaj}, {Przekatna}, {typmatrycy} ";
        }
    }
}
