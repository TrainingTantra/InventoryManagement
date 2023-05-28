using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using System.Security.Claims;

namespace Utils
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly Dictionary<string, string> userDetails= new Dictionary<string, string>(){
            {"manikishore","bolluman"},{ "manoj", "medamanoj" }
            };
        private readonly string key;
        public AuthenticationManager(string key)
        {
            this.key = key;
        }
        public string? Authenticator(string username, string password)
        {
            if(!userDetails.Any(x=> x.Key == username && x.Value == password))
            {
                return null;
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, username)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
