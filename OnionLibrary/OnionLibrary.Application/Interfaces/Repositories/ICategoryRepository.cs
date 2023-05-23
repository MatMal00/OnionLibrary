using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();

        FilledCategoryResponse GetFilledCategory(int id);

        Category GetCategory(int id);

        void PutCategory(int id, Category category);

        Category PostCategory(Category category);

        Category DeleteCategory(int id);

    }
}
