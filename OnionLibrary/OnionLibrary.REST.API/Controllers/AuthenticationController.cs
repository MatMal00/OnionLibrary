using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnionLibrary.Application.Interfaces.Repositories;
using OnionLibrary.Domain.DBModels;
using OnionLibrary.Domain.RequestModels;
using OnionLibrary.Domain.ResponseModels;
using System.Data;
using System.Text;

namespace OnionLibrary.REST.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationRepository _tokenRepository;

        public AuthenticationController(IAuthenticationRepository tokenRepository)
        {
            _tokenRepository = tokenRepository; 
        }

        [HttpPost("login")]
        public ActionResult<LoginResponse> Login(LoginRequest loginData)
        {
            var token = _tokenRepository.Authenticate(loginData);

            if (token == null)
                return Unauthorized("Wrong e-mial or password");

            var user = token.User;

            return new LoginResponse() { Id = user.Id, Email = user.Email, FirstName = user.FirstName, Lastname = user.Lastname, AccessToken = token.Token, AccessTokenExpires = token.AccessTokenExpires };
        }
    }
}
