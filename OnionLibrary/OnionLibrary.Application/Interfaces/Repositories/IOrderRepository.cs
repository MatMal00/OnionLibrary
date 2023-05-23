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
    public interface IOrderRepository
    {
        OrderResponse GetOrder(int id);
        OrderResponse GetOrderByUser(int id);
        void PutOrder(int id, OrderPutRequest order);
        void PostOrder(OrderPostRequest order);
        void DeleteOrder(int id);
    }
}
