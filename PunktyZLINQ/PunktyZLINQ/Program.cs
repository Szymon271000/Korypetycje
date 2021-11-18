using System;
using System.Collections.Generic;
using System.Linq;

namespace PunktyZLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            

            Punkt[] punkts = new Punkt[100];


            for (int i = 0; i < punkts.Length; i++)
            {
                int number = rnd.Next(-20, 21);
                int number2 = rnd.Next(-20, 21);
                punkts[i] = new Punkt(number, number2);
            }

            List<Punkt> punkty = new List<Punkt>();
            for (int i = 0; i < punkts.Length; i++)
            {
                punkty.Add(punkts[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < punkty.Count; i++)
            {
                Console.WriteLine(punkty[i]);
            }

            int p1 = punkty.Count(x => x.X > 0 && x.Y > 0); // spytac czy tylko >0 czy >=0
            int p2 = punkty.Count(x => x.X < 0 && x.Y > 0);
            int p3 = punkty.Count(x => x.X < 0 && x.Y < 0);
            int p4 = punkty.Count(x => x.X > 0 && x.Y < 0);

            List<Punkt> dwacyfry = punkty.FindAll(x => x.X >= 10 && x.Y >= 10);

            bool rowna20 = punkty.Any(x => x.X == -20 && x.Y < 0);


            List<string> xs = punkty.Select(x => x.X.ToString()).ToList(); 
            List<string> ys = punkty.Select(x => x.Y.ToString()).ToList();

            for (int i = 0; i < xs.Count; i++)
            {
                Console.WriteLine($"{xs[i]}, {ys[i]}");
            }
        }
    }
}
