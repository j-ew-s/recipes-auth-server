using Recipes.AuthServer.CrossCutting.DTOs.Login;
using Recipes.AuthServer.CrossCutting.DTOs.Sessions;

namespace Recipes.AuthServer.App.Authentication
{
    public interface IAuthorizationApp
    {
        SessionDTO Login(LoginDTO login);

        bool Logout(string sessionId);
    }
}