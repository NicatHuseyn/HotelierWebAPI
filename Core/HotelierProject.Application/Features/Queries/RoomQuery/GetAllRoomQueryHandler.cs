using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.RoomQuery
{
    public class GetAllRoomQueryHandler : IRequestHandler<GetAllRoomQueryRequest, List<GetAllRoomQueryResponse>>
    {
        private readonly IRoomReadRepository _roomReadRepository;

        public GetAllRoomQueryHandler(IRoomReadRepository roomReadRepository)
        {
            _roomReadRepository = roomReadRepository;
        }

        public async Task<List<GetAllRoomQueryResponse>> Handle(GetAllRoomQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _roomReadRepository.GetAllAsync();
            return values.Select(x=> new GetAllRoomQueryResponse
            {
                Id = x.Id,
                Description = x.Description,
                BathCount = x.BathCount,
                BedCount = x.BedCount,
                Price = x.Price,
                RoomCoverImage = x.RoomCoverImage,
                RoomNumber = x.RoomNumber,
                Title = x.Title
            }).ToList();
        }
    }
}
