using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.RequestModels;
using OnionLibrary.Domain.ResponseModels;
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
            throw new NotImplementedException();
        }

        public RentedBookByUserResponse GetRentedBooksByUserId(int id)
        {
            throw new NotImplementedException();
        }

        public OrderPostRequest PostRentedBook(OrderPostRequest rentedBook)
        {
            throw new NotImplementedException();
        }
    }
}
