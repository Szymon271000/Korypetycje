using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Waluta w = new Waluta(5);
            Console.WriteLine(w);
            w.Pln = -100;
            Console.WriteLine(w);

            User u1 = new User("Ada", "1234");
            User u2 = new User("Blacknight", "0000");
            User u3 = new User("Gucci", "2135");

            Console.WriteLine(User.Counter);

            Console.WriteLine(u1);
            Console.WriteLine(u2);
            Console.WriteLine(u3);

            Console.WriteLine(User.Counter); //poniewaz property Counter jest static to nie musze tworzyc obiektu zeby go uzyc

            //Kompozycja - obiekt jednej klasy posiada jeden obiekt innej klasy
            //Agregacja - obiekt jednej klasy posiada wiele obiektow innej klasy

            Car c = new Car("Ford", "Focus", 2008);
            User u4 = new User("Jan", "Nowak", c);
            Console.WriteLine(u4);

            Team team = new Team("Backend");
            team.Users.Add(u1);
            team.Users.Add(u2);
            team.AddUser(u3);
            team.AddUser(u4);
            Console.WriteLine(team);

            User withCar = team.FindFirstWithCar();
            Console.WriteLine($"Uzytkownik ktory ma samochod to: {withCar}");
        }
    }
}
