using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lekcja05._10
{
    public class Client
    {
        private string name;
        private string surname;
        private string adress;
        private List<Telefon> telefony;

        public Client()
        {

        }
        public Client(string name, string surname, string adress)
        {
            this.Name = name;
            this.Surname = surname;
            this.Adress = adress;
            Telefony = new List<Telefon>();
        }

        public void AddTelefon(Telefon t)
        {
            Telefony.Add(t);
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Adress { get => adress; set => adress = value; }
        public List<Telefon> Telefony { get => telefony; set => telefony = value; }

        public void SaveXML(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Client));
            TextWriter textWriter = new StreamWriter(fileName);
            xml.Serialize(textWriter, this); //this = obiekt ktory wykonuje ta metode
            textWriter.Close();
        }

        public override string ToString()
        {
            return $"{Name} , {Surname}";
        }
    }
}
