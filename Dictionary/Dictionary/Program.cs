using System;
using System.Collections.Generic;

namespace DictionaryLekcja
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> slownik = new Dictionary<string, string>();
            slownik.Add("dog", "pies");
            slownik.Add("cat", "kot");
            slownik.Add("mirror", "lustro");

            Console.WriteLine(slownik["dog"]);
            slownik["dog"] = "piesek"; //zmiana wartosci pod kluczem dog
            Console.WriteLine(slownik["dog"]);

            Console.WriteLine();
            foreach (var item in slownik)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Dictionary<string, Punkt> punkty = new Dictionary<string, Punkt>();
            punkty.Add("bohater", new Punkt(0, 0));
            punkty.Add("zamek", new Punkt(10, 5));
            punkty.Add("smok", new Punkt(50, 11));

            Punkt p = punkty["bohater"];
            Console.WriteLine(p.X + " " + p.X);
        }
    }
}
