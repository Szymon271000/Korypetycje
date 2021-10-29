using System;

namespace Lekcja28._10
{
    class Program
    {
        static void Main(string[] args)
        {
            PepperoniBuilder pepperoniPizza = new PepperoniBuilder();
            Pizzeria pizzeria1 = new Pizzeria();
            pizzeria1.MakePizza(pepperoniPizza);
            Console.WriteLine(pepperoniPizza.Pizza);

            var warzywna = new WarzywnaBuilder();
            pizzeria1.MakePizza(warzywna);
            Console.WriteLine(warzywna.Pizza);
        }
    }
}
