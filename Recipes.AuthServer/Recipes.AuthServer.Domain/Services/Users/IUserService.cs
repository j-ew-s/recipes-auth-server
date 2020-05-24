using System.Collections.Generic;
using System.Threading.Tasks;
using Recipes.AuthServer.Domain.Entities.Users;
using Recipes.AuthServer.Domain.Services.Bases;

namespace Recipes.AuthServer.Domain.Services.Users
{
    public interface IUserService : IBaseSevice<User>
    {
        /// <summary>
        ///  Looks for Users that hav a given name
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>List of User</returns>
        Task<List<User>> FindByName(string name);

        /// <summary>
        ///  Looks for Users that hav a given Email
        /// </summary>
        /// <param name="name">string</param>
        /// <returns> User</returns>
        Task<User> FindByEmail(string email);

        /// <summary>
        ///  Looks for Users that matches to a given Login object
        /// </summary>
        /// <param name="name">Login</param>
        /// <returns> User</returns>
        Task<User> FindByLogin(Login login);
    }
}