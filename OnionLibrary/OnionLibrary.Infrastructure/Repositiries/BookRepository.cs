using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.RequestModels;
using OnionLibrary.Domain.ResponseModels;

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
            throw new NotImplementedException();
        }

        public Book CreateBook(Book book)
        {
            _libraryDbContext.Books.Add(book);
            _libraryDbContext.SaveChanges();

            return book;
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public void PutBook(int id, BookPutRequest book)
        {
            throw new NotImplementedException();
        }

        public BookResponse GetBook(int id)
        {
            throw new NotImplementedException();
        }
    }
}

