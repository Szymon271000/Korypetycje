using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja28._10
{
    class PepperoniBuilder : PizzaBuilder
    {
        public PepperoniBuilder()
        {
            Pizza = new Pizza();
        }

        public override void DodajNazwe()
        {
            Pizza.Nazwa = "Pepperoni";
        }

        public override void DodajSkladniki()
        {
            Pizza.IloscPepperoni = 8;
            Pizza.IloscSzynka = 5;
            Pizza.IloscSer = 4;
        }

        public override void DodajSos()
        {
            Pizza.Sos = "Czerwony sos";
        }

        public override void NadajCene()
        {
            Pizza.Cena = 19.99f;
        }
    }
}
