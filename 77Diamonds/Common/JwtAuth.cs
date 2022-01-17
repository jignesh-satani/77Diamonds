using _77Diamonds.API.Model;
using _77Diamonds.ViewModel;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace _77Diamonds.Common
{
    public interface IJwtAuth
    {
        AuthenticateResponse GetToken(UserViewModel user);
        //object GetToken(User user);
    }
    public class JwtAuth : IJwtAuth
    {
        private readonly AppSettings _appSettings;
        public JwtAuth(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }
        public AuthenticateResponse GetToken(UserViewModel user)
        {


            // 1. Create Security Token Handler
            var tokenHandler = new JwtSecurityTokenHandler();

            // 2. Create Private Key to Encrypted
            var tokenKey = Encoding.ASCII.GetBytes(_appSettings.Secret);

            //3. Create JETdescriptor              
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Issuer = "http://localhost:38225/",
                Audience = "http://localhost:55243/",
                Subject = new ClaimsIdentity(
                 new Claim[]
                 {
                        new Claim("Email", user.Email)
                 }, "Cookies"),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            //4. Create Token
            var token = tokenHandler.CreateToken(tokenDescriptor);


            // 5. Return Token from method
            //return tokenHandler.WriteToken(token);
            return new AuthenticateResponse(user, tokenHandler.WriteToken(token));
        }
    }
}
