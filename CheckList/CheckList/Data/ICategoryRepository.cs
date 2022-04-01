using CheckList.Models;
using System.Collections.Generic;

namespace CheckList.Data
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
    }
}