using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Api.Errors
{
    public class ApiException : ApiResponse
    {
        public ApiException(int statusCode, string messge = null,string details = null):base(statusCode,messge)
        {
            Details = details;
        }

        public string Details { get; set; }
    }
}
