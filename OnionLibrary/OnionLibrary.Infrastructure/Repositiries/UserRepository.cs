using LibraryBackend.RequestModels;
using Microsoft.EntityFrameworkCore;
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
        private readonly LibraryDbContext _libraryDbContext;

        public UserRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        public List<UserSimplifiedResponse> GetUsers()
        {
            var users = _libraryDbContext.Users.ToList();
            var roles = _libraryDbContext.Roles.ToList();

            return users.Select(user => new UserSimplifiedResponse()
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                Lastname = user.Lastname,
                Role = roles.Find(role => role.Id == user.RoleId),
            }).ToList();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void PutUser(int id, UserPutRequest user)
        {
            throw new NotImplementedException();
        }
    }
}
