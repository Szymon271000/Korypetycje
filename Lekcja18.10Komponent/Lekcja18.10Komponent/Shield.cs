using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._10Komponent
{
    class Shield:Item
    {
        private int defence;
        public Shield()
        {
            defence = 100;
        }

        public override int Waga()
        {
            return 10;
        }
    }
}
