using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.Services;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.RequestModels;

namespace OnionLibrary.REST.API.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        
            private readonly IOrderService _orderService;

            public OrdersController(IOrderService orderService)
            {
            _orderService = orderService;
            }

        [HttpPost]
            public void PostOrder(OrderPostRequest order)
        {
            _orderService.PostOrder(order);
        }
        
    }
}
