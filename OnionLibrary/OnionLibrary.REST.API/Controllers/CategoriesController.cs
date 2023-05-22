using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.Services;
using OnionLibrary.Domain.DBModels;

namespace OnionLibrary.REST.API.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService; 

        public CategoriesController(ICategoryService categoryService) {
            _categoryService = categoryService;
        }
   
        [HttpGet]
        public ActionResult<List<Category>> Get()
        {
            var categories = _categoryService.GetCategories();
            return Ok(categories);
        }
    }
}
