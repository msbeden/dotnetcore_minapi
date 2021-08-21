using minimumApi.Models;
using minimumApi.Models.DatabaseModels.Auth;
using minimumApi.Models.ViewModels.Login;
using minimumApi.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace minimumApi.Services
{
    public class TokenManagerService : ITokenManagerService
    {
        private readonly byte[] _secretBytes;
        public TokenManagerService(IConfiguration configuration)
        {
            string jwtSecretKey = configuration.GetValue<string>("JwtConfiguration:Secret");
            this._secretBytes = Encoding.ASCII.GetBytes(jwtSecretKey);
        }
        public string GenerateToken(AuthUser user, IEnumerable<AuthGroup> userGroups)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            AuthGroup authGroup = userGroups.ToList().OrderByDescending(i => i.Priority).FirstOrDefault();
            if (authGroup == null) authGroup =new AuthGroup {  AuthGroupName = "UnknownGroup" };

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.Username),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("EMail",user.EMail?? string.Empty),
                    new Claim("UserId", user.AuthUserId.ToString()),
                    new Claim("Username",user.Username??string.Empty),
                    new Claim("FirstName", user.FirstName?? string.Empty),
                    new Claim("MiddleName",user.MiddleName?? string.Empty),
                    new Claim("LastName", user.LastName?? string.Empty),
                    new Claim("Gsm",user.Gsm?? string.Empty),
                    new Claim("UserGroupId", authGroup.AuthGroupId.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(this._secretBytes), SecurityAlgorithms.HmacSha256Signature)
            };

            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            string jwtToken = tokenHandler.WriteToken(token);
            return jwtToken;
        }

        public ServiceResponse<ValidateTokenResponseViewModel> ValidateToken(string jwtToken)
        {
            if (string.IsNullOrEmpty(jwtToken))
            {
                return new ServiceResponse<ValidateTokenResponseViewModel> { IsSuccessful = false };
            }

            jwtToken = jwtToken.Split(' ').LastOrDefault();
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            ClaimsPrincipal token = tokenHandler.ValidateToken(jwtToken, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(this._secretBytes),
                ValidateLifetime = true,
                ValidateAudience = false,
                ValidateIssuer = false,
                ClockSkew = TimeSpan.Zero,
            }, out SecurityToken validatedToken);

            Dictionary<string, string> claims = token.Claims.ToDictionary(x => x.Type, x => x.Value);
            ServiceResponse<ValidateTokenResponseViewModel> response = new ServiceResponse<ValidateTokenResponseViewModel>
            {
                Entity = new ValidateTokenResponseViewModel
                {
                    UserId = int.Parse(claims["UserId"]),
                    Username = claims["Username"],
                    Email = claims["EMail"],
                    FirstName = claims["FirstName"],
                    MiddleName = claims["MiddleName"],
                    LastName = claims["LastName"],
                    Gsm = claims["Gsm"],
                    ExpiredDate = validatedToken.ValidTo
                },
                IsSuccessful = true,
                Count = 1
            };

            return response;
        }
    }
}
