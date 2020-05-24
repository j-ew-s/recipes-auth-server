using System;

namespace Recipes.AuthServer.Domain.Entities.Bases
{
    public class BaseEntity
    {
        public DateTime CreatedAd { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Active { get; set; }
    }
}