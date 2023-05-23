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
    public interface IBookRepository
    {
        List<BookResponse> GetBooks();
        BookResponse GetBook(int id);
        Book CreateBook(Book kook);
        void PutBook(int id, BookPutRequest book);
        void DeleteBook(int id);
    }
}
