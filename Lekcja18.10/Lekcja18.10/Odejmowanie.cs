using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._10
{
    class Odejmowanie : Operacja
    {
        public Odejmowanie(int A, int B) : base(A, B)
        {

        }

        public override string ToString()
        {
            return "Dzielenie";
        }

        public override int Wykonaj()
        {
            return A - B;
        }
    }
}
