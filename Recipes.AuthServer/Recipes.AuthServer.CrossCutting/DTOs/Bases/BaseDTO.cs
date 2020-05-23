using System.Collections.Generic;

namespace Recipes.AuthServer.CrossCutting.DTOs.Bases
{
    public class BaseDTO
    {
        public BaseDTO()
        {
            Messages = new List<string>();
        }

        public List<string> Messages { get; set; }
    }
}