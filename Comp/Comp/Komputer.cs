using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    class Komputer
    {
        private string producent;
        private string model;
        private string plytaGlowna;
        private string procesor;
        private string kartaGraficzna;
        private int dyskTwardy;

        public string Producent { get => producent; set => producent = value; }
        public string Model { get => model; set => model = value; }
        public string PlytaGlowna { get => plytaGlowna; set => plytaGlowna = value; }
        public string Procesor { get => procesor; set => procesor = value; }
        public string KartaGraficzna { get => kartaGraficzna; set => kartaGraficzna = value; }
        public int DyskTwardy { get => dyskTwardy; set => dyskTwardy = value; }

        public Komputer(string producent, string model, string plytaGlowna, string procesor, string kartaGraficzna, int dyskTwardy)
        {
            this.Producent = producent;
            this.Model = model;
            this.PlytaGlowna = plytaGlowna;
            this.Procesor = procesor;
            this.KartaGraficzna = kartaGraficzna;
            this.DyskTwardy = dyskTwardy;
        }

        public Komputer()
        {
            Producent = "Lenovo";
            Model = "P565";
            PlytaGlowna = "MSI H510M-A PRO (LGA 1200)";
            Procesor = "Intel Core i3-10105F";
            KartaGraficzna = "XFX Radeon RX 5600 XT 6GB Thicc II Pro";
            DyskTwardy = 500;
        }

        public virtual string Wyswietl()
        {
            string wynik = $"Komputer: {Producent}, {Model}, {PlytaGlowna}, {Procesor}, {KartaGraficzna}, {DyskTwardy}";
            return wynik;
        }
    }
}
