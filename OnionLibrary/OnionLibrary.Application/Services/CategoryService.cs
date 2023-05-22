﻿using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryService _categoryRepository;   

        public CategoryService(ICategoryService categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }
    }
}
