using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    class Telefony
    {
        private string Model;
        private string Producent;
        private float Cena;

        public Telefony()
        {
            Model = "5";
            Producent = "Apple";
            Cena = 100.45f;

        }
        public Telefony(string model, string producent, float cena)
        {
            Model = model;
            Producent = producent;
            Cena = cena;
        }

        public override string ToString()
        {
            return $"Model {Model}, Producent: {Producent}, Cena {Cena}";
        }
    }
}
