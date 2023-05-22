using OnionLibrary.Application.Repositories;
using OnionLibrary.Application.Services;
using OnionLibrary.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Application.Services
{
    public class RoleService: IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public List<Role> GetRoles()
        {
            var roles = _roleRepository.GetRoles();
            return roles;
        }

        public Role CreateRole(Role role)
        {
            _roleRepository.CreateRole(role);

            return role;
        }
    }
}
