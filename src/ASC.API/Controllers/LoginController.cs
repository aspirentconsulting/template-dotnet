using ASC.API.Request;
using ASC.API.Response;
using Microsoft.AspNetCore.Mvc;

namespace ASC.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetGreet")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult GetGreet()
        {
            var myResponse = "Hello from Core 7.0!";
            return Ok(myResponse);
        }

        [HttpGet("GreetUser/{name}", Name = "GreetUserByPath")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult GreetUserByPath(string name)
        {
            var myResponse = "Hello from Core 7.0, " + name;
            return Ok(myResponse);
        }

        [HttpPost("GreetUserByPost", Name = "GreetUserByPost")]
        [ProducesResponseType(typeof(Greeting), StatusCodes.Status201Created)]
        public IActionResult GreetUserByPost(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("invalid input");
            }

            Greeting greeting = new(user.Name);
            return Created(string.Empty, greeting);
        }
    }
}