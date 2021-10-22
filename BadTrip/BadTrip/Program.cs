using System;
using System.Collections.Generic;

namespace BadTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            Silnik s = new Silnik(10000, 4);
            RurkaPilota rurkaPilota = new RurkaPilota("19/02/2015", 3);
            APU apu = new APU(true);

            List<ICzujnik> u = new List<ICzujnik>();
            u.Add(s);
            u.Add(rurkaPilota);
            u.Add(apu);
        }
    }
}
