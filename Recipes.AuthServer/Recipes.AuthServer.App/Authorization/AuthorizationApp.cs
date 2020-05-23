using System;
using Recipes.AuthServer.CrossCutting.DTOs.Login;
using Recipes.AuthServer.CrossCutting.DTOs.Sessions;

namespace Recipes.AuthServer.App.Authorization
{
    public class AuthorizationApp : IAuthorizationApp
    {
        public SessionDTO Login(LoginDTO login)
        {
            throw new NotImplementedException();
        }

        public bool Logout(string sessionId)
        {
            throw new NotImplementedException();
        }
    }
}