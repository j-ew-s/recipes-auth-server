using System;
using System.Threading.Tasks;
using Recipes.AuthServer.Domain.Entities.Bases;

namespace Recipes.AuthServer.Domain.Services.Bases
{
    public interface IBaseSevice<T> where T : BaseEntity
    {
        /// <summary>
        /// Generic Method.
        /// Looks for T object using ID property from BaseEntity
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>T when its find</returns>
        Task<T> FindById(Guid id);

        /// <summary>
        /// Generic Method.
        /// Crates new object using generic type T that is BaseEntity
        /// </summary>
        /// <param name="id">T</param>
        /// <returns>T when its created</returns>
        Task<T> Create(T genericObject);

        /// <summary>
        /// Generic Method.
        /// Updates object T
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>T when its updated</returns>
        Task<T> Update(T genericObject);

        /// <summary>
        /// Generic Method.
        /// Deletes object that matches the ID property (BaseEntity)
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>True when deleted; False when its not deleted</returns>
        Task<bool> Delete(Guid id);
    }
}