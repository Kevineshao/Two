using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Two.IDS4
{
    public class IDS4Service : Volo.Abp.Application.Services.ApplicationService , IIDS4Service
    {
        public IConfiguration _configuration;
        //public IDS4Service(IConfiguration configuration);
        public IDS4Service(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public async Task<string> GetIdsTokenAsync(string User_Name, string User_Password)
        {
            var client = new HttpClient();
            var idsTokenUrl = this._configuration.GetSection("AuthServer:Authority").Value;
            var AppClientId = this._configuration.GetSection("AuthServer:AppClientId").Value;
            var AppClientSecret = this._configuration.GetSection("AuthServer:AppClientSecret").Value;
            var disco = client.GetDiscoveryDocumentAsync(idsTokenUrl);

            var tokenRespone = await client.RequestPasswordTokenAsync(
                new PasswordTokenRequest
                {
                    Address = disco.Result.TokenEndpoint,
                    ClientId = AppClientId,
                    ClientSecret = AppClientSecret,
                    UserName = User_Name,
                    Password = User_Password
                });
            if (tokenRespone.IsError)
            {
                return string.Empty;
            }
            return tokenRespone.AccessToken;
        }
    }
}
