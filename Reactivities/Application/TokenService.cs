using Domain;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application
{
    public class TokenService
    {
        private readonly string _key;
        private readonly string _issuer;
        private readonly string _audience;

        public TokenService(string key, string issuer, string audience)
        {
            _key = key;
            _issuer = issuer;
            _audience = audience;
        }
        public string GenerateToken(UserModel user)
        {
            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
             new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Role, user.Role)  // Add role claim
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: creds
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
