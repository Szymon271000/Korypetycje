using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._10
{
    class Dzielenie: Operacja
    {
        public Dzielenie(int A, int B): base (A,B)
        {

        }

        public override int Wykonaj()
        {
            int divide = A / B;
            return divide;
        }

        public override string ToString()
        {
            return "Dzielenie";
        }
    }
}
