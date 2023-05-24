using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionLibrary.Application.Interfaces.Repositories;
using OnionLibrary.Domain.CommonModels;
using OnionLibrary.Domain.RequestModels;
using OnionLibrary.Domain.ResponseModels;

namespace AuthService.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthnController : ControllerBase
    {
        private readonly IAuthenticationRepository _authenticationRepository;

        public AuthnController(IAuthenticationRepository authenticationRepository)
        {
            _authenticationRepository = authenticationRepository;
        }

        [HttpPost("login")]
        public ActionResult<LoginResponse> Login(LoginRequest loginData)
        {
            var token = _authenticationRepository.Authenticate(loginData);

            if (token == null)
                return Unauthorized("Wrong e-mial or password");

            var user = token.User;

            return Ok(new LoginResponse() { Id = user.Id, Email = user.Email, FirstName = user.FirstName, Lastname = user.Lastname, AccessToken = token.Token, AccessTokenExpires = token.AccessTokenExpires });
        }

        [HttpPost("register")]
        public ActionResult<string> Register(RegisterRequest register)
        {
            try
            {
                var status = _authenticationRepository.Register(register);

                return Ok(status);
            }
            catch (BadRequestException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
