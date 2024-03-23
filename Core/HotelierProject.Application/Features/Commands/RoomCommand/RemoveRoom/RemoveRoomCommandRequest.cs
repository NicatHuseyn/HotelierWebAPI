using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Commands.RoomCommand.RemoveRoom
{
    public class RemoveRoomCommandRequest:IRequest<RemoveRoomCommandResponse>
    {
        public RemoveRoomCommandRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
