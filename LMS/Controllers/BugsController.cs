using LMS.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Api.Controllers
{
    [ApiController]
    public class BugsController : BaseApiController
    {
        [HttpGet("unauthorized")]
        public IActionResult GetUnAuthorized()
        {
            return Unauthorized();
        }

        [HttpGet("bad-request")]
        public IActionResult GetBadRequest()
        {
            return BadRequest();
        }

        [HttpGet("not-found")]
        public IActionResult GetNotFound()
        {
            return NotFound();
        }

        [HttpGet("internal-server-error")]
        public IActionResult GetInternalError()
        {
            throw new Exception("Test exception");
        }

        [HttpPost("validation-error")]
        public IActionResult GetValidationError(Person person)
        {
            return Ok();
        }


    }
}
