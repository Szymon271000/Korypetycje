using System;

namespace Lekcja18._11Databases
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext data = new DataContext();
            User u = new User
            {
                Email = "tester@gmail.com",
                Name = "Kowalski",
                Password = "1234"
            };
            data.Add(u);
            data.SaveChanges();
        }
    }
}
