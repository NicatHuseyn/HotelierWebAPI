using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.StaffQuery.GetAllStaff
{
    public class GetAllStaffQueryHandler : IRequestHandler<GetAllStaffQueryRequest, List<GetAllStaffQueryResponse>>
    {
        private readonly IStaffReadRepository _staffReadRepository;

        public GetAllStaffQueryHandler(IStaffReadRepository staffReadRepository)
        {
            _staffReadRepository = staffReadRepository;
        }

        public async Task<List<GetAllStaffQueryResponse>> Handle(GetAllStaffQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _staffReadRepository.GetAllAsync();
            return values.Select(x=> new GetAllStaffQueryResponse
            {
                Id = x.Id,
                Name = x.Name,
                FaceBookUrl = x.FaceBookUrl,
                TwitterUrl = x.TwitterUrl,
                InstagramUrl = x.InstagramUrl,
                Profeesion  =x.Profeesion
            }).ToList();
        }
    }
}
