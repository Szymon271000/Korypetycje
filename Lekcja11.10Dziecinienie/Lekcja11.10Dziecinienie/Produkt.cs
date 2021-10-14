using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja11._10Dziecinienie
{
    class Produkt
    {
        private string marka;
        private float cena;
        private string nazwa;
        private int id;
        private int gwarancja;

        public Produkt(string marka, float cena, string nazwa, int id, int gwarancja)
        {
            this.Marka = marka;
            this.Cena = cena;
            this.Nazwa = nazwa;
            this.Id = id;
            this.Gwarancja = gwarancja;
        }

        public string Marka { get => marka; set => marka = value; }
        public float Cena { get => cena; set => cena = value; }
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int Id { get => id; set => id = value; }
        public int Gwarancja { get => gwarancja; set => gwarancja = value; }

        public override string ToString()
        {
            return $"{Marka}, {Nazwa}, {Cena} "; 
        }
    }
}
