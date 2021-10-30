using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Builder
{
    class Samochod
    {
        private string marka;
        private string model;
        private string silnik;
        private int rocznik;
        private float cena;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Silnik { get => silnik; set => silnik = value; }
        public int Rocznik { get => rocznik; set => rocznik = value; }
        public float Cena { get => cena; set => cena = value; }

        public override string ToString()
        {
            return $"Samochod {marka} {model} {silnik} {rocznik} {cena}";
        }
    }

}
