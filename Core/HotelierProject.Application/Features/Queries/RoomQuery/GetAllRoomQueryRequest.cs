﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.RoomQuery
{
    public class GetAllRoomQueryRequest:IRequest<List<GetAllRoomQueryResponse>>
    {
    }
}
