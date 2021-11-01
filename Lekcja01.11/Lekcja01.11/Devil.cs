using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja01._11
{
    class Devil: Monster
    {
        private int maxAttack;

        public Devil(string imie, int hp, int maxAttack): base(imie, hp)
        {
            this.maxAttack = maxAttack;
        }

        public override string ToString()
        {
            return $"Devil {Imie} {Hp} {maxAttack}";
        }
    }
}
