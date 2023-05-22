using LibraryBackend.Models;
using OnionLibrary.Domain.CommonModels;
using OnionLibrary.Domain.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Interfaces.Repositories
{
    public interface ITokenRepository
    {
        Tokens Authenticate(LoginRequest user);
    }
}
