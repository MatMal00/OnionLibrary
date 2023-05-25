using OnionLibrary.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Domain.ResponseModels
{
    public class LoginResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? AccessToken { get; set; }
        public DateTime AccessTokenExpires { get; set; }

        public virtual Role Role { get; set; }

    }
}
