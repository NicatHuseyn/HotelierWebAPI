using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.RoomQuery.RoomGetById
{
    public class GetByIdRoomQueryHandler : IRequestHandler<GetByIdRoomQueryRequest, GetByIdRoomQueryResponse>
    {
        private readonly IRoomReadRepository _roomReadRepository;
        private readonly IRoomWriteRepository _roomWriteRepository;
        public GetByIdRoomQueryHandler(IRoomReadRepository roomReadRepository, IRoomWriteRepository roomWriteRepository)
        {
            _roomReadRepository = roomReadRepository;
            _roomWriteRepository = roomWriteRepository;
        }

        public async Task<GetByIdRoomQueryResponse> Handle(GetByIdRoomQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _roomReadRepository.GetByIdAsync(request.Id);

            return new GetByIdRoomQueryResponse()
            {
                Description = value.Description,
                BathCount = value.BathCount,
                BedCount = value.BedCount,
                Price = value.Price,
                RoomCoverImage = value.RoomCoverImage,
                RoomNumber = value.RoomNumber,
                Title = value.Title
            };
        }
    }
}
