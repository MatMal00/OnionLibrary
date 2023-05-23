using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Infrastructure.Repositiries
{
    public class RolesRepository : IRoleRepository
    {
        private readonly LibraryDbContext _libraryDbContext;

        public RolesRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        public Role CreateRole(Role role)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetRoles()
        {
            throw new NotImplementedException();
        }
    }
}
