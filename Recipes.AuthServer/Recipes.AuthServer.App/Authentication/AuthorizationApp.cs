using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Recipes.AuthServer.CrossCutting.DTOs.Login;
using Recipes.AuthServer.CrossCutting.DTOs.Sessions;
using Recipes.AuthServer.CrossCutting.DTOs.Tokens;

namespace Recipes.AuthServer.App.Authentication
{
    public class AuthorizationApp : IAuthorizationApp
    {
        private readonly ITokenConfiguration tokenConfiguration;
        private DateTime NotBefore { get; set; }
        private DateTime Expires { get; set; }

        public AuthorizationApp(ITokenConfiguration tokenConfiguration)
        {
            this.tokenConfiguration = tokenConfiguration;
        }

        public SessionDTO Login(LoginDTO login)
        {
            throw new System.NotImplementedException();
        }

        public bool Logout(string sessionId)
        {
            throw new System.NotImplementedException();
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