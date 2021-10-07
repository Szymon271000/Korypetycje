using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszyk
{
    public class Telefon
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

        public string Model1 { get => Model; set => Model = value; }
        public string Producent1 { get => Producent; set => Producent = value; }

        public Telefon(string model, string producent, float cena)
        {
            Model1 = model;
            Producent1 = producent;
            Cena = cena;
        }

        public Telefon()
        {
            Model1 = "5";
            Producent1 = "Apple";
            Cena = 99.99f;
        }

        public override string ToString()
        {
            return $"Model {Model1}, Producent {Producent1}, Cena {Cena}";
        }
    }
}
