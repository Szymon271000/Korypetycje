using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja11._11
{
    static class Liczby
    {

        public static int NWD(int a, int b)
        {
            while (a != b)
                if (a > b)
                    a -= b; //lub a = a - b;
                else
                    b -= a; //lub b = b-a
            return a; // lub b - obie zmienne przechowują wynik NWD(a,b)
        }
    }
}
