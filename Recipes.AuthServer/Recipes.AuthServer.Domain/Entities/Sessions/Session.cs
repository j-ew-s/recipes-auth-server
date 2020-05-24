using Recipes.AuthServer.Domain.Entities.Bases;
using Recipes.AuthServer.Domain.Entities.Users;

namespace Recipes.AuthServer.Domain.Entities.Sessions
{
    public class Session : BaseEntity
    {
        public User User { get; set; }
    }
}