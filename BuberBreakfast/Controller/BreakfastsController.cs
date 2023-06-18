using AutoMapper;
using BooberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using BuberBreakfast.ServiceErrors;
using BuberBreakfast.Services.Breakfasts;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controller
{
    [ApiController]  // it does some heavy lisfting for us
    [Route("[controller]")]
    public class BreakfastsController :ControllerBase
    {
        private readonly IBreakfastService _breakfastService;
        private readonly IMapper _mapper;

        public BreakfastsController(IBreakfastService breakfastService, IMapper mapper)
        {
            _breakfastService = breakfastService;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult CreateBreakfast([FromBody]CreateBreakfastRequest request)
        {
                            var breakfasts = new Breakfast(
                     Guid.NewGuid(),
                     request.Name,
                     request.Description,
                     request.StartDateTime,
                     DateTime.UtcNow,
                     request.Savory,
                     request.Sweet
                 );

            // save breakfast to databaseu 
            _breakfastService.CreateBreakfast(breakfasts);
            var response = _mapper.Map<BreakfastResponse>(breakfasts);

            return CreatedAtAction(nameof(GetBreakfast), new { id = breakfasts.Id }, breakfasts);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetBreakfast(Guid id)
        {
            var breakfastResponse = _breakfastService.GetBreakfast(id);
            if(breakfastResponse.IsError && breakfastResponse.FirstError == Errors.Breakfast.Notfound)
            {
                return NotFound();
            }
            return Ok(breakfastResponse);

        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpsertBreakfast(Guid id,  [FromBody] UpsertBreakfastRequest request)
        {
            var breakfast = new Breakfast(
                id,
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                request.Savory,
                request.Sweet);

            int flag = _breakfastService.UpdateBreakfast(id, breakfast);

            if (flag == 0)
            {
                return CreatedAtAction(nameof(GetBreakfast), new { id = breakfast.Id }, breakfast);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteBreakfast(Guid id)
        {
            _breakfastService.DeleteBreakfast(id);
            return NoContent();

        }
    }
}
