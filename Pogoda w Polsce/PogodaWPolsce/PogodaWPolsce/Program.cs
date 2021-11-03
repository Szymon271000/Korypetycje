using System;
using System.Collections.Generic;
using System.Linq;

namespace PogodaWPolsce
{
    class Program
    {
        static void Main(string[] args)
        {
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

            float srednia = 0;
            foreach (var miasto in miasta)
            {
                srednia = srednia + miasto.Value;
            }
            Console.WriteLine(srednia / miasta.Count);

            foreach (var miasto in miasta)
            {
                if (miasto.Value < 19.86)
                {
                    Console.WriteLine(miasto);
                }
            }

            float max = float.MinValue;
            foreach (var miasto in miasta)
            {
                if (miasto.Value > max)
                {
                    max = miasto.Value;
                }
            }
            Console.WriteLine(max);

            float min = float.MaxValue;
            foreach (var miasto in miasta)
            {
                if (miasto.Value < min)
                {
                    min = miasto.Value;
                }
            }
            Console.WriteLine(min);

            Console.WriteLine();
            foreach (var ordered in miasta.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine(ordered.Value);
            }
            
        }
    }
}
