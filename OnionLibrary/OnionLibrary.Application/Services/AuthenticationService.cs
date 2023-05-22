using OnionLibrary.Application.Interfaces.Repositories;
using OnionLibrary.Application.Interfaces.Services;
using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.CommonModels;
using OnionLibrary.Domain.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationRepository _authenticationRepository;

        public AuthenticationService(IAuthenticationRepository authenticationRepository)
        {
            _authenticationRepository = authenticationRepository; 
        }

        public Tokens Authenticate(LoginRequest user)
        {
            var token = _authenticationRepository.Authenticate(user);

            return token;
        }

        public CommonStatus Register(RegisterRequest user)
        {
            var status = _authenticationRepository.Register(user);

            return status;
        }
    }
}
