using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.DBModels;
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
        public RentedBook PostRentedBook(RentedBook book)
        {
            return _rentedBookRepository.PostRentedBook(book);
        }
    }
}
