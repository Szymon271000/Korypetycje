using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order order { get; set; }
        public Item item { get; set; }

        public override string ToString()
        {
            return $"Podsumowanie: OrderItem {order.Id} {item.Id}";
        }
    }
}
