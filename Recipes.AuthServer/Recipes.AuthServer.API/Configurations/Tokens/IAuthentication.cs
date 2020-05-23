using Recipes.AuthServer.API.Models.Auth;
using Recipes.AuthServer.CrossCutting.DTOs.Sessions;

namespace Recipes.AuthServer.API.Configurations.Tokens
{
    public interface IAuthentication
    {
        /// <summary>
        /// Produces a UserAuthentication object
        /// based on Session and TokenConfigurations values.
        /// </summary>
        /// <param name="session">SessionDTO</param>
        /// <returns>UserAuthentication</returns>
        UserAuthentication Build(SessionDTO session);
    }
}