using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Samochod
    {
        private string marka;
        private string model;
        private DateTime rejestracja;

        public Samochod(string marka, string model, DateTime rejestracja)
        {
            this.Marka = marka;
            this.Model = model;
            this.Rejestracja = rejestracja;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public DateTime Rejestracja { get => rejestracja; set => rejestracja = value; }

        public override string ToString()
        {
            return $"Samochod: {marka} {model} {rejestracja}";
        }
    }
}
