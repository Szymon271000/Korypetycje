using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatDoKawy
{
    class Moneta
    {
        public int wartosc;
        public Moneta()
        {
            wartosc = 1;
        }

        public override string ToString()
        {
            return $"{wartosc}";
        }
    }

}
