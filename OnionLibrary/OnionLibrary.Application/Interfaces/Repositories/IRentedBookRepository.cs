using OnionLibrary.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Repositories
{
    public interface IRentedBookRepository
    {
        RentedBook PostRentedBook(RentedBook book);
    }
}
