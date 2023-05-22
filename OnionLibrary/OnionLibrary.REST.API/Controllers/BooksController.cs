using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.Services;
using OnionLibrary.Domain.DBModels;

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

        [HttpPost]
        public ActionResult<Book> PostBook(Book book)
        {
            var newBook = _bookService.CreateBook(book);

            return newBook;
        }
    }
}
