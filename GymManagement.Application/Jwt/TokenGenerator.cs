using GymManagement.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Jwt
{
    public class TokenGenerator
    {
        private readonly IConfiguration _configuration;
        public TokenGenerator(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Token CreateToken(Member member, List<string> memberRoles)
        {
            var exp = DateTime.Now.AddMinutes(30);
            var token = new Token { Expiration = exp };

            var authClaim = new List<Claim>
            {
                new Claim(ClaimTypes.Name, member.UserName),
                new Claim(ClaimTypes.Name, member.Id)
            };

            foreach (var role in memberRoles)
            {
                if (role is not null)
                {
                    authClaim.Add(new Claim(ClaimTypes.Role, Convert.ToString(role)));
                }
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var securityToken = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Auidence"],
                expires: exp, notBefore: DateTime.Now,
                signingCredentials: credentials,
                claims: authClaim
                );

            var tokenHandler = new JwtSecurityTokenHandler();

            var accessToken = tokenHandler.WriteToken(securityToken);

            token.AccessToken = accessToken;
            token.RefreshToken = Guid.NewGuid().ToString();
            return token;
        }
    }
}
