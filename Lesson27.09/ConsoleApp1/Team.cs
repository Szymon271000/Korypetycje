using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Team
    {
        private List<User> users; //encapsulate field (and use property)
        private string name;

        public Team(string name)
        {
            this.name = name;
            users = new List<User>();
        }

        public List<User> Users { get => users; }

        public override string ToString()
        {
            string text = $"Team: {name}\n";
            for(int i = 0; i < Users.Count; i++)
            {
                text += Users[i] + "\n";
            }
            return text;
        }

        //Drugi sposob na dodawanie czegos do listy to stworzenie specjalnej metody
        public void AddUser(User u)
        {
            Users.Add(u);
        }

        //metoda ktora szuka uzytkownika ktory ma jakikowiek samochod

        public User FindFirstWithCar()
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if(Users[i].Car != null) //jesli wartosc jest rozna od null znaczy ze mamy jakis samochod (obiekt)
                {
                    return Users[i];
                }
            }

            return null; //jesli nic nie znajdziemy to zwracamy brak uzytkownika
        }
    }
}
