using OnionLibrary.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
        Book CreateBook(Book kook);
    }
}
