using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.Services;
using OnionLibrary.Domain;

namespace OnionLibrary.REST.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<List<Book>> Get()
        {
            var books = _bookService.GetBooks();
            return Ok(books); 
        }
    }
}
