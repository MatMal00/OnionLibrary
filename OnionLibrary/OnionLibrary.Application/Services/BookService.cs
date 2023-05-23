using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.RequestModels;
using OnionLibrary.Domain.ResponseModels;
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

        public List<BookResponse> GetBooks()
        {
            var books = _bookRepository.GetBooks();

            return books;
        }

        public Book CreateBook(Book book)
        {
            _bookRepository.CreateBook(book);

            return book;
        }

        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }

        public void PutBook(int id, BookPutRequest book)
        {
            _bookRepository.PutBook(id, book);
        }

        public BookResponse GetBook(int id)
        {
            var book = _bookRepository.GetBook(id);

            return book;
        }
    }
}
