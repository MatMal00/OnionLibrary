using OnionLibrary.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.ResponseModels;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using OnionLibrary.Domain.CommonModels;

namespace OnionLibrary.Infrastructure.Repositiries
{
    public class CategoryRepository:ICategoryRepository
    {

        private readonly LibraryDbContext _libraryDbContext;

        public CategoryRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        public List<Category> GetCategories()
        {
            return _libraryDbContext.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            var category = _libraryDbContext.Categories.Find(id);

            if (category == null)
            {
                throw new NotFoundException("");
            }

            return category;
        }

        public FilledCategoryResponse GetFilledCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Category PostCategory(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            if (!ValidateCategory(category))
                throw new ArgumentException("Invalid category data");

            _libraryDbContext.Categories.Add(category);
            _libraryDbContext.SaveChanges();

            return category;
        }

        public void PutCategory(int id, Category category)
        {
            if (id != category.Id)
            {
                throw new BadRequestException("");
            }

            _libraryDbContext.Entry(category).State = EntityState.Modified;

            try
            {
                _libraryDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
                {
                    throw new NotFoundException("");
                }
                else
                {
                    throw;
                }
            }

        }

        private bool CategoryExists(int id)
        {
            return _libraryDbContext.Categories.Any(e => e.Id == id);
        }

        private bool ValidateCategory(Category category)
        {
            var validationContext = new ValidationContext(category);
            var validationResults = new List<ValidationResult>();

            return Validator.TryValidateObject(category, validationContext, validationResults, true);
        }

        public Category DeleteCategory(int id)
        {
            var category = _libraryDbContext.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
                throw new Exception("Category not found");

            _libraryDbContext.Categories.Remove(category);
            _libraryDbContext.SaveChanges();

            return category;
        }
    }
}
