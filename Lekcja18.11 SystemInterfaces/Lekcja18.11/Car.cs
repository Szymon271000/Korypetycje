using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._11
{
    class Car : IComparable<Car>
    {
        private string marka;
        private string model;
        private double cena;
        private DateTime rocznik;

        public Car(string marka, string model, double cena, DateTime rocznik)
        {
            this.Marka = marka;
            this.Model = model;
            this.Cena = cena;
            this.Rocznik = rocznik;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public double Cena { get => cena; set => cena = value; }
        public DateTime Rocznik { get => rocznik; set => rocznik = value; }

        public int CompareTo(Car other)
        {
           // return cena.CompareTo(other.cena); //rosnaco
            return other.cena.CompareTo(cena); //malejaco
        }

        public override string ToString()
        {
            return $"Samochod {marka} {model} z {rocznik} roku kosztuje: {cena}";
        }
    }
}
