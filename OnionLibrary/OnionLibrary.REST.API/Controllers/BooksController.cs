using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.Services;
using OnionLibrary.Domain.CommonModels;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.RequestModels;
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
        public ActionResult<List<BookResponse>> GetBooks()
        {
            var books = _bookService.GetBooks();
            return books; 
        }

        [HttpGet("{id}")]
        public ActionResult<BookResponse> GetBook(int id)
        {
            try
            {
                var book = _bookService.GetBook(id);

                return book;
            }
            catch(NotFoundException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<BookResponse> PostBook(Book book)
        {
            _bookService.CreateBook(book);

            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public ActionResult<BookResponse> PostBook(int id, BookPutRequest book)
        {
            try
            {
                _bookService.PutBook(id, book);
            }
            catch (BadRequestException e)
            {
                return BadRequest(e.Message);
            }

            return NoContent();
        }
    }
}
