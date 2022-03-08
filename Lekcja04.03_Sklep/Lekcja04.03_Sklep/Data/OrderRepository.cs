using Lekcja04._03_Sklep.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Lekcja04._03_Sklep.Data
{
    public class OrderReposiotry : IOrderReposiotry
    {
        private readonly DataContext context;
        private readonly IProductRepository productRepository;

        public OrderReposiotry(DataContext context, IProductRepository productRepository)
        {
            this.context = context;
            this.productRepository = productRepository;
        }

        public void AddProductToOrder(int productId)
        {
            var product = productRepository.GetProduct(productId);
            if (product == null)
            {
                return;
            }

            var order = context.Orders.FirstOrDefault(x => !x.Done);
            if (order == null)
            {
                order = new Order();
                context.Add(order);
                context.SaveChanges();
            }

            var orderItem = new OrderItem
            {
                Order = order,
                Product = product
            };
            context.Add(orderItem);
            context.SaveChanges();
        }

        public List<OrderItem> GetItemsFromActiveOrder()
        {
            var order = context.Orders.FirstOrDefault(x => !x.Done);
            if (order == null)
            {
                return new List<OrderItem>();
            }
            return context.OrderItems
                .Include(x => x.Order)
                .Include(x => x.Product)
                .Where(x => x.Order.Id == order.Id).ToList();
        }

        public void RemoveOrderItem(int orderItemId)
        {
            var orderItem = context.OrderItems.FirstOrDefault(x => x.Id == orderItemId);
            if(orderItem == null)
            {
                return;
            }
            context.Remove(orderItem);
            context.SaveChanges();
        }
    }
}