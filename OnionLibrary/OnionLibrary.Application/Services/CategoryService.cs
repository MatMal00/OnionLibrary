using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;   

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }

        public Category GetCategory(int id)
        {
            var category = _categoryRepository.GetCategory(id);

            return category;
        }

        public FilledCategoryResponse GetFilledCategory(int id)
        {
            var category = _categoryRepository.GetFilledCategory(id);

            return category;
        }

        public Category PostCategory(Category category)
        {
            var postCategory = _categoryRepository.PostCategory(category);

            return postCategory;
        }

        public void PutCategory(int id, Category category)
        {
            _categoryRepository.PutCategory(id, category);    
        }

        public Category DeleteCategory(int id)
        {
            var deletedCategory = _categoryRepository.DeleteCategory(id);

            return deletedCategory;
        }

    }
}
