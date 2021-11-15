using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja15._11
{
    class Miasto
    {
        private string nazwa;
        private double temperatura;

        public Miasto(string nazwa, double temperatura)
        {
            this.Nazwa = nazwa;
            this.Temperatura = temperatura;
        }

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public double Temperatura { get => temperatura; set => temperatura = value; }

        public override string ToString()
        {
            return $"Miasto {nazwa} ma {temperatura} C";
        }
    }
}
