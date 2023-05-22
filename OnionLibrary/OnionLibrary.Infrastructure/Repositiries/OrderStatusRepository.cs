using OnionLibrary.Application.Interfaces.Repositories;
using OnionLibrary.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Infrastructure.Repositiries
{
    public class OrderStatusRepository : IOrderStatusRepository
    {
        public List<OrderStatus> GetOrderStatuses()
        {
            throw new NotImplementedException();
        }
    }
}
