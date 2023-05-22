using LibraryBackend.RequestModels;
using OnionLibrary.Application.Interfaces.Repositories;
using OnionLibrary.Domain.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Infrastructure.Repositiries
{
    public class UserRepository : IUserRepository
    {
        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserSimplifiedResponse> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void PutUser(int id, UserPutRequest user)
        {
            throw new NotImplementedException();
        }
    }
}
