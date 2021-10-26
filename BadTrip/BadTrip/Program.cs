using System;
using System.Collections.Generic;

namespace BadTrip
{

    
    class Program
    {
        static bool Sprwadz(List<ICzujnik> czujniks)
        {
            for (int i = 0; i < czujniks.Count; i++)
            {
                if (czujniks[i].Alarm())
                {
                    return true;
                }
            }
                return false;
            
        }
        static void Main(string[] args)
        {
            Silnik s = new Silnik(10000, 4);
            RurkaPilota rurkaPilota = new RurkaPilota(new DateTime(2015, 10, 02, 15, 30, 0), 3);
            APU apu = new APU(true);

            List<ICzujnik> u = new List<ICzujnik>();
            u.Add(s);
            u.Add(rurkaPilota);
            u.Add(apu);
            bool wynik = Sprwadz(u);
            Console.WriteLine(wynik);
        }
    }
}
