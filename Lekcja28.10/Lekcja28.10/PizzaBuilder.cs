using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja28._10
{
    abstract class PizzaBuilder
    {
        private Pizza pizza;

        internal Pizza Pizza { get => pizza; set => pizza = value ; }

        public abstract void DodajNazwe();
        public abstract void DodajSkladniki();
        public abstract void NadajCene();
        public abstract void DodajSos();

        
    }
}
