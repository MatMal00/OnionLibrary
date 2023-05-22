using OnionLibrary.Application.Interfaces.Repositories;
using OnionLibrary.Application.Interfaces.Services;
using OnionLibrary.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Services
{
    public class OrderStatusService : IOrderStatusService
    {
        private readonly IOrderStatusRepository _orderStatusRepository;

        public OrderStatusService(IOrderStatusRepository orderStatusService)
        {
            _orderStatusRepository = orderStatusService;
        }

        public List<OrderStatus> GetOrderStatuses()
        {
            var statuses = _orderStatusRepository.GetOrderStatuses();

            return statuses;
        }
    }
}
