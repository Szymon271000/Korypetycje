using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Builder
{
    abstract class SamochodBuilder
    {
        private Samochod samochod;

        internal Samochod Samochod { get => samochod; set => samochod = value; }

        public abstract void DodajMarke();
        public abstract void DodajModel();
        public abstract void DodajSilnik();
        public abstract void DodajRocznik();
        public abstract void NadajCene();
    }
}
