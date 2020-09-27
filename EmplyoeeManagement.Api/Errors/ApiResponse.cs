using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Api.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode,string messge = null)
        {
            StatusCode = statusCode;
            Message = messge ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request ,you have a made",
                401 => "Authorized ,your are not ",
                404 => "Resources found,it was not",
                500 => "Errors are path dark side.Errors lead to anger. Anger leads to hate.Hate leads to carrer change",
                _ => null
            };
        }
    }
}
