using System;
using System.IO;
using System.Xml.Serialization;

namespace Turniej
{
    class Program
    {
        public static object Streamreader { get; private set; }

        static Turniej Deserializuj(string nazwaPliku)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Turniej));
            StreamReader reader = new StreamReader(nazwaPliku);
            Turniej wczytany = xmlSerializer.Deserialize(reader) as Turniej;
            reader.Close();
            return wczytany;
        }

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
            t.SaveXML("turniej.xml");

            Gracz Zwyciezcza = t.Zwyciezca();
            Console.WriteLine(Zwyciezcza);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
