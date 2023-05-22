using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Domain.RequestModels
{
    public class LoginRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class RegisterRequest
    {
        public string FirstName { get; set; } = string.Empty;   
        public string Lastname { get; set; } = string.Empty;    
        public string Email { get; set; } = string.Empty;   
        public string Password { get; set; } = string.Empty;    
    }
}
