using System;
using System.IO;
using System.Xml.Serialization;

namespace Koszyk
{
    class Program
    {
        static Koszyk Deserializuj(string nazwaPliku)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Koszyk));
            StreamReader reader = new StreamReader(nazwaPliku);
            Koszyk wczytany = xmlSerializer.Deserialize(reader) as Koszyk;
            reader.Close();
            return wczytany;
        }
        static void Main(string[] args)
        {
            Telefon T1 = new Telefon(model: "13", producent: "Apple", cena: 1499.99f);
            Telefon T2 = new Telefon(model: "12", producent: "Apple", cena: 1299.99f);
            Telefon T3 = new Telefon(model: "11", producent: "Apple", cena: 1099.99f);
            Telefon T4 = new Telefon(model: "X", producent: "Apple", cena: 999.99f);
            Telefon T5 = new Telefon(model: "8", producent: "Apple", cena: 749.99f);

            Koszyk Koszyk1 = new Koszyk();
            Koszyk1.Telefonies.Add(T1);
            Koszyk1.Telefonies.Add(T2);
            Koszyk1.Telefonies.Add(T3);
            Koszyk1.Telefonies.Add(T4);
            Koszyk1.Telefonies.Add(T5);
            Console.WriteLine(Koszyk1);
            Koszyk1.SaveXML("koszyk.xml");

            float Suma = Koszyk1.Suma();
            Console.WriteLine(Suma);

            Koszyk Koszyk2 = Deserializuj("koszyk.xml");
            Console.WriteLine(Koszyk2);
        }
    }
}
