using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Builder
{
    class RodzinnySamochod : SamochodBuilder
    {
        public RodzinnySamochod()
        {
            Samochod = new Samochod();
        }
        public override void DodajMarke()
        {
            Samochod.Marka = "Volkswagen";
        }

        public override void DodajModel()
        {
            Samochod.Model = "Passat";
        }

        public override void DodajRocznik()
        {
            Samochod.Rocznik = 2019;
        }

        public override void DodajSilnik()
        {
            Samochod.Silnik = "2.0 Liter-TDI";
        }

        public override void NadajCene()
        {
            Samochod.Cena = 85000.99f;
        }
    }
}
