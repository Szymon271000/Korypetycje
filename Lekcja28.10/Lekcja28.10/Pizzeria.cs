using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja28._10
{
    class Pizzeria
    {
        public void MakePizza(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.NadajCene();
            pizzaBuilder.DodajNazwe();
            pizzaBuilder.DodajSkladniki();
            pizzaBuilder.DodajSos();   
        }
    }
}
