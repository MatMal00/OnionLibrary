using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OnionLibrary.Application.Interfaces.Repositories;
using OnionLibrary.Domain.CommonModels;
using OnionLibrary.Domain.RequestModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnionLibrary.Infrastructure.Repositiries
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly LibraryDbContext _libraryDbContext;
        private readonly IConfiguration _configuration;


        public AuthenticationRepository(LibraryDbContext libraryDbContext, IConfiguration configuration)
        {
            _libraryDbContext = libraryDbContext;
            _configuration = configuration;
        }
    
        public Tokens Authenticate(LoginRequest loginData)
        {
            var users = _libraryDbContext.Users.ToList();
            var user = users.Find(user => user.Email == loginData.Email);

            if (user == null || user.Email != loginData.Email || Encoding.UTF8.GetString(user.PasswordHash) != loginData.Password)
                return null;

            var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", user.Id.ToString()),
                        new Claim("UserFirstName", user.FirstName),
                        new Claim("UserLastName", user.FirstName),
                        new Claim("Email", user.Email),
                        new Claim("UserRoleId", user.RoleId.ToString()),
                    };

            var expires = DateTime.Now.AddMinutes(30);
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires,
                signingCredentials: signIn);


            return new Tokens { Token = new JwtSecurityTokenHandler().WriteToken(token), AccessTokenExpires = expires, User = user };
        }
    }
}
