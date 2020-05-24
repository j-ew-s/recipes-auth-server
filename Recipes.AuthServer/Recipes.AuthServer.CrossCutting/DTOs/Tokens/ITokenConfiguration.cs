using System;
using Microsoft.IdentityModel.Tokens;

namespace Recipes.AuthServer.CrossCutting.DTOs.Tokens
{
    public interface ITokenConfiguration
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public Int32 TimeInSeconds { get; set; }
        public string Key { get; set; }

        /// <summary>
        /// Gets Symmetric Security Key using the Key property.
        /// Gets the bytes from KEY using Encoding.UTF8 and
        /// its used tocreate a SymmetricSecurityKey instance.
        /// </summary>
        /// <returns>SymmetricSecurityKey</returns>
        SymmetricSecurityKey GetKey();

        /// <summary>
        /// Gets SigningCredentials
        /// Using GetKey its possible to create a new SigningCredentials
        /// by using SecurityAlgorithms.RsaSha256Signature algorithm
        /// </summary>
        /// <returns>SigningCredentials</returns>
        SigningCredentials GetSigningCredentials();
    }
}