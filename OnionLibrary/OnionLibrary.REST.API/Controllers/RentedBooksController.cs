using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.Services;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.RequestModels;
using Microsoft.AspNetCore.Authorization;


namespace OnionLibrary.REST.API.Controllers
{
    [Route("api/rented")]
    [ApiController]
    public class RentedBooksController : ControllerBase
    {

        private readonly IRentedBookService _rentedBookService;

        public RentedBooksController(IRentedBookService rentedBookService)
        {
            _rentedBookService = rentedBookService;
        }

        [HttpPost]
        public void PostRentedBook(OrderPostRequest rentedBook)
        {
            _rentedBookService.PostRentedBook(rentedBook);
        }

    }
}
