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
    public class TokenService : ITokenService
    {
        private readonly ITokenRepository _tokenRepository;

        public TokenService(ITokenRepository tokenRepository)
        {
            _tokenRepository = tokenRepository; 
        }

        public Tokens Authenticate(LoginRequest user)
        {
            var token = _tokenRepository.Authenticate(user);

            return token;
        }
    }
}
