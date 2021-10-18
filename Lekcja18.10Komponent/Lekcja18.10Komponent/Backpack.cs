using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18._10Komponent
{
    class Backpack:Item
    {
        private List<Item> items = new List<Item>();

        public void Add (Item item)
        {
            items.Add(item);
        }

        public override int Waga()
        {
            int waga = 0;
            for (int i = 0; i < items.Count; i++)
            {
                waga = waga + items[i].Waga();
            }
            return waga + 20;
        }
    }
}
