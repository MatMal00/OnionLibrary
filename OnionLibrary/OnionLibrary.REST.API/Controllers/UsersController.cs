using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.Interfaces.Repositories;
using OnionLibrary.Application.Interfaces.Services;
using OnionLibrary.Domain.ResponseModels;

namespace OnionLibrary.REST.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;   
        }

        [HttpGet]
        public ActionResult<List<UserSimplifiedResponse>> GetUsers()
        {
            var users = _userService.GetUsers();

            return users;
        }
    }
}
