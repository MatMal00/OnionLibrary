﻿using OnionLibrary.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.ResponseModels;

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
            throw new NotImplementedException();
        }

        public Category GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public FilledCategoryResponse GetFilledCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Category PostCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Category PutCategory(int id, Category category)
        {
            throw new NotImplementedException();
        }

        public Category DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
