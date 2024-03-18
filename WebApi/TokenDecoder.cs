using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace WebApi
{
    public static class TokenDecoder
    {
        public static string GetUserId(string? bearerToken)
        {
            if (string.IsNullOrWhiteSpace(bearerToken))
                return null;
            string extractedTokenValue = bearerToken.Replace($"{JwtBearerDefaults.AuthenticationScheme} ", String.Empty);
            JwtSecurityToken token = new JwtSecurityTokenHandler().ReadJwtToken(extractedTokenValue);
            return token.Subject;
        }
    }
}
