using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Repositories
{
    public interface IBookRepository
    {
        List<BookResponse> GetBooks();
        Book CreateBook(Book kook);
        void DeleteBook(int id);
    }
}
