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
    public class BuggyController : BaseApiController
    {
        private readonly AppDbContext _context;
        public BuggyController(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            var thing = _context.Products.Find(42);
            if (thing == null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok();
        }

        [HttpGet("servererror")]
        public ActionResult GetServerError()
        {
            var thing = _context.Products.Find(42);
            var thingtoReturn = thing.ToString();
            return Ok();
        }

        [HttpGet("badrequest")]
        public ActionResult GetNotFoundRequest(int id)
        {
            return BadRequest();
        }

        [HttpGet("badrequest/{id}")]
        public ActionResult GetBadRequest(int id)
        {
            return BadRequest(new ApiResponse(400));
        }

        
    }
}
