using System.Collections.Generic;

namespace Recipes.AuthServer.CrossCutting.DTOs.Bases
{
    public class ResponseDTO<T> where T : class
    {
        public ResponseDTO()
        {
            Messages = new List<string>();
        }

        /// <summary>
        /// When a message is set it indicates that something whent wrong.
        /// Messages are only used to indicate a behavior not expected by
        /// the client due the Request status (Success, Errors, Bad Requests) will be indicated by HTTP Status.
        /// </summary>
        public List<string> Messages { get; set; }

        /// <summary>
        /// Have Payload information.
        /// The Content Expected by the Client.
        /// </summary>
        public T Payload { get; set; }
    }
}