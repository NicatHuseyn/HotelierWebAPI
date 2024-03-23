using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.RoomCommand.UpdateRoom
{
    public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommandRequest, UpdateRoomCommandResponse>
    {
        private readonly IRoomReadRepository _roomReadRepository;
        private readonly IRoomWriteRepository _roomWriteRepository;

        public UpdateRoomCommandHandler(IRoomWriteRepository roomWriteRepository, IRoomReadRepository roomReadRepository)
        {
            _roomWriteRepository = roomWriteRepository;
            _roomReadRepository = roomReadRepository;
        }

        public async Task<UpdateRoomCommandResponse> Handle(UpdateRoomCommandRequest request, CancellationToken cancellationToken)
        {
            var room = await _roomReadRepository.GetByIdAsync(request.Id);
            room.Description = request.Description;
            room.Price = request.Price;
            room.Title = request.Title;
            room.BathCount = request.BathCount;
            room.BedCount = request.BedCount;
            room.RoomNumber = request.RoomNumber;
            room.RoomCoverImage = request.RoomCoverImage;
            _roomWriteRepository.Update(room);
            await _roomWriteRepository.SaveAsync();

            return new();
        }
    }
}
