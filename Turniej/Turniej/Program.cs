using System;

namespace Turniej
{
    class Program
    {
        static void Main(string[] args)
        {
            Gracz g = new Gracz ("Ada", "Kowalska", 845);
            Gracz g2 = new Gracz ("Ola", "Nowak", 574);
            Gracz g3 = new Gracz ("Ala", "Piekarz", 111);

            Turniej t = new Turniej("Zawody 2k21");
            t.AddGracz(g);
            t.AddGracz(g2);
            t.AddGracz(g3);

            Console.WriteLine(t);

            Gracz Zwyciezcza = t.Zwyciezca();
            Console.WriteLine(Zwyciezcza);
        }
    }
}
