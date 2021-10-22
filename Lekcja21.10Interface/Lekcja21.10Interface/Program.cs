using System;
using System.Collections.Generic;

namespace Lekcja21._10Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight k = new Knight(15, 5);
            Wieza w = new Wieza();
            Druid d = new Druid("Janek");

            List<IObrona> obroncy = new List<IObrona>() { k, w, d };
            List<IAtak> atakujacy = new List<IAtak>() { k, w };

            foreach (var napastnik in atakujacy)
            {
                foreach (var obronca in obroncy)
                {
                    napastnik.Atakuj(obronca);
                }
            }
        }
    }
}
