using System;
using System.IO;
using System.Xml.Serialization;

namespace ListaUzytkownikow
{
    class Program
    {
        static List Deserializuj(string nazwaPliku)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List));
            StreamReader reader = new StreamReader(nazwaPliku); //odczytuje plik
            List wczytany = xmlSerializer.Deserialize(reader) as List; //ta funkcja zwraca nowy obiekt zaladowany z pliku w wyniku serializacji
            reader.Close();
            return wczytany;
        }
        static void Main(string[] args)
        {
            /*User u1 = new User("Szymon", "Lewandowski");
            User u2 = new User("Andrzej", "Lekki");
            User u3 = new User("Ania", "Rewilak");

            List l1 = new List();
            l1.AddUser(u1);
            l1.AddUser(u2);
            l1.AddUser(u3);
            Console.WriteLine(l1);
            l1.SaveXML("l1.xml");*/
            List NowaLista = new List();
            if (File.Exists("l1.xml"))
            {
                NowaLista = Deserializuj("l1.xml");
            }
            Console.WriteLine("Enter user: ");
            string input = Console.ReadLine();
            string[] inputUser = input.Split(" ");
            User u4 = new User(inputUser[0], inputUser[1]);
            string input2 = Console.ReadLine();
            string[] inputUser2 = input2.Split(" ");
            User u5 = new User(inputUser2[0], inputUser2[1]);
            string input3 = Console.ReadLine();
            string[] inputUser3 = input3.Split(" ");
            User u6 = new User(inputUser3[0], inputUser3[1]);

            NowaLista.AddUser(u4);
            NowaLista.AddUser(u5);
            NowaLista.AddUser(u6);
            Console.WriteLine(NowaLista);

            NowaLista.SaveXML("l1.xml");
        }
    }
}
