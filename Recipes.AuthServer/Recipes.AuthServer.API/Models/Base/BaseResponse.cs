using System.Collections.Generic;

namespace Recipes.AuthServer.API.Models.Base
{
    public abstract class BaseResponse
    {
        public BaseResponse()
        {
            Message = new List<string>();
        }

        public List<string> Message { get; set; }
    }
}