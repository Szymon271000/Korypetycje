using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja05._10
{
    public class Telefon
    {
        private string model;
        private string producent;
        private float cena;

        public float Cena1
        {
            get => Cena;
            set
            {
                if (value > 0)
                {
                    value = Cena;
                }
            }
        }

        public string Model { get => model; set => model = value; }
        public string Producent { get => producent; set => producent = value; }
        public float Cena { get => cena; set => cena = value; }

        public Telefon(string model, string producent, float cena)
        {
            this.Model = model;
            this.Producent = producent;
            this.Cena = cena;
        }

        public Telefon()
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
