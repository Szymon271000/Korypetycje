using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja28._10
{
    class Pizza
    {
        private string nazwa;
        private int iloscPepperoni;
        private int iloscSer;
        private string sos;
        private int iloscSzynka;
        private int iloscPomidor;
        private float cena;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int IloscPepperoni { get => iloscPepperoni; set => iloscPepperoni = value; }
        public int IloscSer { get => iloscSer; set => iloscSer = value; }
        public string Sos { get => sos; set => sos = value; }
        public int IloscSzynka { get => iloscSzynka; set => iloscSzynka = value; }
        public int IloscPomidor { get => iloscPomidor; set => iloscPomidor = value; }
        public float Cena { get => cena; set => cena = value; }

        public override string ToString()
        {
            return $"Pizza {nazwa} {iloscPepperoni} {iloscSer} {sos} {iloscSzynka} {iloscPomidor} {cena}";
        }
    }
}
