using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.RoomCommand.RemoveRoom
{
    public class RemoveRoomCommandHandler : IRequestHandler<RemoveRoomCommandRequest, RemoveRoomCommandResponse>
    {
        private readonly IRoomWriteRepository _roomWriteRepository;
        private readonly IRoomReadRepository _roomReadRepository;
        public RemoveRoomCommandHandler(IRoomWriteRepository roomWriteRepository, IRoomReadRepository roomReadRepository)
        {
            _roomWriteRepository = roomWriteRepository;
            _roomReadRepository = roomReadRepository;
        }

        public async Task<RemoveRoomCommandResponse> Handle(RemoveRoomCommandRequest request, CancellationToken cancellationToken)
        {
            var room = await _roomReadRepository.GetByIdAsync(request.Id);
            _roomWriteRepository.Remove(room);
            await _roomWriteRepository.SaveAsync();
            return new();
        }
    }
}
