using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.RequestModels;
using OnionLibrary.Domain.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository) {
        
            _orderRepository = orderRepository; 
        }

        public OrderResponse GetOrder(int id)
        {
            var order = _orderRepository.GetOrder(id);

            return order;
        }

        public OrderResponse GetOrderByUser(int id)
        {
            var order = _orderRepository.GetOrderByUser(id);

            return order;
        }

        public Order PostOrder(OrderPutRequest order)
        {
            var postOrder = _orderRepository.PostOrder(order);

            return postOrder;
;        }

        public Order PutOrder(int id, OrderPutRequest order)
        {
            var putOrder = _orderRepository.PutOrder(id, order);

            return putOrder;
        }
        public Order DeleteOrder(int id)
        {
            var order = _orderRepository.DeleteOrder(id);

            return order;
        }

    }
}
