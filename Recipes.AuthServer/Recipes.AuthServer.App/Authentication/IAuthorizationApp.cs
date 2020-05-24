using System.Threading.Tasks;
using Recipes.AuthServer.CrossCutting.DTOs.Bases;
using Recipes.AuthServer.CrossCutting.DTOs.Login;
using Recipes.AuthServer.CrossCutting.DTOs.Sessions;

namespace Recipes.AuthServer.App.Authentication
{
    public interface IAuthorizationApp
    {
        /// <summary>
        /// Validating LoginDTO data to perform Authorization.
        /// When Data is Valid :
        ///  - Session is created
        ///  - Token withing SessionID will be produced and returnd
        /// When Data is Invalid :
        ///  -
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        Task<ResponseDTO<SessionTokenDTO>> Login(LoginDTO login);

        /// <summary>
        /// Removes login session
        /// When Session is removed :
        ///  - Set Session as closed
        ///  - Returns Payload indicating process worked
        /// When Session could not be removed :
        ///  - Returns Payload indicating the failure
        /// </summary>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        Task<ResponseDTO<string>> Logout(string sessionId);
    }
}