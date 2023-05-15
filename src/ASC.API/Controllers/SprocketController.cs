using ASC.Application.Common;
using ASC.Application.Sprockets.Common;
using ASC.Application.Sprockets.FindAll;
using ASC.Application.Sprockets.Insert;
using ASC.Application.Sprockets.Update;
using Microsoft.AspNetCore.Mvc;

namespace ASC.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SprocketController : ControllerBase
    {
        private readonly ISprocketService _sprocketService;

        public SprocketController(ISprocketService sprocketService)
        {
            _sprocketService = sprocketService;
        }

        [HttpPost(Name = "InsertSprocket")]
        [ProducesResponseType(typeof(SprocketResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(BadRequestResult), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Insert(InsertSprocketRequest request)
        {
            if (!ModelState.IsValid)
            {
                var modelErrors = ModelState.Values.SelectMany(modelStateEntry => modelStateEntry.Errors).ToList();

                return BadRequest(modelErrors);
            }

            var response = await _sprocketService.Insert(request);

            return Created(string.Empty, response);
        }

        [HttpPut(Name = "UpdateSprocket")]
        [ProducesResponseType(typeof(SprocketResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestResult), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(UpdateSprocketRequest request)
        {
            if (!ModelState.IsValid)
            {
                var modelErrors = ModelState.Values.SelectMany(modelStateEntry => modelStateEntry.Errors).ToList();

                return BadRequest(modelErrors);
            }

            var response = await _sprocketService.Update(request);

            return Ok(response);
        }

        [HttpDelete("{id:guid}", Name = "DeleteSprocket")]
        [ProducesResponseType(typeof(SprocketResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestResult), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("Guid may not be empty.");
            }

            var response = await _sprocketService.Delete(id);

            return Ok(response);
        }

        [HttpGet(Name = "FindAllSprockets")]
        [ProducesResponseType(typeof(PageResponse<SprocketResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> FindAll(int page = 0, int pageSize = 10)
        {
            var response = await _sprocketService.FindAll(new FindAllSprocketsRequest(page, pageSize));

            return Ok(response);
        }

        [HttpGet("{id:guid}", Name = "FindSprocketById")]
        [ProducesResponseType(typeof(SprocketResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestResult), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> FindById(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("Guid may not be empty.");
            }

            var response = await _sprocketService.FindById(id);

            return Ok(response);
        }
    }
}
