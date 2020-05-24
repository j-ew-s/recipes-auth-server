using System;
using System.Collections.Generic;
using Recipes.AuthServer.CrossCutting.DTOs.Bases;

namespace Recipes.AuthServer.CrossCutting.DTOs.Users
{
    public class UserDTO
    {
        public UserDTO()
        {
            Roles = new List<string>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
    }
}