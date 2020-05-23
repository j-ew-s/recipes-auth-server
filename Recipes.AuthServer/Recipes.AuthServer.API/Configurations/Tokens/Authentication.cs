using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Recipes.AuthServer.API.Models.Auth;
using Recipes.AuthServer.CrossCutting.DTOs.Sessions;

namespace Recipes.AuthServer.API.Configurations.Tokens
{
    public class Authentication : IAuthentication
    {
        private readonly ITokenConfiguration tokenConfiguration;
        private DateTime NotBefore { get; set; }
        private DateTime Expires { get; set; }

        public Authentication(ITokenConfiguration tokenConfiguration)
        {
            this.tokenConfiguration = tokenConfiguration;
        }

        public UserAuthentication Build(SessionDTO session)
        {
            this.SetDates();

            var jwtToken = this.PrepareJwtToken(session);

            return new UserAuthentication
            {
                Token = jwtToken
            };
        }

        /// <summary>
        /// Prepare CreatedAt and ExpiresAt dates to be used on JWT Token
        /// CreatedAt =>
        /// </summary>
        private void SetDates()
        {
            this.NotBefore = DateTime.UtcNow;
            this.Expires = this.NotBefore + TimeSpan.FromSeconds(this.tokenConfiguration.TimeInSeconds);
        }

        /// <summary>
        /// Produces a new JwtSecurityToken using
        ///  the Session info and TokenConfiguration.
        /// With a JwtSecurityToken writes and return a JWT Token
        /// </summary>
        /// <param name="session">SessionDTO</param>
        /// <returns> string </returns>
        private string PrepareJwtToken(SessionDTO session)
        {
            var token = new JwtSecurityToken(
               this.tokenConfiguration.Issuer,
               this.tokenConfiguration.Audience,
               this.SetClaims(session),
               this.NotBefore,
               this.Expires,
               this.tokenConfiguration.GetSigningCredentials());

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        /// <summary>
        /// Create Claims based on User data.
        /// </summary>
        /// <param name="session">SessionDTO</param>
        /// <returns>Array of Claim</returns>
        private Claim[] SetClaims(SessionDTO session)
        {
            return new[]
            {
                new Claim("Session",session.SessionId.ToString())
            };
        }
    }
}