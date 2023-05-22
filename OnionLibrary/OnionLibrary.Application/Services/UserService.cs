using LibraryBackend.RequestModels;
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
        private readonly IUserService _userService;

        public UserService(IUserService userService)
        {
            _userService = userService;
        }

        public void DeleteUser(int id)
        {
            _userService.DeleteUser(id);    
        }

        public List<UserSimplifiedResponse> GetUsers()
        {
            var users = _userService.GetUsers();

            return users;
        }

        public void PutUser(int id, UserPutRequest user)
        {
            _userService.PutUser(id, user);
        }
    }
}
