using Lekcja04._03_Sklep.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lekcja04._03_Sklep.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext context;

        public ProductRepository(DataContext context)
        {
            this.context = context;
        }

        public List<Product> GetAllProducts()
        {
            return context.Products.Include(x => x.Category).ToList();
        }

        public void AddProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public Product GetProduct(int productId)
        {
            return context.Products.Include(x => x.Category).FirstOrDefault(x => x.Id == productId);
        }
    }
}
