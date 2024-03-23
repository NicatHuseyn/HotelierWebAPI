using HotelierProject.Application.Features.Commands.RoomCommand.CreateRoom;
using HotelierProject.Application.Features.Commands.RoomCommand.RemoveRoom;
using HotelierProject.Application.Features.Commands.RoomCommand.UpdateRoom;
using HotelierProject.Application.Features.Queries.RoomQuery;
using HotelierProject.Application.Features.Queries.RoomQuery.RoomGetById;
using HotelierProject.Application.Repositories;
using HotelierProject.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoomsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllRoom([FromQuery] GetAllRoomQueryRequest getAllRoomQueryRequest)
        {
            var rooms = await _mediator.Send(getAllRoomQueryRequest);
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoom(int id)
        {
            GetByIdRoomQueryResponse value = await _mediator.Send(new GetByIdRoomQueryRequest(id));
            return Ok(value);
        }


        [HttpPost]
        public async Task<IActionResult> CreateRoom(CreateRoomCommandRequest createRoomCommandRequest)
        {
            CreateRoomCommandResponse response = await _mediator.Send(createRoomCommandRequest);
            return Ok("Created Room");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveRoom(int id)
        {
            await _mediator.Send(new RemoveRoomCommandRequest(id));
            return Ok("Deleted room");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRoom(UpdateRoomCommandRequest updateRoomCommandRequest)
        {
            UpdateRoomCommandResponse response = await _mediator.Send(updateRoomCommandRequest);
            return Ok("Updated room");
        }
    }
}
