using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.RequestModels;
using OnionLibrary.Domain.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public OrderResponse GetOrderByUser(int id)
        {
            throw new NotImplementedException();
        }

        public Order PostOrder(OrderPutRequest order)
        {
            throw new NotImplementedException();
        }

        public Order PutOrder(int id, OrderPutRequest order)
        {
            throw new NotImplementedException();
        }

        public Order DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

    }
}
