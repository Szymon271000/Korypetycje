using Lekcja04._03_Sklep.Models;
using System.Collections.Generic;

namespace Lekcja04._03_Sklep.Data
{
    public interface IOrderReposiotry
    {
        void AddProductToOrder(int productId);
        public List<OrderItem> GetItemsFromActiveOrder();
        public void RemoveOrderItem(int orderItemId);
    }
}