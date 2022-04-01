using Lekcja04._03_Sklep.Models;
using System.Collections.Generic;

namespace Lekcja04._03_Sklep.Data
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
    }
}