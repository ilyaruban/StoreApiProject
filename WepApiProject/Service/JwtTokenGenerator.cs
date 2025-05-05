using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WepApiProject.Model;

namespace WepApiProject.Service
{
    public class JwtTokenGenerator
    {
        private readonly string secretKey;
        public JwtTokenGenerator(IConfiguration config)
        {
            this.secretKey = config["AuthSettings:SecretKey"];
        }

        public string GenerateJwtToken(AppUser user, IList<string> roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                //информация о пользователе
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    new Claim("FirstName", user.FirstName),
                    new Claim("id", user.Id),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, String.Join(",", roles))
                }),

                Expires = DateTime.UtcNow.AddDays(1),

                //подпись
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
