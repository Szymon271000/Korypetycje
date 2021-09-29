using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszyk
{
    class Telefony
    {
        private string Model;
        private string Producent;
        private float Cena;

        public float Cena1 { get => Cena;
            set { 
                if (value > 0)
                {
                    value = Cena;
                }
            } 
        }

        public Telefony(string model, string producent, float cena)
        {
            Model = model;
            Producent = producent;
            Cena = cena;
        }

        public Telefony()
        {
            Model = "5";
            Producent = "Apple";
            Cena = 99.99f;
        }

        public override string ToString()
        {
            return $"Model {Model}, Producent {Producent}, Cena {Cena}";
        }
    }
}
