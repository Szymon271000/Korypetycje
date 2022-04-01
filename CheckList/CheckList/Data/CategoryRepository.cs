using CheckList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckList.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext context;

        public CategoryRepository(DataContext context)
        {
            this.context = context;
        }

        public List<Category> GetAllCategories()
        {
            return context.Categories.ToList();
        }
    }
}
