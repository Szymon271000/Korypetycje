using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja11._10Dziecinienie
{
    enum Procesor { QualcommSnapdragon888, HuaweiHiSiliconKirin90005G, SamsungExynos2100, AppleA14Bionic};
    class Telefon: Produkt
    {
        private Procesor procesor;
        private string system;
        private int ram;
        private int pamiec;
        private int kamerampx;

        public Telefon(string marka, float cena, string nazwa, int id, int gwarancja, Procesor procesor, string system, int ram, int pamiec, int kamerampx): base(marka, cena, nazwa, id, gwarancja)
        {
            this.Procesor = procesor;
            this.System = system;
            this.Ram = ram;
            this.Pamiec = pamiec;
            this.Kamerampx = kamerampx;
        }

        public string System { get => system; set => system = value; }
        public int Ram { get => ram; set => ram = value; }
        public int Pamiec { get => pamiec; set => pamiec = value; }
        public int Kamerampx { get => kamerampx; set => kamerampx = value; }
        internal Procesor Procesor { get => procesor; set => procesor = value; }

        public override string ToString()
        {
            return $"Telefon: {Marka}, {Cena}, {Nazwa}, {Id}, {Gwarancja}, {Procesor}, {system}, {ram}, {pamiec}, {kamerampx}";
        }
    }
}
