using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Order
    {
        public int Id { get; set; }
        public User buyer { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"Order zostal zamowiony przez {Id + 1} {buyer.Imie} {DateTime}";
        }
    }
}
