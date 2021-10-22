using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    class Laptop:Komputer
    {
        private float waga;
        private string bateria;
        private bool bluetooth;

        public Laptop(string producent, string model, string plytaGlowna, string procesor, string kartaGraficzna, int dyskTwardy, float waga, string bateria, bool bluetooth): base (producent, model, plytaGlowna, procesor, kartaGraficzna, dyskTwardy)
        {
            this.Waga = waga;
            this.bateria = bateria;
            this.bluetooth = bluetooth;
        }

        public Laptop()
        {
            Producent = "HP";
            Model = "P45";
            PlytaGlowna = "MSI B560M PRO-VDH WIFI (LGA 1200)";
            Procesor = "Intel Core i5-10400F (LGA 1200)";
            KartaGraficzna = "Sapphire Radeon RX 5700 XT Pulse";
            DyskTwardy = 750;
            waga = 1.5f;
            bateria = "Dell Latitude E6440";
            bluetooth = true;
        }

        public float Waga
        {
            get => waga;
            set
            {
                if ((value >= 1.2) && (value <= 3.5))
                {
                    waga = value;
                }
                else
                {
                    Console.WriteLine("Laptop za ciezki");
                }
            }
        }
        public override string Wyswietl()
        {
            string wynik = $"Laptop: {Producent}, {Model}, {PlytaGlowna}, {Procesor}, {KartaGraficzna}, {DyskTwardy}, {waga}, {bateria}, {bluetooth}";
            return wynik;
        }

    }  

}

