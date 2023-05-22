using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.DBModels;

namespace OnionLibrary.Infrastructure.Repositiries
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _libraryDbContext;

        public BookRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        public List<Book> GetBooks()
        {
            return _libraryDbContext.Books.ToList();
        }

        public Book CreateBook(Book book)
        {
            _libraryDbContext.Books.Add(book);
            _libraryDbContext.SaveChanges();

            return book;
        }
    }
}
