using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Builder
{
    class Komis
    {
        public void MakeCar(SamochodBuilder samochodBuilder)
        {
            samochodBuilder.DodajMarke();
            samochodBuilder.DodajModel();
            samochodBuilder.DodajSilnik();
            samochodBuilder.DodajRocznik();
            samochodBuilder.NadajCene();
    }
    }
}
