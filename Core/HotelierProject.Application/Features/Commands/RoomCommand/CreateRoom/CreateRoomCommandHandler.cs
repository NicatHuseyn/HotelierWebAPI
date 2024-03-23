using HotelierProject.Application.Repositories;
using HotelierProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.RoomCommand.CreateRoom
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommandRequest, CreateRoomCommandResponse>
    {
        private readonly IRoomWriteRepository _roomWriteRepository;

        public CreateRoomCommandHandler(IRoomWriteRepository roomWriteRepository)
        {
            _roomWriteRepository = roomWriteRepository;
        }

        public async Task<CreateRoomCommandResponse> Handle(CreateRoomCommandRequest request, CancellationToken cancellationToken)
        {
            await _roomWriteRepository.AddAsync(new Room
            {
                BedCount = request.BedCount,
                Description = request.Description,
                BathCount = request.BathCount,
                Price = request.Price,
                RoomCoverImage = request.RoomCoverImage,
                RoomNumber = request.RoomNumber,
                Title = request.Title
            });

            await _roomWriteRepository.SaveAsync();

            return new();
        }
    }
}
