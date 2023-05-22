using LibraryBackend.RequestModels;
using OnionLibrary.Application.Interfaces.Repositories;
using OnionLibrary.Application.Interfaces.Services;
using OnionLibrary.Domain.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);    
        }

        public List<UserSimplifiedResponse> GetUsers()
        {
            var users = _userRepository.GetUsers();

            return users;
        }

        public void PutUser(int id, UserPutRequest user)
        {
            _userRepository.PutUser(id, user);
        }
    }
}
