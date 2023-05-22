using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.RequestModels;
using OnionLibrary.Domain.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Repositories
{
    public interface IRentedBookRepository
    {
        RentedBookResponse GetRentedBook(int id);
        RentedBookByUserResponse GetRentedBooksByUserId(int id);
        OrderPostRequest PostRentedBook(OrderPostRequest rentedBook);   
    }
}
