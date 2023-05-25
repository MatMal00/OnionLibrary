using OnionLibrary.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Domain.CommonModels
{
    public class Tokens
    {
        public string Token { get; set; } = string.Empty;
        public DateTime AccessTokenExpires { get; set; }
        public User User { get; set; }
        public virtual Role Role { get; set; }
    }
}


