using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> GetBooks()
        {
            var books = _bookRepository.GetBooks();

            return books;
        }

        public Book CreateBook(Book book)
        {
            _bookRepository.CreateBook(book);

            return book;
        }
    }
}
