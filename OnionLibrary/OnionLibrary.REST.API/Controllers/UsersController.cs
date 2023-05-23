using LibraryBackend.RequestModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.Interfaces.Repositories;
using OnionLibrary.Application.Interfaces.Services;
using OnionLibrary.Domain.CommonModels;
using OnionLibrary.Domain.DBModels;
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

        [Authorize]
        [HttpPut]
        public ActionResult<string> PutUser(int id, UserPutRequest user)
        {
            try
            {
                _userService.PutUser(id, user);
            }
            catch (NotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (BadRequestException e)
            {
                return BadRequest(e.Message);
            }       

            return "Edited";
        }

    }
}
