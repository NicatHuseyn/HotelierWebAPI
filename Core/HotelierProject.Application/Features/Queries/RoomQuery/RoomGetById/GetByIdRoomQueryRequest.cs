using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.RoomQuery.RoomGetById
{
    public class GetByIdRoomQueryRequest:IRequest<GetByIdRoomQueryResponse>
    {
        public GetByIdRoomQueryRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
