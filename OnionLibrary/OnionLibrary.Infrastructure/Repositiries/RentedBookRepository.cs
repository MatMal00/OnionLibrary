using Microsoft.EntityFrameworkCore;
using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.CommonModels;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.RequestModels;
using OnionLibrary.Domain.ResponseModels;
using OnionLibrary.Infrastructure.Mapppers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Infrastructure.Repositiries
{
    public class RentedBookRepository : IRentedBookRepository
    {
        private readonly LibraryDbContext _libraryDbContext;

        public RentedBookRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }
        public RentedBookResponse GetRentedBook(int id)
        {
            var rentedBook = _libraryDbContext.RentedBooks.Find(id);

            if (rentedBook == null)
            {
                throw new NotFoundException("Rented book not found");
            }
            var user = _libraryDbContext.Users.Find(rentedBook.UserId);
            var book = _libraryDbContext.Books.Find(id);
            var categories = _libraryDbContext.Categories.ToList();

            if (book == null)
            {
                throw new NotFoundException("Book not found");
            }
            else if (user == null)
            {
                throw new NotFoundException("No user data for this request");
            }

            return new RentedBookResponse()
            {
                Id = id,
                RentalDate = new DateTime().Date,
                DateOfReturn = null,
                Book = BookMapper.ToBookResponseModel(book, categories),
                User = new() { Id = user.Id, Email = user.Email, FirstName = user.FirstName, Lastname = user.Lastname },
            };
        }

        public RentedBookByUserResponse GetRentedBooksByUserId(int id)
        {
            throw new NotImplementedException();
        }

        public void PostRentedBook(OrderPostRequest rentedBook)
        {
            var user = _libraryDbContext.Users.Find(rentedBook.UserId);
            var book = _libraryDbContext.Books.Find(rentedBook.BookId);

            if (book == null || user == null)
            {
                throw new BadRequestException("Not found");
            }
            if (book.IsRentable == false) {
                throw new BadRequestException("Tej książki nie można wypożyczyć");
            }

            _libraryDbContext.RentedBooks.Add(new RentedBook() { BookId = rentedBook.BookId, UserId = rentedBook.UserId, RentalDate = DateTime.Now });
            _libraryDbContext.SaveChangesAsync();

        }
    }
}
