using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaUzytkownikow
{
    public class User
    {
        private string name;
        private string surname;
        private int id;
        private static int counter = 1;
        public User()
        {

        }

        public User(string name, string surname)
        {
            id = counter;
            counter++;
            this.name = name;
            this.surname = surname;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public override string ToString()
        {
            return $"User {id} ma na imie {name} i nazwisko {surname}";
        }
    }

}
