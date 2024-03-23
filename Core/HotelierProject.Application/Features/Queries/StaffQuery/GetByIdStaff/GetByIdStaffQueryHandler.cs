using HotelierProject.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.StaffQuery.GetByIdStaff
{
    public class GetByIdStaffQueryHandler : IRequestHandler<GetByIdStaffQueryRequest, GetByIdStaffQueryResponse>
    {
        public readonly IStaffReadRepository _staffReadRepository;
        private readonly IStaffWriteRepository _staffWriteRepository;
        public GetByIdStaffQueryHandler(IStaffReadRepository staffReadRepository, IStaffWriteRepository staffWriteRepository)
        {
            _staffReadRepository = staffReadRepository;
            _staffWriteRepository = staffWriteRepository;
        }


        public async Task<GetByIdStaffQueryResponse> Handle(GetByIdStaffQueryRequest request, CancellationToken cancellationToken)
        {
            var staff = await _staffReadRepository.GetByIdAsync(request.Id);
            return new GetByIdStaffQueryResponse
            {
                Id = staff.Id,
                Name = staff.Name,
                FaceBookUrl = staff.FaceBookUrl,
                InstagramUrl = staff.InstagramUrl,
                Profeesion = staff.Profeesion,
                TwitterUrl = staff.TwitterUrl
            };
        }
    }
}
