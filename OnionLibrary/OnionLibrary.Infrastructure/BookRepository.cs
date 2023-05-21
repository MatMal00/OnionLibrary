using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Infrastructure
{
    public class BookRepository : IBookRepository
    {
        public static List<Book> books = new()
        {
            new Book { Id = 1, Author = "dsada", BookDescription = "dsadsa", CategoryId = 1, ImageUrl = "", IsRentable = true, Price = 12, Quantity = 5, Rating = "4.5", Title = "TITLE" },
        };

        public List<Book> GetBooks()
        {
            return books;
        }
    }
}
