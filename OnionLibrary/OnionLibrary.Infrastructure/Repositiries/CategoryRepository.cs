using OnionLibrary.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionLibrary.Domain.DBModels;

namespace OnionLibrary.Infrastructure.Repositiries
{
    public class CategoryRepository : ICategoryRepository
    {

        public static List<Category> categories = new()
        {
            new Category { Id = 1, CategoryName = "Horror", },
        };


        public List<Category> GetCategories()
        {
            return categories;
        }
    }
}
