using Microsoft.AspNetCore.Mvc;

namespace ASC.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{}", Name = nameof(GetGreet))]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult GetGreet()
        {
            var myResponse = "Hello from Core 7.0!";
            return Ok(myResponse);
        }

        // [HttpGet(Name = "GreetUserByPath")]
        // [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        // [Route("Login/GreetUser/{name}")]
        // public IActionResult GreetUserByPath(string name)
        // {
        //    var myResponse = "Hello from Core 7.0, " + name;
        //    return Ok(myResponse);
        // }
    }
}