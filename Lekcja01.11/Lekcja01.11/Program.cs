using System;
using System.Collections.Generic;

namespace Lekcja01._11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Devil devil1 = new Devil("Red", 100, 10);
            Devil devil2 = new Devil("Black", 150, 20);
            Demon demon1 = new Demon("Neder", 90);

            Spawn spawn1 = new Spawn();
            spawn1.Add(devil1);
            spawn1.Add(devil2);
            spawn1.Add(demon1);
            Monster m1 = spawn1.create("Red");
            Console.WriteLine(m1);

            int newHp = devil1.Hp * 2;
            devil1.Hp = newHp;
            Monster m2 = spawn1.create("Red");
            Console.WriteLine(m2);
            Console.WriteLine();
            Console.WriteLine(m1);

            Dictionary<string, float> miasta = new Dictionary<string, float>();
            miasta.Add("Warszawa", 17.67f);
            miasta.Add("Kraków", 19.32f);
            miasta.Add("Wroclaw", 22.31f);
            miasta.Add("Katowice", 17.77f);
            miasta.Add("Rzeszow", 24.16f);
            miasta.Add("Poznan", 19.86f);

            foreach (var miasto in miasta)
            {
                if (miasto.Value > 20)
                {
                    Console.WriteLine(miasto);
                }
            }

        }
    }
}
