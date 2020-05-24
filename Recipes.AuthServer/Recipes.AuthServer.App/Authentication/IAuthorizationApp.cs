using Recipes.AuthServer.CrossCutting.DTOs.Login;
using Recipes.AuthServer.CrossCutting.DTOs.Sessions;

namespace Recipes.AuthServer.App.Authentication
{
    public interface IAuthorizationApp
    {
        SessionDTO Login(LoginDTO login);

        bool Logout(string sessionId);

        /// <summary>
        /// Produces a UserAuthentication object
        /// based on Session and TokenConfigurations values.
        /// </summary>
        /// <param name="session">SessionDTO</param>
        /// <returns>UserAuthentication</returns>
        UserAuthentication Build(SessionDTO session);
    }
}