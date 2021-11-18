using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._11Databases
{
    public class User //klasa model reprezentujaca tabele, tutaj raczej nie piszemy zadnych funkcji ani konstruktora
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
