using Microsoft.EntityFrameworkCore;
using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.RequestModels;
using OnionLibrary.Domain.ResponseModels;
using OnionLibrary.Infrastructure.Mapppers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionLibrary.Domain.CommonModels;

namespace OnionLibrary.Infrastructure.Repositiries
{
    public class OrderRepository : IOrderRepository
    {

        private readonly LibraryDbContext _libraryDbContext;

        public OrderRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        public OrderResponse GetOrder(int id)
        {
            var order = _libraryDbContext.Orders.Find(id);

            if (order == null)
            {
                throw new NotFoundException("");
            }

            var book =  _libraryDbContext.Books.Find(order.BookId);
            var user =  _libraryDbContext.Users.Find(order.UserId);
            var orderStatus =  _libraryDbContext.OrderStatuses.Find(order.OrderStatusId);
            var categories =  _libraryDbContext.Categories.ToList();

            return new OrderResponse()
            {
                Id = id,
                Book = BookMapper.ToBookResponseModel(book, categories),
                User = new UserSimplifiedResponse()
                {
                    Id = user.Id,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    Lastname = user.Lastname
                },
                OrderStatus = orderStatus
            };
        }

        public OrderResponse GetOrderByUser(int id)
        {
            throw new NotImplementedException();
        }

        public void PostOrder(OrderPostRequest order)
        {
            var book = _libraryDbContext.Books.Find(order.BookId);
            var user = _libraryDbContext.Books.Find(order.UserId);


            if (book == null || book.Quantity < 1 || user == null)
            {
                throw new Exception("There is no more books like this");
            }

            book.Quantity -= 1;

            _libraryDbContext.Add(new Order() { BookId = order.BookId, OrderStatusId = 3, UserId = order.UserId });
            _libraryDbContext.Update(book);

            _libraryDbContext.SaveChangesAsync();

        }

        public void PutOrder(int id, OrderPutRequest order)
        {
            var orderDb = _libraryDbContext.Orders.Find(id);

            if (orderDb == null)
            {
                throw new BadRequestException("");
            }

            _libraryDbContext.Entry(order).State = EntityState.Modified;

            try
            {
                _libraryDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    throw new NotFoundException("");
                }
                else
                {
                    throw;
                }
            }
        }

        private bool OrderExists(int id)
        {
            return _libraryDbContext.Orders.Any(e => e.Id == id);
        }

        public void DeleteOrder(int id)
        {
            var order = _libraryDbContext.Orders.Find(id);
            if (order == null)
            {
               throw new NotFoundException("Category not found");
            }

            _libraryDbContext.Orders.Remove(order);
            _libraryDbContext.SaveChangesAsync();

        }

    }
}
