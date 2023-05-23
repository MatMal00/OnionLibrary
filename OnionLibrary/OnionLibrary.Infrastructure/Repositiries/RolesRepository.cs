using OnionLibrary.Application.Repositories;
using OnionLibrary.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public List<Role> GetRoles()
        {
            return _libraryDbContext.Roles.ToList();
        }

        public Role CreateRole(Role role)
        {
            if (role == null)
                throw new ArgumentNullException(nameof(role));

            if (!ValidateRole(role))
                throw new ArgumentException("Invalid role data");

            _libraryDbContext.Roles.Add(role);
            _libraryDbContext.SaveChanges();

            return role;
        }

        private bool ValidateRole(Role role)
        {
            var validationContext = new ValidationContext(role);
            var validationResults = new List<ValidationResult>();

            return Validator.TryValidateObject(role, validationContext, validationResults, true);
        }

    }
}
