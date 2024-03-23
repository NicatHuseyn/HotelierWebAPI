using HotelierProject.Application.Features.Commands.StaffCommand.CreateStaff;
using HotelierProject.Application.Features.Commands.StaffCommand.RemoveStaff;
using HotelierProject.Application.Features.Commands.StaffCommand.UpdateStaff;
using HotelierProject.Application.Features.Queries.StaffQuery.GetAllStaff;
using HotelierProject.Application.Features.Queries.StaffQuery.GetByIdStaff;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public StaffsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]GetAllStaffQueryRequest getAllStaffQueryRequest)
        {
            var response = await _mediator.Send(getAllStaffQueryRequest);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaff([FromQuery]GetByIdStaffQueryRequest getByIdStaffQueryRequest)
        {
            var response = await _mediator.Send(getByIdStaffQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStaff(CreateStaffCommandRequest createStaffCommandRequest)
        {
            if (ModelState.IsValid)
            {

            }
            var response = await _mediator.Send(createStaffCommandRequest);
            return Ok("Created Staff");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStaff(UpdateStaffCommandRequest updateStaffCommandRequest)
        {
            await _mediator.Send(updateStaffCommandRequest);
            return Ok("Updated Staff");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveStaff([FromQuery]RemoveStaffCommandRequest removeStaffCommandRequest)
        {
            await _mediator.Send(removeStaffCommandRequest);
            return Ok("Removed Staff");
        }
    }
}
