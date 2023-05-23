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

        public void PostOrder(OrderPostRequest order)
        {
            _orderRepository.PostOrder(order);

;        }

        public void PutOrder(int id, OrderPutRequest order)
        {
          _orderRepository.PutOrder(id, order);
        }
        public void DeleteOrder(int id)
        {
           _orderRepository.DeleteOrder(id);
        }

    }
}
