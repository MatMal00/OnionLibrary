using OnionLibrary.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Services
{
    public interface IRentedBookService
    {
        RentedBook PostRentedBook(RentedBook book);

    }
}
