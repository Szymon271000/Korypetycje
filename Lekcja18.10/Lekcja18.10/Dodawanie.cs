using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._10
{
    class Dodawanie: Operacja
    {
        public Dodawanie(int A, int B): base (A, B)
        {

        }

        public override int Wykonaj()
        {
            int suma = A + B;
            return suma;
        }

        public override string ToString()
        {
            return nameof(Dodawanie);
        }
    }
}
