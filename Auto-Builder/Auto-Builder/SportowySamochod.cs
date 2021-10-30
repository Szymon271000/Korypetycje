using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Builder
{
    class SportowySamochod : SamochodBuilder
    {
        public SportowySamochod()
        {
            Samochod = new Samochod();
        }
        public override void DodajMarke()
        {
            Samochod.Marka = "Ferrari";
        }

        public override void DodajModel()
        {
            Samochod.Model = "California";
        }

        public override void DodajRocznik()
        {
            Samochod.Rocznik = 2018;
        }

        public override void DodajSilnik()
        {
            Samochod.Silnik = "V8 modello F136IB";
        }

        public override void NadajCene()
        {
            Samochod.Cena = 400000.99f;
        }
    }
}
