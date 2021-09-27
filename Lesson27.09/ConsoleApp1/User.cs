using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        private int id;
        private string name;
        private string password;
        private static int counter = 1; //static oznacza ze zmienna taka jest tylko jedna na caly program
        private Car car;

        public static int Counter { get => counter; }
        public Car Car { get => car; }

        public User(string name, string password, Car car = null)
        {
            id = counter; //skopiuj wartosc z licznka
            counter++; //zwieksz licznik o 1
            this.name = name;
            this.password = password;
            this.car = car;
        }

        public override string ToString()
        {
            return $"{id} {name} {password} {Car}";
        }
    }
}
