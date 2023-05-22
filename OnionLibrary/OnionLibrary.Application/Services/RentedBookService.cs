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
    public class RentedBookService : IRentedBookService
    {

        private readonly IRentedBookRepository _rentedBookRepository;

        public RentedBookService(IRentedBookRepository rentedBookRepository)
        {
            _rentedBookRepository = rentedBookRepository;
        }

        public RentedBookResponse GetRentedBook(int id)
        {
            var rentedBook = _rentedBookRepository.GetRentedBook(id);

            return rentedBook;
        }

        public RentedBookByUserResponse GetRentedBooksByUserId(int id)
        {
            var rentedBookByUserId = _rentedBookRepository.GetRentedBooksByUserId(id);

            return rentedBookByUserId;
        }

        public OrderPostRequest PostRentedBook(OrderPostRequest rentedBook)
        {
           var postRentedBook = _rentedBookRepository.PostRentedBook(rentedBook);

            return postRentedBook;
        }
    }
}
