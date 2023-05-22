using OnionLibrary.Domain.CommonModels;
using OnionLibrary.Domain.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Interfaces.Services
{
    public interface IAuthenticationService
    {
        Tokens Authenticate(LoginRequest user);
    }
}
