using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja28._10
{
    class WarzywnaBuilder : PizzaBuilder
    {
        public WarzywnaBuilder()
        {
            Pizza = new Pizza();
        }
        public override void DodajNazwe()
        {
            Pizza.Nazwa = "Warzywna";
        }

        public override void DodajSkladniki()
        {
            Pizza.IloscPomidor = 9;
            Pizza.IloscSer = 8;
            Pizza.IloscSzynka = 3;
        }

        public override void DodajSos()
        {
            Pizza.Sos = "Sos czosnkowy";
        }

        public override void NadajCene()
        {
            Pizza.Cena = 22.99f;
        }
    }
}
