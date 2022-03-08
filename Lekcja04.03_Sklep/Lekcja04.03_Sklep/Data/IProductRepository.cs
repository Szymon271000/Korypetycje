using Lekcja04._03_Sklep.Models;
using System.Collections.Generic;

namespace Lekcja04._03_Sklep.Data
{
    public interface IProductRepository
    {
        void AddProduct(Product p);
        List<Product> GetAllProducts();
        Product GetProduct(int productId);
    }
}