using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._10
{
    abstract class Operacja //jesli klasa posiada przynajmniej jedna metoda abstrakcyjna to sama tez jest abstrakcyjna
    { //nie mozna stworzyc obiektu klasy abstrakcyjnej (mozna zrobic tylko zmienna)
        private int a;
        private int b;

        public Operacja(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public abstract int Wykonaj(); //abstract - metoda nie ma definicji, trzeba ja stworzyc w klasie pochodnej
    }
}
