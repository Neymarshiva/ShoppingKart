using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmplyoeeManagement.Api.Errors;
using EmplyoeeManagement.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace EmplyoeeManagement.Api.Controllers
{
    [Route("errors/{code}")]
    [ApiExplorerSettings(IgnoreApi =true)]
    public class ErrorController : BaseApiController
    {
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
