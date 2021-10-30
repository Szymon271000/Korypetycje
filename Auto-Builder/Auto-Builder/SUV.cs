using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Builder
{
    class SUV : SamochodBuilder
    {
        public SUV()
        {
            Samochod = new Samochod();
        }
        public override void DodajMarke()
        {
            Samochod.Marka = "BMW";
        }

        public override void DodajModel()
        {
            Samochod.Model = "X5";
        }

        public override void DodajRocznik()
        {
            Samochod.Rocznik = 2021;
        }

        public override void DodajSilnik()
        {
            Samochod.Silnik = "2.0 l 4-Zylinder Diesel";
        }

        public override void NadajCene()
        {
            Samochod.Cena = 200000.99f;
        }
    }
}
