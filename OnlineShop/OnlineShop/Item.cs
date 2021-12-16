using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Item
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public float Cena { get; set; }

        public override string ToString()
        {
            return $"Produkt {Id} {Nazwa} z kategorii {Kategoria} kozstuje {Cena}";
        }
    }
}
