using System;

namespace ListaUzytkownikow
{
    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User("Szymon", "Lewandowski");
            User u2 = new User("Andrzej", "Lekki");
            User u3 = new User("Ania", "Rewilak");

            List l1 = new List();
            l1.AddUser(u1);
            l1.AddUser(u2);
            l1.AddUser(u3);
            Console.WriteLine(l1);
            l1.SaveXML("l1.xml");

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

            l1.AddUser(u4);
            l1.AddUser(u5);
            l1.AddUser(u6);
            Console.WriteLine(l1);

            l1.SaveXML("l1.xml");
        }
    }
}
