using Microsoft.EntityFrameworkCore;
using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.CommonModels;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.RequestModels;
using OnionLibrary.Domain.ResponseModels;
using OnionLibrary.Infrastructure.Mapppers;

namespace OnionLibrary.Infrastructure.Repositiries
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _libraryDbContext;

        public BookRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        public List<BookResponse> GetBooks()
        {
            var books = _libraryDbContext.Books.ToList();
            var categories = _libraryDbContext.Categories.ToList();

            return books.Select(b => BookMapper.ToBookResponseModel(b, categories)).ToList();
        }

        public BookResponse GetBook(int id)
        {
            var book = _libraryDbContext.Books.Find(id);

            if (book == null)
                throw new NotFoundException("This book does not exist");

            var categories = _libraryDbContext.Categories.ToList();


            return BookMapper.ToBookResponseModel(book, categories);
        }

        public Book CreateBook(Book book)
        {
            _libraryDbContext.Books.Add(book);
            _libraryDbContext.SaveChanges();

            return book;
        }

        public void PutBook(int id, BookPutRequest book)
        {
            if (id != book.Id)
                throw new BadRequestException("This book does not exist");

            var bookFromDb = _libraryDbContext.Books.Find(book.Id);
            var categories = _libraryDbContext.Categories.ToList();

            bookFromDb.Title = book.Title;
            bookFromDb.Author = book.Author;
            bookFromDb.Quantity = book.Quantity;
            bookFromDb.CategoryId = categories.Find(category => category.CategoryName == book.CategoryName).Id;

            _libraryDbContext.Entry(bookFromDb).State = EntityState.Modified;

            try
            {
                _libraryDbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    throw new BadRequestException("Something went wrong");
                }
                else
                {
                    throw;
                }
            }
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        private bool BookExists(int id)
        {
            return _libraryDbContext.Books.Any(e => e.Id == id);
        }
    }
}

