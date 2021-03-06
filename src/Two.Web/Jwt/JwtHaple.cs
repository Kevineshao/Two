using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Two.Web.Jwt
{
    public class JwtHaple
    {
        public static string CreateToken(string userName)
        {
            var claims = new[] 
            { 
                new Claim(JwtRegisteredClaimNames.Nbf, 
                $"{new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()}"), 
                new Claim(JwtRegisteredClaimNames.Exp, 
                $"{new DateTimeOffset(DateTime.Now.AddMinutes(30)).ToUnixTimeSeconds()}"), 
                new Claim(ClaimTypes.Name, userName) 
            }; 
            var key = new 
                SymmetricSecurityKey(Encoding.UTF8.GetBytes(Const.SecurityKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256); 
            var token = new JwtSecurityToken
                (
                issuer: Const.Issuer, 
                audience: Const.Aduience, 
                claims: claims, 
                expires: DateTime.Now.AddMinutes(30), 
                signingCredentials: creds
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
