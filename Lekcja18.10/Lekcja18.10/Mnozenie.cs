using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._10
{
    class Mnozenie: Operacja
    {
        public Mnozenie(int A, int B): base (A, B)
        {

        }

        public override int Wykonaj()
        {
            int product = A * B;
            return product;
        }

        public override string ToString()
        {
            return "Mnozenie";
        }
    }
}
