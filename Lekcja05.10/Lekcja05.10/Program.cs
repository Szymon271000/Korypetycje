using System;
using System.IO;
using System.Xml.Serialization;

namespace Lekcja05._10
{
    class Program
    {
        static Client Deserializuj(string nazwaPliku)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Client));
            StreamReader reader = new StreamReader(nazwaPliku); //odczytuje plik
            Client wczytany = xmlSerializer.Deserialize(reader) as Client; //ta funkcja zwraca nowy obiekt zaladowany z pliku w wyniku serializacji
            reader.Close();
            return wczytany;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            Punkt[] punkty = new Punkt[10];
            punkty[0] = new Punkt(1, 5);

            for(int i = 1; i < punkty.Length; i++)
            {
                int x = rand.Next(1, 10);
                int y = rand.Next(1, 10);
                punkty[i] = new Punkt(x, y);
            }

            //item == punkty[0]
            //item == punkty[1]
            // ....
            //item == punkty[9]
            //foreach - co okrazenie petli wklasa do zmiennej item kolejny obiekt z tablicy
            foreach (var item in punkty)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            for(int i = 0; i < punkty.Length; i++)
            {
                Punkt item = punkty[i];
                Console.WriteLine(item);
            }


            //Serializacja - sposob latwego zapisu i odczytu stanu obiektow w aplikacji
            //Serializowana klasa musi miec:
            //1. Konstruktor bezargumentowy
            //2. public przy nazwie klasy
            //3. WAZNE: serializowac mozna tylko publiczne pola i properties
            Punkt punktX = new Punkt(5, 7);
            XmlSerializer xml = new XmlSerializer(typeof(Punkt)); //w srodku konstruktra trzeba podac jaka klase ma serializowac ten serializator
            TextWriter textWriter = new StreamWriter("mojpunkt.xml"); //tutaj tworzymy obiekt ktory reprezentuje plik o nazwie takiej jak w argumencie funkcji
            xml.Serialize(textWriter, punktX);
            textWriter.Close();

            Telefon T1 = new Telefon(model: "13", producent: "Apple", cena: 1499.99f);
            Telefon T2 = new Telefon(model: "12", producent: "Apple", cena: 1299.99f);
            Telefon T3 = new Telefon(model: "11", producent: "Apple", cena: 1099.99f);

            Client c = new Client("Ada", "Kowalska", "Aleja KEN 87");
            c.AddTelefon(T1);
            c.AddTelefon(T2);
            c.AddTelefon(T3);
            c.SaveXML("client.xml");


            //Deserializacja obiektu
            Client w = Deserializuj("client.xml");
            Console.WriteLine(w);


        }
    }
}
