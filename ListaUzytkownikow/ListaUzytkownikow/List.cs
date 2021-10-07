using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ListaUzytkownikow
{
    public class List
    {
        List<User> users = new List<User>();

        public List()
        {
            Users = new List<User>();
        }

        public List<User> Users { get => users; set => users = value; }

        public void AddUser(User u)
        {
            Users.Add(u);
        }

        public void SaveXML(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List));
            TextWriter textWriter = new StreamWriter(fileName);
            xml.Serialize(textWriter, this);
            textWriter.Close();
        }

        public override string ToString()
        {
            string text = "Moja lista: \n";
            for (int i = 0; i < Users.Count; i++)
            {
                text += Users[i] + "\n";
            }
            return text;
        }
    }
}
