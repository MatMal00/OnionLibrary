using LibraryBackend.RequestModels;
using OnionLibrary.Domain.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Interfaces.Services
{
    public interface IUserService
    {
        List<UserSimplifiedResponse> GetUsers();
        void PutUser(int id, UserPutRequest user);
        void DeleteUser(int id);
    }
}
