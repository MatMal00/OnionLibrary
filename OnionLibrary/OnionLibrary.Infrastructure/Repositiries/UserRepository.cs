using LibraryBackend.RequestModels;
using Microsoft.EntityFrameworkCore;
using OnionLibrary.Application.Interfaces.Repositories;
using OnionLibrary.Domain.CommonModels;
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

        public void PutUser(int id, UserPutRequest user)
        {
            if (id != user.Id)
                throw new BadRequestException("Users are different");

            var userFromDb = _libraryDbContext.Users.Find(user.Id);

            if (userFromDb == null)
                throw new BadRequestException("Something went wrong");

            var roles = _libraryDbContext.Roles.ToList();

            userFromDb.FirstName = user.FirstName;
            userFromDb.Lastname = user.Lastname;
            userFromDb.Email = user.Email;
            userFromDb.RoleId = roles.Find(role => role.RoleName == user.RoleName).Id;

            _libraryDbContext.Entry(userFromDb).State = EntityState.Modified;

            try
            {
                _libraryDbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    throw new NotFoundException("Not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        private bool UserExists(int id)
        {
            return _libraryDbContext.Users.Any(e => e.Id == id);
        }
    }
}
