using HotelierProject.Application.Features.Commands.ServiceCommand.CreateService;
using HotelierProject.Application.Features.Commands.ServiceCommand.RemoveService;
using HotelierProject.Application.Features.Commands.ServiceCommand.UpdateService;
using HotelierProject.Application.Features.Queries.ServiceQuery.GetAllService;
using HotelierProject.Application.Features.Queries.ServiceQuery.GetByIdService;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]GetAllServiceQueryRequest getAllServiceQueryRequest)
        {
            var response = await _mediator.Send(getAllServiceQueryRequest);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService([FromQuery]GetByIdServiceQueryRequest getByIdServiceQueryRequest)
        {
            var response = await _mediator.Send(getByIdServiceQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceCommandRequest createServiceCommandRequest)
        {
            CreateServiceCommandResponse response = await _mediator.Send(createServiceCommandRequest);
            return Ok("Created Service");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveService([FromQuery]RemoveServiceCommandRequest removeServiceCommandRequest)
        {
            var response = await _mediator.Send(removeServiceCommandRequest);
            return Ok("Deleted Service");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceCommandRequest updateServiceCommandRequest)
        {
            var response = await _mediator.Send(updateServiceCommandRequest);
            return Ok("Updated Service");
        }
    }
}
