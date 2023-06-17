﻿using BooberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using BuberBreakfast.Services.Breakfasts;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controller
{
    [ApiController]  // it does some heavy lisfting for us
    [Route("[controller]")]
    public class BreakfastsController :ControllerBase
    {
        private readonly IBreakfastService _breakfastService;
       

        public BreakfastsController(IBreakfastService breakfastService)
        {
            _breakfastService = breakfastService;
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
            var response = new BreakfastResponse(
                breakfasts.Id,
                breakfasts.Name,
                breakfasts.Description,
                breakfasts.StartDateTime,
                breakfasts.LastModifiedDateTime,
                breakfasts.Savory,
                breakfasts.Sweet
                );

            return CreatedAtAction(nameof(GetBreakfast), new { id = breakfasts.Id }, breakfasts);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetBreakfast(Guid id)
        {
            var breakfastResponse = _breakfastService.GetBreakfast(id);
            return Ok(breakfastResponse);

        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpsertBreakfast(Guid id,   UpsertBreakfastRequest request)
        {
            return Ok(request);

        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteBreakfast(Guid id)
        {
            return Ok(id);

        }
    }
}