using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.Services;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.ResponseModels;

namespace OnionLibrary.REST.API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<List<BookResponse>> Get()
        {
            var books = _bookService.GetBooks();
            return Ok(books); 
        }

        [HttpPost]
        public ActionResult<BookResponse> PostBook(Book book)
        {
            _bookService.CreateBook(book);

            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }
    }
}
