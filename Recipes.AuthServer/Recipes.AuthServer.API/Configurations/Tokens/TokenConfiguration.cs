using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Recipes.AuthServer.API.Configurations.Tokens
{
    public class TokenConfiguration : ITokenConfiguration
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int TimeInSeconds { get; set; }
        public string Key { get; set; }

        public SymmetricSecurityKey GetKey()
        {
            var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.Key));
            return symmetricKey;
        }

        public SigningCredentials GetSigningCredentials()
        {
            return new SigningCredentials(this.GetKey(), SecurityAlgorithms.RsaSha256Signature);
        }
    }
}