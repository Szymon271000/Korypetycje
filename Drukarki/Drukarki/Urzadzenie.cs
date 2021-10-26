using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drukarki
{
    class Urzadzenie
    {
        private string marka;
        private string model;

        public Urzadzenie(string marka, string model)
        {
            this.Marka = marka;
            this.Model = model;
        }

        public string Marka { get => marka;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    marka = value;
                }
            } 
        }
        public string Model { get => model; 
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    model = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Urzadzenie: {model}, {marka}";
        }
    }
}
