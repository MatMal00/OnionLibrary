using OnionLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Services
{
    public interface IBookService
    {
        List<Book> GetBooks();
        Book CreateBook(Book book);
    }
}
