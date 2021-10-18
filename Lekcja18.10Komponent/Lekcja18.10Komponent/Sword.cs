using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._10Komponent
{
    class Sword: Item
    {
        private int maxAttack;

        public Sword(int maxAttack)
        {
            this.maxAttack = maxAttack;
        }
        public override int Waga()
        {
            return maxAttack * 2;
        }
    }
}
