using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17._10
{
    class Przesylka
    {
        private string adresat;
        private float waga;

        public Przesylka(string adresat, float waga)
        {
            this.Adresat = adresat;
            this.Waga = waga;
        }

        public string Adresat { get => adresat; set => adresat = value; }
        public float Waga { get => waga; set => waga = value; }

        public virtual float ObliczCene() //virtual = nadpisz mnie/ w klasie pochodnej mozna zmienic znaczenie tej funkcji
        {
            float cena = Waga * 5;
            return cena;
        }

        public override string ToString()
        {
            return $"Paczka na {adresat}, kosztuje {ObliczCene()}";
        }
    }
}
