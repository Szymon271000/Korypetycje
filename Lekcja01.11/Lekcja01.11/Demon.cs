using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja01._11
{
    class Demon: Monster
    {
        public Demon(string imie, int hp): base (imie, hp)
        {

        }

        public override string ToString()
        {
            return $"Demon {Imie} {Hp}";
        }
    }
}
