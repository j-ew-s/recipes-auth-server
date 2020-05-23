using System;
using Recipes.AuthServer.CrossCutting.DTOs.Bases;

namespace Recipes.AuthServer.CrossCutting.DTOs.Sessions
{
    public class SessionDTO : BaseDTO
    {
        public Guid SessionId { get; set; }
    }
}