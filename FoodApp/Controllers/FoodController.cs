using FoodApp.DTO.Request;
using FoodApp.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace FoodApp.Controllers
{
    [ApiController]
    [Route("api/food")]
    public class FoodController : ControllerBase
    {
        private readonly IFoodCrudService _foodCrudService;

        public FoodController(IFoodCrudService foodCrudService)
        {
            _foodCrudService = foodCrudService;
        }

        [HttpGet("all")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllFoodsAsync(CancellationToken cancellationToken)
        {
            var response = await _foodCrudService.GetAllAsync(cancellationToken);

            if (response == null)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        [HttpGet("all-by-type/{typeId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllFooddByTypeAsync([FromRoute] long typeId, CancellationToken cancellationToken)
        {
            var response = await _foodCrudService.GetByTypeAsync(typeId, cancellationToken);

            if (response == null)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetFoodByIdAsync([FromRoute] long id, CancellationToken cancellationToken)
        {
            var response = await _foodCrudService.GetByIdAsync(id, cancellationToken);

            if (response == null)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateFoodAsync([FromBody] CreateFoodRequestDto inputModel, CancellationToken cancellationToken)
        {
            var response = await _foodCrudService.CreateAsync(inputModel, cancellationToken);

            if (response == null)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateFoodInformationAsync([FromRoute] long id, [FromBody] UpdateFoodRequestDto inputModel, CancellationToken cancellationToken)
        {
            var response = await _foodCrudService.UpdateAsync(id, inputModel, cancellationToken);

            if(response == null)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteFoodAsync([FromRoute] long id, CancellationToken cancellationToken)
        {
            var response = await _foodCrudService.DeleteAsync(id, cancellationToken);

            if (response == null)
            {
                return BadRequest();
            }

            return Ok(response);
        }
    }
}
